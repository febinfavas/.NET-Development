using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning");
            }
            else if (hour>=12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }

            bool isExperinced = true;
            float years = (isExperinced) ? 1.0f : 0.0f;
            Console.WriteLine("Number of years of experince " + years);

            var days = Days.monday;

            switch(days)
            {
                case Days.monday:
                    Console.WriteLine("1");
                    break;
                case Days.tuesday:
                    Console.WriteLine("2");
                    break;
                case Days.wednesday:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
