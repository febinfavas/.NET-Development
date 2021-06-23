using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    public class ValidTimeRange
    {
        public void Run()
        {
            Console.WriteLine("Type in a time value between 00:00 and 23:59");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                var hour = Convert.ToInt32(input?.Split(':')[0]);
                var minute = Convert.ToInt32(input?.Split(':')[1]);

                if (IsValidHour(hour) && IsValidMinute(minute))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
        }

        private bool IsValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }

        private bool IsValidMinute(int minute)
        {
            return minute >= 0 && minute <= 59;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var consecutive = new Consecutive();
            var duplicate = new Duplicate();
            var timeRange = new ValidTimeRange();
            //consecutive.display();
            //duplicate.display1();
            timeRange.Run();
        }
    }
}
