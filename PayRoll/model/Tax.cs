using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.model
{
    public class Tax
    {
        int _taxID;
        int _employeeID;
        int _taxYear;
        decimal _taxableIncome;
        decimal _taxAmount;
        public int TaxID
        {
            get { return _taxID; }
            set { _taxID = value; }
        }
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public int TaxYear
        {
            get { return _taxYear; }
            set { _taxYear = value; }
        }
        public decimal TaxableIncome
        {
            get { return _taxableIncome; }
            set { _taxableIncome = value; }
        }
        public decimal TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }
        public override string ToString()
        {
            return $"TaxID: {TaxID}, EmployeeID: {EmployeeID}, TaxYear: {TaxYear}, TaxableIncome: {TaxableIncome}, TaxAmount: {TaxAmount}";
        }

        public Tax()
        {

        }
        public Tax(int taxID, int employeeID, int taxYear, decimal taxableIncome, decimal taxAmount)
        {
            _taxID = taxID;
            _employeeID = employeeID;
            _taxYear = taxYear;
            _taxableIncome = taxableIncome;
            _taxAmount = taxAmount;
        }
    }
}
