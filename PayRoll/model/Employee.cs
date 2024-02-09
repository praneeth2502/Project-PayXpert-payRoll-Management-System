using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.model
{
    public class Employee
    {
        //fields
        int _employeeID;
        string _firstName;
        string _lastName;
        DateTime _dateOfBirth;
        string _gender;
        string _mail;
        string _phoneNumber;
        string _address;
        string _position;
        DateTime _joiningDate;
        DateTime _terminationDate;
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }

        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }
        public DateTime? TerminationDate
        {
            get { return _terminationDate; }
            set
            {
                // Check if the value is null before casting
                if (value.HasValue)
                {
                    _terminationDate = (DateTime)value;
                }
                else
                {
                    // Handle the null case, either set a default value or leave it as null
                    // For example, setting a default value to DateTime.MinValue
                    _terminationDate = DateTime.MinValue;
                }
            }
        }

        public override string ToString()
        {
            return $"EmployeeID::{EmployeeID}\t FirstName::{FirstName}\t LastName::{LastName}\t DateOfBirth::{DateOfBirth}\t Gender::{Gender} \t mail::{Mail} \t phoneno:{PhoneNumber}\t Address::{Address} \t Position::{Position} \t JoiningDate::{JoiningDate} \t Terminationdate::{TerminationDate}";
        }
        public Employee()
        {

        }
        public Employee(int employeeID, string firstName, string lastName, DateTime dateOfBirth, string gender, string mail, string phoneNumber, string address, string position, DateTime joiningDate, DateTime terminationDate)
        {
            _employeeID = employeeID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _gender = gender;
            _mail = mail;
            _phoneNumber = phoneNumber;
            _address = address;
            _position = position;
            _joiningDate = joiningDate;
            _terminationDate = terminationDate;
        }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (today < DateOfBirth.AddYears(age))
                age--;
            return age;
        }

    }
}
