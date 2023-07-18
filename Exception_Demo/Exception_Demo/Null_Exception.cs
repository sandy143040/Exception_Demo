using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class Null_Exception
    {
        public void DisplayNull()
        {
            //try
            //{
            //    string str = null;
            //}
            //catch(NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            string str = null;
            //Null check
            if(str != null) 
            {
                Console.WriteLine(str.Substring(5));
            }
            else
            {
                Console.WriteLine("string is null");
            }
        }
    }
}
