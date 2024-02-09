﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Exceptions
{
    public class EmployeeNotFoundException:ApplicationException
    {
        public EmployeeNotFoundException() 
        {
        
        }
        public EmployeeNotFoundException(string message): base(message)
        {
        
        }

    }
}
