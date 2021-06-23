using System;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ifcheck = new IfCheck();
            var conditional = new Conditional();
            var image = new Image();
            var speedCam = new SpeedCamera();


            Console.WriteLine(@"
                        Menu
                1.Valid or Invalid
                2.Maxium of 2 Numbers
                3.Protrait or LandScape
                4.SpeedCamera");
            var select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("\tValid or Invalid");
                    ifcheck.IfChecking();
                    break;
                case 2:
                    Console.WriteLine("\tMaxium of 2 Numbers");
                    conditional.ismaximum();
                    break;
                case 3:
                    Console.WriteLine("\tProtrait or LandScape");
                    image.isLandorProt();
                    break;
                case 4:
                    Console.WriteLine("\tSpeedCamera");
                    speedCam.speedChecking();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            
            
        }
    }
}
