using System.Collections.Generic;

namespace BSWebtoon.Admin.Models.DTO.Activity
{
    public class GetAllEmployeeNameInputDTO
    {

    }

    public class GetAllEmployeeNameOutputDTO : BaseOutputDTO
    {

        public List<WithAllEmployeeName> WeEmployeeName { get; set; }

        public class WithAllEmployeeName
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }


          
        }
    }


}
