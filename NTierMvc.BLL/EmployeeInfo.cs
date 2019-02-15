using NTierMvc.DAL;
using System.Collections.Generic;
using System.Linq;

namespace NTierMvc.BLL
{
    public class EmployeeInfo
    {
        NTierMvcDBEntities context;
        public EmployeeInfo()
        {
            context = new NTierMvcDBEntities();
        }

        public List<Employee> GetEmployee()
        {
            return context.Employees.ToList();
        }
    }
}
