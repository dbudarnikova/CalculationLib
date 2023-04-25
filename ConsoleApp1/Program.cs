using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 6, b = 3;
            Console.WriteLine("a + b = {0}", CalculationLib.CalculationLib.Plus(a, b));
            Console.WriteLine("a - b = {0}", CalculationLib.CalculationLib.Minus(a, b));
            Console.WriteLine("a / b = {0}", CalculationLib.CalculationLib.Divide(a, b));
            Console.WriteLine("a * b = {0}", CalculationLib.CalculationLib.Multiply(a, b));
            Console.ReadLine();




        }
    }
}
