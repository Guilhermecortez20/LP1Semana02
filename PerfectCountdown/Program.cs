using System;
using System.Xml.XPath;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("start number: ");
            string str1=Console.ReadLine();
            int start=int.Parse(str1);

            Console.WriteLine("step number: ");
            string str2=Console.ReadLine();
            int step=int.Parse(str2);

            if (start < 1)
            {
                Console.WriteLine("out-of-range start or step. Try again.");

            }
            else if(step<1)
            {
                Console.WriteLine("out-of-range start or step. Try again.");
            }
            else if(step>=start)
            {
                Console.WriteLine(" Start must be higher than step. Try again");
            }
            else if (start % step > 0)
            {
                Console.WriteLine(".Start not divisible by step. Try again.");
            }

            
        } 
    }
}
