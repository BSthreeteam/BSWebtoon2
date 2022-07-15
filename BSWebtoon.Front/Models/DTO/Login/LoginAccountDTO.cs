namespace BSWebtoon.Front.Models.DTO.Login
{
    public class LoginAccountDTO
    {
        public class Login3rdInputDTO
        {
            public string Provider { get; set; }//登入的第三方名稱
            public string NameIdentifier { get; set; }
            public string AccountName { get; set; }
            public string Email { get; set; }
        }
        public class Login3rdOutputDTO
        {
            public bool IsSuccess { get; set; }

        }
    }
}
