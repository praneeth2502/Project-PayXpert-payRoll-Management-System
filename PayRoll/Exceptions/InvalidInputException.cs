﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Exceptions
{
    internal class InvalidInputException:ApplicationException
    {
        public InvalidInputException() 
        {
        
        }
        public InvalidInputException(string message) : base(message)
        {

        }
    }

}
