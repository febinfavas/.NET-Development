using System;

namespace Exercises2
{
    public class Factorial
    {
        public void factofnum()
        {
            Console.WriteLine("Enter number");
            var num = Convert.ToInt32(Console.ReadLine());
            var fact = 1;
            for(var i = num; num >= 1; num--)
            {
                fact = fact * num;
            }
            Console.WriteLine("Factorial is "+ fact);
        }
    }
}
