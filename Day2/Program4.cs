using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        static void Main()
        {
            //Nested if in the nested form
            int day = int.Parse(Console.ReadLine());

            if (day == 0)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                if (day == 1)
                {
                    Console.WriteLine("Monday");
                }
                else
                {
                    if (day == 2)
                    {
                        Console.WriteLine("Tuesday");
                    }
                    else
                    {
                        if (day == 3)
                        {
                            Console.WriteLine("Wednesday");
                        }
                        else if (day == 4)
                        {
                            Console.WriteLine("Thursday");
                        }
                        else if (day == 5)
                        {
                            Console.WriteLine("Friday");
                        }
                        else if (day == 6)
                        {
                            Console.WriteLine("Saturday");
                        }
                        else
                        {
                            Console.WriteLine("Not a valid input");
                        }

                    }

                }
            }


        }
    }
}
