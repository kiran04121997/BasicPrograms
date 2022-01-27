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
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int number3 = Convert.ToInt32(Console.ReadLine());
          
            headTailcs.largest_num(10,20,30);



            Console.ReadLine();
           
        }
    }
}
