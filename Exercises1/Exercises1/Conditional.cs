using System;

namespace Exercises1
{
    public class Conditional
    {
        public int num1, num2;

        public void ismaximum(int num1,int num2)
        {
            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Max Number is "+max);
        }
    }
}
