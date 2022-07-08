using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWebtoon.Model.Migrations
{
    public partial class omgg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashPlan",
                columns: table => new
                {
                    CashPlanId = table.Column<int>(type: "int", nullable: false, comment: "金幣儲值方案")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CashPlanContent = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "儲值方案內容"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "價錢"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false, comment: "是否啟用")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPlan", x => x.CashPlanId);
                });

            migrationBuilder.CreateTable(
                name: "ComicTag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false, comment: "關鍵表Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "關鍵名稱"),
                    IsMainTag = table.Column<bool>(type: "bit", nullable: false, comment: "是否為主要的Tag"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否刪除該標籤"),
                    AuditEmployeeId = table.Column<int>(type: "int", nullable: false, comment: "審核人員(也是上傳人員)"),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "審核日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordDetail", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false, comment: "員工Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "員工姓名(也是上傳人員)"),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "雇用日期"),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "帳號"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "密碼(加密)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "LoginType",
                columns: table => new
                {
                    LoginTypeId = table.Column<int>(type: "int", nullable: false, comment: "登入方式Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "登入類型名稱(不要有Apple)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginType", x => x.LoginTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false, comment: "金流付款方式")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "付款方式類型名稱"),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false, comment: "是否啟用該狀態"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    RankId = table.Column<int>(type: "int", nullable: false, comment: "排行")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "排行時間(排名更新的時間  排名開始時間)"),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "排名開始時間(保留但可以先塞入資料)"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "排名結束時間(保留但可以先塞入資料)"),
                    ClickCount = table.Column<int>(type: "int", nullable: false, comment: "點擊數量"),
                    PreRank = table.Column<int>(type: "int", nullable: false, comment: "上次排名(以一00:00~下周一00:00)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.RankId);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false, comment: "活動Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "活動名稱"),
                    ActivityStartTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "活動開始時間"),
                    ActivityEndTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "活動結束時間"),
                    ActivityImage = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "活動圖片"),
                    ActivityBgColor = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "活動背景色"),
                    ActivityContent = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "活動文案(HTML)"),
                    PrincipalEmployee = table.Column<int>(type: "int", nullable: false, comment: "建立該活動的員工"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "活動建立時間"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "刪除活動")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activity_Employee",
                        column: x => x.PrincipalEmployee,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comic",
                columns: table => new
                {
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicChineseName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "漫畫中文名稱"),
                    ComicEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "漫畫英文名稱"),
                    ComicNameImage = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "漫畫名稱圖"),
                    HotComicNameImage = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "強檔劇獻名稱圖"),
                    BgCover = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "漫畫背景圖"),
                    HotBgCover = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "強檔劇獻背景圖"),
                    ComicFigure = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "人物圖"),
                    ComicWeekFigure = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "星期列表人物圖"),
                    BgColor = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "背景色"),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "發行日期"),
                    LastPublishDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "最後更新日期"),
                    FinallyPublishDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "完結日期"),
                    UpdateWeek = table.Column<int>(type: "int", nullable: true, comment: "更新星期"),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "出版商"),
                    Painter = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "繪者"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "作者"),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "故事大綱"),
                    BannerVideoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "短影片"),
                    WeekVideoWrb = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "星期列表影片"),
                    ComicVideoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "長影片"),
                    HotVideo = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "強檔劇獻影片"),
                    AuditType = table.Column<int>(type: "int", nullable: false, comment: "審核狀態"),
                    AuditEmployeeId = table.Column<int>(type: "int", nullable: false, comment: "審核人員(也是上傳人員)"),
                    AuditFailReason = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "審核失敗原因"),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "審核時間"),
                    ComicStatus = table.Column<int>(type: "int", nullable: false, comment: "漫畫狀態")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comic", x => x.ComicId);
                    table.ForeignKey(
                        name: "FK_Comic_Employee",
                        column: x => x.AuditEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "帳號名稱"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "暱稱"),
                    Balance = table.Column<decimal>(type: "money", nullable: false, comment: "餘額"),
                    LoginTypeId = table.Column<int>(type: "int", nullable: false, comment: "登入類型"),
                    IsDarkTheme = table.Column<bool>(type: "bit", nullable: false, comment: "是否為深色模式"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "創建時間"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Email"),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "記錄在該登入模式下的相關資料")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Member_LoginType",
                        column: x => x.LoginTypeId,
                        principalTable: "LoginType",
                        principalColumn: "LoginTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComicTagList",
                columns: table => new
                {
                    TageListId = table.Column<int>(type: "int", nullable: false, comment: "關鍵字清單ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(type: "int", nullable: false, comment: "關鍵字Id(以第一個為最主要的標籤)"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicTagList", x => x.TageListId);
                    table.ForeignKey(
                        name: "FK_ComicTag_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComicTag_KeywordDetail",
                        column: x => x.TagId,
                        principalTable: "ComicTag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    EpId = table.Column<int>(type: "int", nullable: false, comment: "集數ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫ID"),
                    EpTitle = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "集數標題"),
                    EpCover = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "集數封面照"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新時間"),
                    UploadTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "作者上傳的時間"),
                    AuditTypeId = table.Column<int>(type: "int", nullable: false, comment: "審核狀態ID"),
                    AuditEmployeeId = table.Column<int>(type: "int", nullable: false, comment: "審核人員(也是上傳人員)"),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "審核時間"),
                    AuditFailReason = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "審核不通過原因"),
                    IsCountdownCoupon = table.Column<bool>(type: "bit", nullable: false, comment: "是否可使用倒數免費券"),
                    IsFree = table.Column<bool>(type: "bit", nullable: false, comment: "是否為免費")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epsiode", x => x.EpId);
                    table.ForeignKey(
                        name: "FK_Episode_Employee",
                        column: x => x.AuditEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Epsiode_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClickRecord",
                columns: table => new
                {
                    ClickRecordId = table.Column<int>(type: "int", nullable: false, comment: "點擊紀錄ID"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫Id"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "點擊的時間"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClickRecord", x => x.ClickRecordId);
                    table.ForeignKey(
                        name: "FK_ClickRecord_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClickRecord_Member",
                        column: x => x.ClickRecordId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "int", nullable: false, comment: "我的最愛Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_MyLove_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyLove_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RechargeRecord",
                columns: table => new
                {
                    RechargeRecordId = table.Column<int>(type: "int", nullable: false, comment: "儲值ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員ID"),
                    CashPlanId = table.Column<int>(type: "int", nullable: true, comment: "金幣儲值方案Id"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "儲值時間"),
                    PaymentId = table.Column<int>(type: "int", nullable: false, comment: "付款方式ID"),
                    CashPlanContent = table.Column<int>(type: "int", nullable: false, comment: "儲值方案內容(EX:1200金幣)"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "價錢")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RechargeRecord", x => x.RechargeRecordId);
                    table.ForeignKey(
                        name: "FK_Recharge_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recharge_PayMethod",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RechargeRecord_CashPlan",
                        column: x => x.CashPlanId,
                        principalTable: "CashPlan",
                        principalColumn: "CashPlanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false, comment: "評論Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員Id"),
                    EpId = table.Column<int>(type: "int", nullable: false, comment: "集數Id"),
                    ReplyToCommentId = table.Column<int>(type: "int", nullable: true, comment: "被回復評論Id"),
                    IsSpoiler = table.Column<bool>(type: "bit", nullable: false, comment: "是否暴雷"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "評論時間"),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "評論內容"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否刪除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Comment",
                        column: x => x.ReplyToCommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Episode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false, comment: "劵ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: true, comment: "漫畫Id"),
                    ActivityId = table.Column<int>(type: "int", nullable: true, comment: "活動Id"),
                    CouponTypeId = table.Column<int>(type: "int", nullable: false, comment: "券的類型Id(有通用券跟倒數券、閱讀)"),
                    OriginQuantity = table.Column<int>(type: "int", nullable: false, comment: "原始數量"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "取得時間"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "現有數量")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.CouponId);
                    table.ForeignKey(
                        name: "FK_Coupon_Activity",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadCoupon_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadCoupon_Epsiode",
                        column: x => x.ActivityId,
                        principalTable: "Episode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EpContent",
                columns: table => new
                {
                    EpContentId = table.Column<int>(type: "int", nullable: false, comment: "漫畫圖片Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpId = table.Column<int>(type: "int", nullable: false, comment: "集數Id"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "集數內容圖片路徑"),
                    Page = table.Column<int>(type: "int", nullable: false, comment: "頁次")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpContent", x => x.EpContentId);
                    table.ForeignKey(
                        name: "FK_ComicPic_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Episode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentLikeRecord",
                columns: table => new
                {
                    CommentLikesId = table.Column<int>(type: "int", nullable: false, comment: "留言按讚數Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員Id"),
                    CommentId = table.Column<int>(type: "int", nullable: false, comment: "評論Id"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "按讚時間"),
                    IsLike = table.Column<bool>(type: "bit", nullable: false, comment: "是否按讚")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.CommentLikesId);
                    table.ForeignKey(
                        name: "FK_Likes_Comment",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false, comment: "檢舉Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: false, comment: "評論Id"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "檢舉日期"),
                    AuditType = table.Column<int>(type: "int", nullable: false, comment: "審核狀態"),
                    AuditEmployeeId = table.Column<int>(type: "int", nullable: false, comment: "審核人員"),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "審核時間"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "檢舉詳細理由")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Report_Comment",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Employee",
                        column: x => x.AuditEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CouponUsedRecord",
                columns: table => new
                {
                    CouponRecordId = table.Column<int>(type: "int", nullable: false, comment: "券使用紀錄ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員"),
                    EpId = table.Column<int>(type: "int", nullable: false, comment: "集數"),
                    CouponId = table.Column<int>(type: "int", nullable: false, comment: "券ID"),
                    StartReadTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "開始閱讀日期"),
                    EndReadTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "結束閱讀日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseRecord", x => x.CouponRecordId);
                    table.ForeignKey(
                        name: "FK_CouponUsedRecord_Coupon",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
                        principalColumn: "CouponId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CouponUsedRecord_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Episode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CouponUsedRecord_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViewRecord",
                columns: table => new
                {
                    ViewRecorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false, comment: "會員"),
                    EpContentId = table.Column<int>(type: "int", nullable: false, comment: "漫畫圖片Id"),
                    ViewTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "觀看時間"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewRecord", x => x.ViewRecorId);
                    table.ForeignKey(
                        name: "FK_ViewRecord_EpContent",
                        column: x => x.EpContentId,
                        principalTable: "EpContent",
                        principalColumn: "EpContentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ViewRecord_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_PrincipalEmployee",
                table: "Activity",
                column: "PrincipalEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_ClickRecord_ComicId",
                table: "ClickRecord",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Comic_AuditEmployeeId",
                table: "Comic",
                column: "AuditEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicTagList_ComicId",
                table: "ComicTagList",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicTagList_TagId",
                table: "ComicTagList",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EpId",
                table: "Comment",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId",
                table: "Comment",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ReplyToCommentId",
                table: "Comment",
                column: "ReplyToCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikeRecord_CommentId",
                table: "CommentLikeRecord",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikeRecord_MemberId",
                table: "CommentLikeRecord",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_ActivityId",
                table: "Coupon",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_ComicId",
                table: "Coupon",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsedRecord_CouponId",
                table: "CouponUsedRecord",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsedRecord_EpId",
                table: "CouponUsedRecord",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsedRecord_MemberId",
                table: "CouponUsedRecord",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_EpContent_EpId",
                table: "EpContent",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_Episode_AuditEmployeeId",
                table: "Episode",
                column: "AuditEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Episode_ComicId",
                table: "Episode",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ComicId",
                table: "Favorite",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_MemberId",
                table: "Favorite",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_LoginTypeId",
                table: "Member",
                column: "LoginTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_ComicId",
                table: "Rank",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_CashPlanId",
                table: "RechargeRecord",
                column: "CashPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_MemberId",
                table: "RechargeRecord",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_PaymentId",
                table: "RechargeRecord",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_AuditEmployeeId",
                table: "Report",
                column: "AuditEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_CommentId",
                table: "Report",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_EpContentId",
                table: "ViewRecord",
                column: "EpContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_MemberId",
                table: "ViewRecord",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClickRecord");

            migrationBuilder.DropTable(
                name: "ComicTagList");

            migrationBuilder.DropTable(
                name: "CommentLikeRecord");

            migrationBuilder.DropTable(
                name: "CouponUsedRecord");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "RechargeRecord");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "ViewRecord");

            migrationBuilder.DropTable(
                name: "ComicTag");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "CashPlan");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "EpContent");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "LoginType");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
