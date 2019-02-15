using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            double number = double.Parse(input);

            //Console.WriteLine("{number}");
            Console.WriteLine($"{number:###.####}"); //# and 0 
            Console.WriteLine($"{number:000.0000}"); //# and 0 
            Console.WriteLine($"{number:0.##}"); //# and 0 
            Console.WriteLine($"${number:#,0.00}"); //# and 0 
            Console.WriteLine($"{number:0,0.00}"); //# and 0 
        }
    }
}
