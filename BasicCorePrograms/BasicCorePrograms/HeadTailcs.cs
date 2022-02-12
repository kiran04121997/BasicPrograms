using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HeadTailcs
    {
        public void Check_leap_year()
        {
           Console.WriteLine("Please Enter a Year in four digits");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1000 && year <= 9999)
            {

                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine(year + " is a Leap year");

                }
                else
                {
                    Console.WriteLine(year + " is not a Leap year");
                }
            }
            else
                Console.WriteLine("Please Enter four digit number");
        }

    }
}
