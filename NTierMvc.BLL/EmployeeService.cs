using NTierMvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMvc.BLL
{
    public class EmployeeService: IEmployee
    {
        private NTierMvcDBEntities context;
        public EmployeeService(NTierMvcDBEntities db)
        {
            context = db;
        }

        public List<Employee> GetEmployee()
        {
            return context.Employees.ToList();
        }

        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();

            return employee;
        }
    }
}
