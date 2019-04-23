using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public struct Complex {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }
    class Program{
        
        static void Main(string[] args)
            {
                Complex a = new Complex() { Real = 1, Imaginary = 2 };
                Complex b = new Complex() { Real = 1, Imaginary = 2 };
                Complex c = a + b;
            }

    }
}
