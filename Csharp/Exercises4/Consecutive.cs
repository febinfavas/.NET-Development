using System;

namespace Exercises4
{
    public class Consecutive
    {
        public void display()
        {
            Console.WriteLine("Enter a few num Seperated by hyphen");
            var input = Console.ReadLine();

            var numarray = input.Split('-');

            int firstval = Convert.ToInt32(numarray[0]);

            bool cons = true;
            for (var i = 0; i < numarray.Length; i++)
            {
                if (Convert.ToInt32(numarray[i]) - i != firstval)
                {
                    cons = false;
                    break;
                }
            }
            if (cons)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }   
            
        }
    }
}
