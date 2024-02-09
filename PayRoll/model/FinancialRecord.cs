using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.model
{
    internal class FinancialRecord
    {
        int _recordID;
        int _employeeID;
        DateTime _recordDate;
        String _description;
        decimal _amount;
        string _recordType;
        public int RecordID
        {
            get { return _recordID; }
            set { _recordID = value; }
        }
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public DateTime RecordDate
        {
            get { return _recordDate; }
            set { _recordDate = value; }
        }
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        public override string ToString()
        {
            return $"RecordID::{RecordID}\t EmployeeID::{EmployeeID}\t RecordDate::{RecordDate}\t Description:{Description}\t Amount::{Amount}\t RecordType::{RecordType}";
        }
        public FinancialRecord()
        {

        }
        public FinancialRecord(int recordID, int employeeID, DateTime recordDate, string description, decimal amount, string recordType)
        {
            RecordID = recordID;
            EmployeeID = employeeID;
            RecordDate = recordDate;
            Description = description;
            Amount = amount;
            RecordType = recordType;
        }
    }
}
