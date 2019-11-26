using System;

namespace Daysofmonth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("january/n31days");
            }
            else if (input == "2")
            {
                Console.WriteLine("feburary/n28days");
            }
           else if (input == "3")
            {
                Console.WriteLine("march/n31days");
            }
            else if (input == "4")
            {
                Console.WriteLine("april/n30days");
            }
        }
    }
}
