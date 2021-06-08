using System;

namespace Exercises1
{
    public class Image
    {
        public float width, height;

        public void isLandorProt(float w,float h)
        {
            var result = (w > h) ? "Landscape" : "Protrait";
            Console.WriteLine(result);
        }
    }
}
