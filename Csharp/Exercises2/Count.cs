using System;

namespace Exercises2
{
    public class Count
    {
        public void countofnum()
        {
            var count = 0;
            for(var i = 1; i < 100; i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of nuber divisible by 3 between 1 and 100 is "+count);
        }
    }
}
