using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 6, 5, 8, 9, 2, 5, 1 };
            var another = new int[5];

            //Length
            Console.WriteLine("Length " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            Array.Copy(numbers, another, 5);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //*******List******
            Console.WriteLine("**********List**********");

            var items = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("Given list");
            foreach (var n in items)
                Console.WriteLine(n);

            //Add()
            items.Add(1);
            Console.WriteLine("After Add()");
            foreach (var n in items)
                Console.WriteLine(n);

            //AddRange()
            items.AddRange(new int[3] { 6, 7, 8});
            Console.WriteLine("After AddRange()");
            foreach (var n in items)
                Console.WriteLine(n);

            //IndexOf()
            Console.WriteLine("Index of 1 :" + items.IndexOf(1));

            //LastIndexOf()
            Console.WriteLine("Last Index of 1 :" + items.LastIndexOf(1));

            //Count()
            Console.WriteLine("Count :" + items.Count());

            //Remove()
            items.Remove(1);
            Console.WriteLine("After Remove()");
            foreach (var n in items)
                Console.WriteLine(n);

            //RemoveAt()
            items.RemoveAt(4);
            Console.WriteLine("After RemoveAt()");
            foreach (var n in items)
                Console.WriteLine(n);

            //Clear()
            items.Clear();
            Console.WriteLine("After Clear()");
            foreach (var n in items)
                Console.WriteLine(n);
        }
    }
}
