using System;
using System.Linq;

namespace Exercises4
{
    public class Duplicate
    {
        public void display1()
        {
            Console.WriteLine("Enter a few num Seperated by hyphen");
            
                var input = Console.ReadLine();
                var numarray = input.Split('-');
                
                if (numarray.Distinct().Count() != numarray.Count())
                {
                    Console.WriteLine("Duplicate");
                }
                
            
            
        }
    }
}
