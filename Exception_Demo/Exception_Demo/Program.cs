using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pls choose 1 option");
                Console.WriteLine("1.Try-Catch");
                Console.WriteLine("2.Custom Exception");
                Console.WriteLine("3.Null Exception");
                Console.WriteLine("4.IndexOutOfRange");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        HandleException handleException = new HandleException();
                        handleException.Display();
                        break;
                    case 2:
                        DivideByZero_Exception divideByZero_Exception = new DivideByZero_Exception();
                        divideByZero_Exception.Custom();
                        break;
                    case 3:
                        Null_Exception null_Exception = new Null_Exception();
                        null_Exception.DisplayNull();
                        break;
                    case 4:
                        IndexOutOf_Range_Exception indexOutOf_Range = new IndexOutOf_Range_Exception();
                        indexOutOf_Range.Range();
                        break;
                }
            }            
        }
    }
}
