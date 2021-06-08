using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicss2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 9;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0} , b:{1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("a:{0} , b:{1}", array1[0], array2[0]));
        }
    }
}
