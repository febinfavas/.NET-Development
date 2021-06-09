using System;
using System.Collections.Generic;

namespace Exercises3
{
    public class Unique
    {
        public void display()
        {
            Console.WriteLine("Enter Numbers continously or Enter \'quit\' to exit");
            var numbers = new List<int>();
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));

            }

            var uniq = new List<int>();
            foreach (var value in numbers)
            {
                if (!uniq.Contains(value))
                {
                    uniq.Add(value);
                }
            }
            Console.WriteLine("Unique Numbers in list are:");
            foreach (var i in uniq)
                Console.WriteLine(i);
        }
    }
}
