using PayRoll.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Service
{
    internal interface IEmployeeService
    {
        void GetAllEmployees();
        void GetEmployeeById();
        void AddEmployee();
        void UpdateEmployee();
        void RemoveEmployee();
    }
}
