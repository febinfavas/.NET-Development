using System;

namespace Exercises2
{
    public class Continues
    {
        public void continuesnum()
        {
            var numbers = new int[100];
            Console.WriteLine("Enter Numbers continously or Enter \'ok\' to exit");
            for (var i = 0; i < numbers.Length; i++)
            {
                var str = Console.ReadLine();
                if (str == "ok")
                {
                    Console.WriteLine("Exiting as entered \"ok\" " );
                    break;
                }
                else
                {
                    numbers[i] = Convert.ToInt32(str);
                }
            }
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("The sum of number Entered is "+ sum);
        }
    }
}
