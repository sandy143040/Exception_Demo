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
            HandleException handleException = new HandleException();
            handleException.Display();
        }
    }
}
