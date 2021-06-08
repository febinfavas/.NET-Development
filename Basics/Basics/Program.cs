using System;
using Basics.Math;


namespace Basics
{
    public enum ShippingMethod
    {
        RegularMail=1,
        RegisteredMail=2,
        Express=3
    }
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

            var arrayBool = new bool[3];
            arrayBool[0] = true;

            Console.WriteLine(arrayBool[0]);
            Console.WriteLine(arrayBool[1]);
            Console.WriteLine(arrayBool[2]);

            var names = new string[3] {"febin","favas","madathil"};

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            var fName = "Muhsina";
            var lName = "Hameed";

            var fullName = fName + " " + lName;

            var fullName1 = string.Format("{0} {1}", fName, lName);

            Console.WriteLine("My full Name is " +fullName+" and "+fullName1);

            var numbers = new int[4] { 1, 2, 3, 4 };
            var list = string.Join(",", numbers);

            Console.WriteLine(list);

            var path = "c:\\project\\folder\\febin";
            var path1 = @"c:\project\folder\febin";
            var josh = @"Hi febin
                        Look into the following path
                        c:\project\folder\febin
                        c:\project\folder\favas";
            Console.WriteLine(path);
            Console.WriteLine(path1);
            Console.WriteLine(josh);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
        }
    }
}
