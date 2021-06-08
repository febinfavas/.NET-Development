using System;

namespace Exercises1
{
    public class Image
    {
        public void isLandorProt()
        {
            Console.WriteLine("Enter Width and Height");
            var width = Convert.ToInt32(Console.ReadLine());
            var height = Convert.ToInt32(Console.ReadLine());
            var result = (width > height) ? "Protrait" : "Landscape";
            Console.WriteLine(result);
        }
    }
}
