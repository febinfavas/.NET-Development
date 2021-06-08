using System;

namespace Exercises1
{
    public class Conditional
    {
        public void ismaximum()
        {
            Console.WriteLine("Enter Two numbers");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Max Number is "+max);
        }
    }
}
