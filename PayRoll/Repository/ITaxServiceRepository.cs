using PayRoll.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Repository
{
    internal interface ITaxServiceRepository
    {
        List<Tax> GetTaxById(int taxId);
        List<Tax> GetTaxesForEmployee(int employeeId);
        List<Tax> GetTaxesForYear(int taxYear);
        decimal CalculateTax(int employeeId, int taxYear);


    }
}
