using System;

namespace Exercises2
{
    public class FindLarge
    {
        public void largeNumber()
        {
            Console.WriteLine("Enter a series of number sepreted by comma");
            var input = Console.ReadLine();
            string[] numbers = input.Split(',');
            var max = 0;
            
            foreach(string num in numbers)
            {
                var i = Convert.ToInt32(num);
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("The Large number is "+ max);
        }
    }
}
