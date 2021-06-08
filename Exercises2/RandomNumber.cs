using System;

namespace Exercises2
{
    public class RandomNumber
    {
        public void pickRand()
        {
            var random = new Random();
            var selectedRandumNum = random.Next(1, 10);
            
            Console.WriteLine("Guess the random selected. You can guess 4 times");
            var gusedNumbers = new int[4];
            for (var i = 0; i < gusedNumbers.Length; i++)
            {
                gusedNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            var flag = false;
            for (var i = 0; i < gusedNumbers.Length; i++)
            {
                if(gusedNumbers[i] == selectedRandumNum)
                {
                    flag = true; ;
                }
            }

            Console.WriteLine("Selected Randum Number is "+selectedRandumNum);
            if (flag)
            {
                Console.WriteLine("You Won!!");
            }
            else
            {
                Console.WriteLine("You Lost!!");
            }

        }
    }
}
