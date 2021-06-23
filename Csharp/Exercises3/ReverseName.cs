using System;

namespace Exercises3
{
    public class ReverseName
    {
        public void givename()
        {
            System.Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            var array = name.ToCharArray();
            
            /*
            for (var i=0;i<name.Length;i++)
            {
                array[i] = name[i];
            }
            */

            Array.Reverse(array);
            var reversedname = new string(array);
            Console.WriteLine(reversedname);
        }
    }
}
