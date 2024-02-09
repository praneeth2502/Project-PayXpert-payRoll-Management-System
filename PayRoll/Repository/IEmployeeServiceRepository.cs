using PayRoll.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Repository
{
    internal interface IEmployeeServiceRepository
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int RemoveEmployee(int employeeId);


    }
}
