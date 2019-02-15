using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter length in cm: ");
            string input = Console.ReadLine();
            double lengthInCm = double.Parse(input);
            double lengthInInch = lengthInCm / 2.54;

            Console.WriteLine($"{lengthInInch:0.000}");
            Console.WriteLine("{0:0.000}", lengthInInch);
        }
    }
}
