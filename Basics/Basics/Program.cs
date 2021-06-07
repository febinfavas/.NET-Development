using System;
using Basics.Math;


namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var febin = new Person();
            febin.firstName = "Febin";
            febin.lastName = "Favas";

            febin.Introduce();

            Calculator calc = new Calculator();
            var result = calc.add(5, 6);
            Console.WriteLine(result);

            var array = new int[3];
            array[0]=1;
            array[1]=2;
 

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }
    }
}
