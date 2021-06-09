using System;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebook = new Facebok();
            var reverseName = new ReverseName();
            var sorting = new Sorting();
            var unique = new Unique();
            var smallest = new Smallest();

            Console.WriteLine(@"
                    Menu
            1.Facebok
            2.ReverseName
            3.Sorting
            4.Unique
            5.Smallest");
            
            var select = Convert.ToInt32(Console.ReadLine());
            
            switch (select)
            {
                case 1:
                    facebook.likes();
                    break;
                case 2:
                    reverseName.givename();
                    break;
                case 3:
                    sorting.numbersort();
                    break;
                case 4:
                    unique.display();
                    break;
                case 5:
                    smallest.small();
                    break;
                default:
                    break;
            }
        }
    }
}
