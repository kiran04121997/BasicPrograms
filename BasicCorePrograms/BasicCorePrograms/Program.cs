using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core programs");
            HeadTailcs headTailcs = new HeadTailcs();
            HeadTailcs headTailcs1 = new HeadTailcs();

            headTailcs1.Check_leap_year();
            Console.ReadLine();
           
        }
    }
}
