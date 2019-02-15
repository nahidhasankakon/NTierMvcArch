using NTierMvc.DAL;
using System.Collections.Generic;

namespace NTierMvc.BLL
{
    public interface IEmployee
    {
        List<Employee> GetEmployee();
        Employee AddEmployee(Employee employee);
    }
}
