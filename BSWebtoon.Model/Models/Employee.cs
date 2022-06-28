using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Activity = new HashSet<Activity>();
            Comic = new HashSet<Comic>();
            Episode = new HashSet<Episode>();
            Report = new HashSet<Report>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime HireDate { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Comic> Comic { get; set; }
        public virtual ICollection<Episode> Episode { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
