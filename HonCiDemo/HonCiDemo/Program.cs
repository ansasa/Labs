using System;
using System.Collections.Generic;
using System.Text;

namespace Hon.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new PriorityCalculator();
            Console.WriteLine(calc.Calculate(90)); // just a demo run
        }
    }
}

