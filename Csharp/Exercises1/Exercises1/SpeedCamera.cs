using System;

namespace Exercises1
{
    public class SpeedCamera
    {
        public void speedChecking()
        {
            Console.WriteLine("Enter The Speed Limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Speed of cart");
            var speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var extraspeed = speed - speedLimit;
                var demereit = extraspeed / 5;
                if (demereit <= 12)
                {
                    Console.WriteLine("Demerit point = "+ demereit);
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
