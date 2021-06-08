using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i= 0;i<10;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n");

            var number = new int[5] { 10, 9, 8, 7, 6 };
            foreach(var num in number)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n\n");

            int j = 1;
            while(j<10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\n\n");

            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);


            Console.WriteLine("\n\n");

            var random = new Random();
            for(var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1,1000));

            var buffer = new char[10];
            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
