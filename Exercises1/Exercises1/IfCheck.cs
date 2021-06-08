using System;

namespace Exercises1
{
    public class IfCheck
    {
        public int num;
        public void IfChecking(int num)
        {
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
