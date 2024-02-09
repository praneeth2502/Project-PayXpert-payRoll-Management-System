using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.model
{
    public class Payroll
    {
        int _payrollID;
        int _employeeID;
        DateTime _payPeriodStartDate;
        DateTime _payPeriodEndDate;
        decimal _basicSalary;
        decimal _overtimePay;
        decimal _deductions;
        decimal _netSalary;
        public int PayrollID
        {
            get { return _payrollID; }
            set { _payrollID = value; }
        }
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public DateTime PayPeriodStartDate
        {
            get { return _payPeriodStartDate; }
            set { _payPeriodStartDate = value; }
        }
        public DateTime PayPeriodEndDate
        {
            get { return _payPeriodEndDate; }
            set { _payPeriodEndDate = value; }
        }
        public decimal BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }
        public decimal OvertimePay
        {
            get { return _overtimePay; }
            set { _overtimePay = value; }
        }
        public decimal Deductions
        {
            get { return _deductions; }
            set { _deductions = value; }
        }
        public decimal NetSalary
        {
            get { return _netSalary; }
            set { _netSalary = value; }
        }
        public override string ToString()
        {
            return $"PayRollId::{PayrollID}\t EmployeeID::{EmployeeID}\t PayPeriodStartDate::{PayPeriodStartDate}\t PayPeriodEndDate:{PayPeriodEndDate}\t BasicSalary::{BasicSalary}\t OvertimePay::{OvertimePay}\t Deductions::{Deductions}\t NetSalary::{NetSalary}";
        }
        public Payroll()
        {

        }
        public Payroll(int payrollID, int employeeID, DateTime payPeriodStartDate, DateTime payPeriodEndDate, decimal basicSalary, decimal overtimePay, decimal deductions, decimal netSalary)
        {
            _payrollID = payrollID;
            _employeeID = employeeID;
            _payPeriodStartDate = payPeriodStartDate;
            _payPeriodEndDate = payPeriodEndDate;
            _basicSalary = basicSalary;
            _overtimePay = overtimePay;
            _deductions = deductions;
            _netSalary = netSalary;
        }
    }
}
