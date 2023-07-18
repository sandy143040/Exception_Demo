using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class DivideByZero_Exception
    {
        public void Custom()
        {
            int x = 0;
            try
            {
                int a = 100 / x;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
