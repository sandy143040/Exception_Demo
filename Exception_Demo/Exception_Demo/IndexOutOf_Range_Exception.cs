﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class IndexOutOf_Range_Exception
    {
        public void Range()
        {
            try
            {
                List<Exception> exceptions = new List<Exception>();
                Console.WriteLine(exceptions[2]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
