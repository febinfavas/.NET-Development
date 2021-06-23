using System;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = new Count();
            var continuess = new Continues();
            var factorial = new Factorial();
            var randomnumber = new RandomNumber();
            var findlarge = new FindLarge();
            
            
            Console.WriteLine(@"
                            Menu
                    1.Count of Numbers
                    2.Sum of Numbers
                    3.Factorial of Numbers
                    4.Random Number Game
                    5.Find large Number from a list");
            var select= Convert.ToInt32(Console.ReadLine());
             
           
            switch (select)
            {
                case 1:
                    Console.WriteLine("Count of Numbers");
                    count.countofnum();
                    break;
                case 2:
                    Console.WriteLine("Sum of Numbers");
                    continuess.continuesnum();
                    break;
                case 3:
                    Console.WriteLine("Factorial of Numbers");
                    factorial.factofnum();
                    break;
                case 4:
                    Console.WriteLine("Random Number Game");
                    randomnumber.pickRand();
                    break;
                case 5:
                    Console.WriteLine("Find large Number from a list");
                    findlarge.largeNumber();
                    break;
                default:
                    Console.WriteLine("Enter a number from 1 to 5");
                    break;
            }
        }
    }
}
