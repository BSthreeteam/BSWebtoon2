using System.Threading.Tasks;
using static BSWebtoon.Front.Models.DTO.Login.LoginAccountDTO;

namespace BSWebtoon.Front.Service.MemberService
{
    public interface IMemberService
    {
        void LoginTypeCreate();
        void MemberCreate();

        void MemberUpdateData();
        void LogoutAccount();
        Task<Login3rdOutputDTO> LoginAccount(Login3rdInputDTO input);

    }
}
