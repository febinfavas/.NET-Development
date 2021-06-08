using System;

namespace Exercises1
{
    public class SpeedCamera
    {
        public int speedLimit,speed;

        public void speedChecking(int speed)
        {
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
    class Program
    {
        static void Main(string[] args)
        {
            var ifcheck = new IfCheck();
            Console.WriteLine("Enter a number");
            ifcheck.num = Convert.ToInt32(Console.ReadLine());
            ifcheck.IfChecking(ifcheck.num);

            var conditional = new Conditional();
            Console.WriteLine("Enter Two numbers");
            conditional.num1 = Convert.ToInt32(Console.ReadLine());
            conditional.num2 = Convert.ToInt32(Console.ReadLine());
            conditional.ismaximum(conditional.num1, conditional.num2);

            var image = new Image();
            Console.WriteLine("Enter Width and Height");
            image.width= Convert.ToInt32(Console.ReadLine());
            image.height= Convert.ToInt32(Console.ReadLine());
            image.isLandorProt(image.width, image.height);

            var speedCam = new SpeedCamera();
            Console.WriteLine("Enter The Speed Limit");
            speedCam.speedLimit= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Speed of cart");
            speedCam.speed = Convert.ToInt32(Console.ReadLine());
            speedCam.speedChecking(speedCam.speed);
        }
    }
}
