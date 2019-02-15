using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program6
    {
        static void Main()
        {
            //Return a letter grade based on the numerical grade
            //A - 81-100
            //B - 61-80
            //C - 41-60
            //D - <=40

            int numGrade = int.Parse(Console.ReadLine());

            if (numGrade>=81 && numGrade <= 100)
            {
                Console.WriteLine("A");
            } else if (numGrade >= 61)
            {
                Console.WriteLine("B");
            } else if (numGrade >= 41)
            {
                Console.WriteLine("C");
            } else if (numGrade <=40)
            {
                Console.WriteLine("D");
            } else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
