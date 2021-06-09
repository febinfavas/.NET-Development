using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Febin Favas  ";

            //Trim
            Console.WriteLine("Without Trim: '{0}'", fullname);
            Console.WriteLine("Trim: '{0}'", fullname.Trim());

            //upper lower
            Console.WriteLine("upper: '{0}'", fullname.Trim().ToUpper()) ;
            Console.WriteLine("lower: '{0}'", fullname.Trim().ToLower());

            //substring
            var index = fullname.IndexOf(' ');
            var fname = fullname.Substring(0, index);
            var lname = fullname.Substring(index+1);
            Console.WriteLine(fname);
            Console.WriteLine(lname);

            //split
            var names =fullname.Split(' ');
            Console.WriteLine("First Name: "+names[0]);
            Console.WriteLine("Last Name: "+names[1]);

            //Replace
            var ogname =fullname.Replace("Favas", "Favas Madathil");
            Console.WriteLine(ogname);

            //Null checking
            if(String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            if (String.IsNullOrWhiteSpace("   "))
                Console.WriteLine("Invalid");

            float i = 12345.85f;
            Console.WriteLine(i.ToString("C"));

            // *****String Builder******
            Console.WriteLine("*****String Builder******");
            Console.WriteLine("\n\n\n");

            var builder = new StringBuilder("Hello World Hii");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0,new string('-', 10));
            Console.WriteLine(builder);
        }
    }
}
