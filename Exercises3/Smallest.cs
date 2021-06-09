using System;
using System.Collections.Generic;

namespace Exercises3
{
    public class Smallest
    {
        public void small()
        {
            label:
                Console.WriteLine("Enter a list of number more than 5 numbers seperated by comma");
                var number = new List<int>();
                var input = Console.ReadLine();
                var num = input.Split(',');

                for(var i = 0; i < num.Length; i++)
                {
                    var conv = Convert.ToInt32(num[i]);
                    number.Add(conv);
                }
                if (number.Count < 5)
                {
                    Console.WriteLine("Invalid list!! please retry");
                    goto label;
                }
                else
                {
                    number.Sort();
                    Console.WriteLine("Smallest number in th list are {0},{1},{2}",number[0], number[1], number[2]);
                }
        }
    }
}
