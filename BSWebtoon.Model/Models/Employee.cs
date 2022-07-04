using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Activities = new HashSet<Activity>();
            Comics = new HashSet<Comic>();
            Episodes = new HashSet<Episode>();
            Reports = new HashSet<Report>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime HireDate { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Comic> Comics { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
