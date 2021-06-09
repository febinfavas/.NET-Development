using System;

namespace Exercises3
{
    public class Sorting
    {
        public void numbersort()
        {
            System.Console.WriteLine("Enter 5 different numbers");
            var numbers = new int[5];
            for (var i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    var newvalue = Convert.ToInt32(Console.ReadLine());
                    var currentvalue = Array.IndexOf(numbers, newvalue);
                    if (currentvalue == -1)
                    {
                        numbers[i] = newvalue;
                        break;
                    }
                    Console.WriteLine("Already Entered!! Retry!!");
                }
                
            }
            Array.Sort(numbers);
            Console.WriteLine("The sorted array is");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
