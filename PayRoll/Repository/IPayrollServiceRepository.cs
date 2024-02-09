using PayRoll.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Repository
{
    internal interface IPayrollServiceRepository
    {
        List<Payroll> GetPayrollById(int payrollId);
        List<Payroll> GetPayrollsForEmployee(int employeeId);
        List<Payroll> GetPayrollsForPeriod(DateTime startDate, DateTime endDate);

        List<Payroll> GeneratePayroll(int employeeId, DateTime startDate, DateTime endDate);



    }
}
