using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Service
{
    internal interface IFinancialRecordService
    {
        void GetFinancialRecordById();
        void GetFinancialRecordsForEmployee();
        void GetFinancialRecordsForDate();
        void AddFinancialRecord();



    }
}
