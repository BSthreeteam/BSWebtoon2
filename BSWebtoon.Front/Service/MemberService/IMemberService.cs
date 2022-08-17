using BSWebtoon.Model.Models;
using System.Threading.Tasks;
using static BSWebtoon.Front.Models.DTO.Login.LoginAccountDTO;

namespace BSWebtoon.Front.Service.MemberService
{
    public interface IMemberService
    {
        void LoginTypeCreate();
        void MemberCreate();

        void MemberUpdateData();
        Task LogoutAccountAsync();
        Task<Login3rdOutputDTO> LoginAccount(Login3rdInputDTO input);

        Member GetMemberByID(int memberId);
        int GetCurrentMemberID();
    }
}
