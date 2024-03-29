﻿using Microsoft.AspNetCore.Mvc;
using BSWebtoon.Front.Models;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;
using System.Web;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using static BSWebtoon.Front.Models.DTO.NewebPay.NewebPayDTO;
using System.Collections.Generic;
using System.Linq;
using BSWebtoon.Model.Repository;
using BSWebtoon.Model.Models;
using BSWebtoon.Front.Service.RechargeService;
using BSWebtoon.Front.Models.DTO.CashPlan;
using System.Security.Claims;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewebPay.Controllers
{
    public class NewebPayController : Controller
    {
        private readonly BSRepository _repository;
        private readonly ILogger<NewebPayController> _logger;
        //---------- hana add ------ 
        private readonly IRechargeService _rechargeService;

        public NewebPayController(ILogger<NewebPayController> logger, BSRepository repository, IRechargeService rechargeService)
        {
            _logger = logger;
            _repository = repository;
            _rechargeService = rechargeService;

        }

        public IActionResult Index() //NewebPay/Index
        {

            IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            // 產生測試資訊
            ViewData["MerchantID"] = Config.GetSection("MerchantID").Value;
            ViewData["MerchantOrderNo"] = DateTime.Now.ToString("yyyyMMddHHmmss");  //訂單編號
            ViewData["ExpireDate"] = DateTime.Now.AddDays(3).ToString("yyyyMMdd"); //繳費有效期限

            string url_start = $"{Request.Scheme}://{Request.Host.Value}";
            ViewData["ReturnURL"] = $"{url_start}/NewebPay/CallbackReturn"; //支付完成返回商店網址
            ViewData["CustomerURL"] = $"{url_start}/NewebPay/CallbackCustomer"; //商店取號網址
            ViewData["NotifyURL"] = $"{url_start}/NewebPay/CallbackNotify"; //支付通知網址
            ViewData["ClientBackURL"] = $"{url_start}/NewebPay/Index"; //返回商店網址

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 傳送訂單至藍新金流
        /// </summary>
        /// <param name="inModel"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        public IActionResult SendToNewebPay(SendToNewebPayIn inModel)
        {
            IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();

            SendToNewebPayOut outModel = new SendToNewebPayOut();

            var typeName = _repository.GetAll<CashPlan>().Where(x => x.CashPlanId == int.Parse(inModel.ItemDesc)).Select(x => x.CashPlanContent).FirstOrDefault().ToString();
            var typePrice = _repository.GetAll<CashPlan>().Where(x => x.CashPlanId == int.Parse(inModel.ItemDesc)).Select(x => x.Price).FirstOrDefault();
            // 藍新金流線上付款
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);

            // 交易欄位
            List<KeyValuePair<string, string>> TradeInfo = new List<KeyValuePair<string, string>>();
            // 商店代號
            TradeInfo.Add(new KeyValuePair<string, string>("MerchantID", Config.GetSection("MerchantID").Value));
            // 回傳格式
            TradeInfo.Add(new KeyValuePair<string, string>("RespondType", "String"));
            // TimeStamp
            TradeInfo.Add(new KeyValuePair<string, string>("TimeStamp", DateTimeOffset.Now.ToOffset(new TimeSpan(8, 0, 0)).ToUnixTimeSeconds().ToString()));
            // 串接程式版本
            TradeInfo.Add(new KeyValuePair<string, string>("Version", "2.0"));
            // 商店訂單編號
            TradeInfo.Add(new KeyValuePair<string, string>("MerchantOrderNo", $"{memberId}_{DateTime.Now.ToString("yyyyMMddHHmmss")}"));
            // 訂單金額
            TradeInfo.Add(new KeyValuePair<string, string>("Amt", $"{(int)typePrice}"));//等等
            // 商品資訊
            TradeInfo.Add(new KeyValuePair<string, string>("ItemDesc", $"{typeName}金幣"));//等等

            // 繳費有效期限(適用於非即時交易)
            //TradeInfo.Add(new KeyValuePair<string, string>("ExpireDate", inModel.ExpireDate));//我們是即時交易
            // 支付完成返回商店網址
            TradeInfo.Add(new KeyValuePair<string, string>("ReturnURL", $"{Request.Scheme}://{Request.Host.Value}/NewebPay/CallbackReturn"));
            // 支付通知網址
            TradeInfo.Add(new KeyValuePair<string, string>("NotifyURL", $"{Request.Scheme}://{Request.Host}{Request.Path}Home/CallbackNotify"));
            // 商店取號網址
            TradeInfo.Add(new KeyValuePair<string, string>("CustomerURL", $"{Request.Scheme}://{Request.Host}{Request.Path}Home/CallbackCustomer"));
            // 支付取消返回商店網址
            TradeInfo.Add(new KeyValuePair<string, string>("ClientBackURL", $"{Request.Scheme}://{Request.Host.Value}/Recommend/Recommend"));
            // 付款人電子信箱
            //TradeInfo.Add(new KeyValuePair<string, string>("Email", inModel.Email));//等等
            // 付款人電子信箱 是否開放修改(1=可修改 0=不可修改)
            TradeInfo.Add(new KeyValuePair<string, string>("EmailModify", "0"));
            //信用卡 付款
            TradeInfo.Add(new KeyValuePair<string, string>("CREDIT", "1"));

            string TradeInfoParam = string.Join("&", TradeInfo.Select(x => $"{x.Key}={x.Value}"));

            // API 傳送欄位
            // 商店代號
            outModel.MerchantID = Config.GetSection("MerchantID").Value;
            // 串接程式版本
            outModel.Version = "2.0";
            //交易資料 AES 加解密
            string HashKey = Config.GetSection("HashKey").Value;//API 串接金鑰
            string HashIV = Config.GetSection("HashIV").Value;//API 串接密碼
            string TradeInfoEncrypt = EncryptAESHex(TradeInfoParam, HashKey, HashIV);
            outModel.TradeInfo = TradeInfoEncrypt;
            //交易資料 SHA256 加密
            outModel.TradeSha = EncryptSHA256($"HashKey={HashKey}&{TradeInfoEncrypt}&HashIV={HashIV}");

            return Json(outModel);
        }

        /// <summary>
        /// 支付完成返回網址
        /// </summary>

        public async Task<IActionResult> CallbackReturn()
        {
            // 接收參數
            StringBuilder receive = new StringBuilder();
            foreach (var item in Request.Form)
            {
                receive.AppendLine(item.Key + "=" + item.Value + "<br>");
            }
            ViewData["ReceiveObj"] = receive.ToString();

            // 解密訊息
            IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            string HashKey = Config.GetSection("HashKey").Value;//API 串接金鑰
            string HashIV = Config.GetSection("HashIV").Value;//API 串接密碼

            string TradeInfoDecrypt = DecryptAESHex(Request.Form["TradeInfo"], HashKey, HashIV);
            NameValueCollection decryptTradeCollection = HttpUtility.ParseQueryString(TradeInfoDecrypt);
            receive.Length = 0;

            //將成功訂單存入資料庫
            var input_RechargeRecord = new RechargeRecord()
            {
                RechargeRecordId = 4,
                MemberId = 1,
                CashPlanId = 1,
                CreateTime = DateTime.UtcNow,
                PaymentId = 1,
                CashPlanContent = 0,
                Price = 0,
            };
            var currentMemberId = 0;
            foreach (String key in decryptTradeCollection.AllKeys)
            {
                var status = decryptTradeCollection["Status"];//SUCCESS
                if (status == "SUCCESS")
                {
                    //宣告MemberId
                    var MemberId = 123;
                    if (key == "MerchantOrderNo")
                    {
                        string[] sArray = decryptTradeCollection[key].Split("_");
                        MemberId = Convert.ToInt32(sArray[0]);
                        currentMemberId = Convert.ToInt32(sArray[0]);
                        input_RechargeRecord.MemberId = MemberId;
                    }
                    else if (key == "ItemDesc")
                    {
                        int gold = Convert.ToInt32(decryptTradeCollection[key].Split("金幣")[0]);
                        input_RechargeRecord.CashPlanContent = gold;
                    }
                    else if (key == "Amt")
                    {
                        input_RechargeRecord.Price = Convert.ToInt32(decryptTradeCollection[key]);
                    }
                    else if (key == "PaymentMethod")
                    {
                        switch (decryptTradeCollection[key])
                        {
                            case "CreditCard":
                                input_RechargeRecord.CashPlanId = 1;
                                break;
                            case "Ez Pay":
                                input_RechargeRecord.CashPlanId = 2;
                                break;
                            case "Line Pay":
                                input_RechargeRecord.CashPlanId = 3;
                                break;
                            case "Taiwan Pay":
                                input_RechargeRecord.CashPlanId = 4;
                                break;
                            default:
                                input_RechargeRecord.CashPlanId = 1;
                                break;
                        }
                        //更新帳戶餘額
                        var CurrentMember = _repository.GetAll<Member>().Where(x => x.MemberId == input_RechargeRecord.MemberId).FirstOrDefault();
                        var Balance = (int)_repository.GetAll<Member>().Where(x => x.MemberId == input_RechargeRecord.MemberId).Select(x => x.Balance).FirstOrDefault();
                        var newBlance = input_RechargeRecord.CashPlanContent + Balance;
                        CurrentMember.Balance = newBlance;
                        _repository.Update(CurrentMember);
                        _repository.SaveChange();
                    }

                    TempData["message"] = "成功付款";
                }
                else
                {
                    TempData["message"] = "付款失敗";

                }
            }

            _rechargeService.RechargeRecordCreateNew(input_RechargeRecord);

            ViewData["TradeInfo"] = receive.ToString();



            return Redirect($"~/Account/AccountInfo/{currentMemberId}");
        }

        /// <summary>
        /// 商店取號網址
        /// </summary>
        /// <returns></returns>
        public IActionResult CallbackCustomer()
        {
            // 接收參數
            StringBuilder receive = new StringBuilder();
            foreach (var item in Request.Form)
            {
                receive.AppendLine(item.Key + "=" + item.Value + "<br>");
            }
            ViewData["ReceiveObj"] = receive.ToString();

            // 解密訊息
            IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            string HashKey = Config.GetSection("HashKey").Value;//API 串接金鑰
            string HashIV = Config.GetSection("HashIV").Value;//API 串接密碼
            string TradeInfoDecrypt = DecryptAESHex(Request.Form["TradeInfo"], HashKey, HashIV);
            NameValueCollection decryptTradeCollection = HttpUtility.ParseQueryString(TradeInfoDecrypt);
            receive.Length = 0;
            foreach (String key in decryptTradeCollection.AllKeys)
            {
                receive.AppendLine(key + "=" + decryptTradeCollection[key] + "<br>");
            }
            ViewData["TradeInfo"] = receive.ToString();
            return View();
        }

        /// <summary>
        /// 支付通知網址
        /// </summary>
        /// <returns></returns>
        public IActionResult CallbackNotify()
        {
            // 接收參數
            StringBuilder receive = new StringBuilder();
            foreach (var item in Request.Form)
            {
                receive.AppendLine(item.Key + "=" + item.Value + "<br>");
            }
            ViewData["ReceiveObj"] = receive.ToString();

            // 解密訊息
            IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            string HashKey = Config.GetSection("HashKey").Value;//API 串接金鑰
            string HashIV = Config.GetSection("HashIV").Value;//API 串接密碼
            string TradeInfoDecrypt = DecryptAESHex(Request.Form["TradeInfo"], HashKey, HashIV);
            NameValueCollection decryptTradeCollection = HttpUtility.ParseQueryString(TradeInfoDecrypt);
            receive.Length = 0;
            foreach (String key in decryptTradeCollection.AllKeys)
            {
                receive.AppendLine(key + "=" + decryptTradeCollection[key] + "<br>");
            }
            ViewData["TradeInfo"] = receive.ToString();

            return View();
        }

        /// <summary>
        /// 加密後再轉 16 進制字串
        /// </summary>
        /// <param name="source">加密前字串</param>
        /// <param name="cryptoKey">加密金鑰</param>
        /// <param name="cryptoIV">cryptoIV</param>
        /// <returns>加密後的字串</returns>
        public string EncryptAESHex(string source, string cryptoKey, string cryptoIV)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(source))
            {
                var encryptValue = EncryptAES(Encoding.UTF8.GetBytes(source), cryptoKey, cryptoIV);

                if (encryptValue != null)
                {
                    result = BitConverter.ToString(encryptValue)?.Replace("-", string.Empty)?.ToLower();
                }
            }

            return result;
        }

        /// <summary>
        /// 字串加密AES
        /// </summary>
        /// <param name="source">加密前字串</param>
        /// <param name="cryptoKey">加密金鑰</param>
        /// <param name="cryptoIV">cryptoIV</param>
        /// <returns>加密後字串</returns>
        public byte[] EncryptAES(byte[] source, string cryptoKey, string cryptoIV)
        {
            byte[] dataKey = Encoding.UTF8.GetBytes(cryptoKey);
            byte[] dataIV = Encoding.UTF8.GetBytes(cryptoIV);

            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.Mode = System.Security.Cryptography.CipherMode.CBC;
                aes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                aes.Key = dataKey;
                aes.IV = dataIV;

                using (var encryptor = aes.CreateEncryptor())
                {
                    return encryptor.TransformFinalBlock(source, 0, source.Length);
                }
            }
        }

        /// <summary>
        /// 字串加密SHA256
        /// </summary>
        /// <param name="source">加密前字串</param>
        /// <returns>加密後字串</returns>
        public string EncryptSHA256(string source)
        {
            string result = string.Empty;

            using (System.Security.Cryptography.SHA256 algorithm = System.Security.Cryptography.SHA256.Create())
            {
                var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(source));

                if (hash != null)
                {
                    result = BitConverter.ToString(hash)?.Replace("-", string.Empty)?.ToUpper();
                }

            }
            return result;
        }

        /// <summary>
        /// 16 進制字串解密
        /// </summary>
        /// <param name="source">加密前字串</param>
        /// <param name="cryptoKey">加密金鑰</param>
        /// <param name="cryptoIV">cryptoIV</param>
        /// <returns>解密後的字串</returns>
        public string DecryptAESHex(string source, string cryptoKey, string cryptoIV)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(source))
            {
                // 將 16 進制字串 轉為 byte[] 後
                byte[] sourceBytes = ToByteArray(source);

                if (sourceBytes != null)
                {
                    // 使用金鑰解密後，轉回 加密前 value
                    result = Encoding.UTF8.GetString(DecryptAES(sourceBytes, cryptoKey, cryptoIV)).Trim();
                }
            }

            return result;
        }

        /// <summary>
        /// 將16進位字串轉換為byteArray
        /// </summary>
        /// <param name="source">欲轉換之字串</param>
        /// <returns></returns>
        public byte[] ToByteArray(string source)
        {
            byte[] result = null;

            if (!string.IsNullOrWhiteSpace(source))
            {
                var outputLength = source.Length / 2;
                var output = new byte[outputLength];

                for (var i = 0; i < outputLength; i++)
                {
                    output[i] = Convert.ToByte(source.Substring(i * 2, 2), 16);
                }
                result = output;
            }

            return result;
        }

        /// <summary>
        /// 字串解密AES
        /// </summary>
        /// <param name="source">解密前字串</param>
        /// <param name="cryptoKey">解密金鑰</param>
        /// <param name="cryptoIV">cryptoIV</param>
        /// <returns>解密後字串</returns>
        public static byte[] DecryptAES(byte[] source, string cryptoKey, string cryptoIV)
        {
            byte[] dataKey = Encoding.UTF8.GetBytes(cryptoKey);
            byte[] dataIV = Encoding.UTF8.GetBytes(cryptoIV);

            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.Mode = System.Security.Cryptography.CipherMode.CBC;
                // 智付通無法直接用PaddingMode.PKCS7，會跳"填補無效，而且無法移除。"
                // 所以改為PaddingMode.None並搭配RemovePKCS7Padding
                aes.Padding = System.Security.Cryptography.PaddingMode.None;
                aes.Key = dataKey;
                aes.IV = dataIV;

                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] data = decryptor.TransformFinalBlock(source, 0, source.Length);
                    int iLength = data[data.Length - 1];
                    var output = new byte[data.Length - iLength];
                    Buffer.BlockCopy(data, 0, output, 0, output.Length);
                    return output;
                }
            }
        }
    }
}