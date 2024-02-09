using PayRoll.model;
using PayRoll.Repository;
using PayRoll.Exceptions;
namespace PayRoll.Test
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test_To_ProcessPayrollForMultipleEmployees()
        {
            PayrollServiceRepository payRollServiceRepository = new PayrollServiceRepository();
            string[,] employeePayrollPeriods = new string[,]
            {
                { "1", "2024-01-01", "2024-01-15" },
                {"1",  "2023-01-01", "2023-01-30" },
                {"2",  "2024-01-01", "2024-01-15" }
            };
            List<Payroll> payrollData = new List<Payroll>();
            for (int i = 0; i < employeePayrollPeriods.GetLength(0); i++)
            {
                int employeeId = int.Parse(employeePayrollPeriods[i, 0]);
                DateTime startDate = DateTime.Parse(employeePayrollPeriods[i, 1]);
                DateTime endDate = DateTime.Parse(employeePayrollPeriods[i, 2]);
                var payRoll = payRollServiceRepository.GeneratePayroll(employeeId, startDate, endDate);
                payrollData.AddRange(payRoll);
            }
            Assert.IsNotNull(payrollData);
            Assert.AreEqual(3, payrollData.Count);

        }
        [Test]
        public void Test_To_VerifyErrorHandlingForInvalidEmployeeData()
        {
            EmployeeServiceRepository employeeServiceRepository = new EmployeeServiceRepository();
            int invalidEmployeeId = 100;
            //Exception exception = Assert.Throws<EmployeeNotFoundException>(() => employeeServiceRepository.GetEmployeeById(invalidEmployeeId));
            Assert.Throws<EmployeeNotFoundException>(() => employeeServiceRepository.GetEmployeeById(invalidEmployeeId));
            //Assert.That(exception.Message, Is.EqualTo("Employee ID does not exist."));
            //var result = employeeServiceRepository.GetEmployeeById(invalidEmployeeId);
            //Assert.IsEmpty(result, "ErrorHandling is done for a Invalid EmployeeData");
        }

        [Test]
        public void Test_To_CalculateTax()
        {
           TaxServiceRepository taxServiceRepository = new TaxServiceRepository();
            int EmployeeID = 5;
            int TaxYear = 2024;
            var Tax =taxServiceRepository.CalculateTax(EmployeeID, TaxYear);
            Assert.AreEqual(7000.00,Tax);
        }

    }
}