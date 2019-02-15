using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierMvc.Models
{
    public class EmployeeVm
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}