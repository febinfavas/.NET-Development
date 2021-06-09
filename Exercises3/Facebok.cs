using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises3
{
    public class Facebok
    {
        public void likes()
        {
            var friends = new List<string>();
            Console.WriteLine("Enter your Freinds name 1 by one. #simply  press enter to exit");
            var input = Console.ReadLine();
            friends.Add(input);
            while (input != "")
            {
                input = Console.ReadLine();
                friends.Add(input);
            }
            var count = friends.Count()-1;

            if (count == 0)
            {
                Console.WriteLine("No one Likes your post");
            }
            else if (count == 1)
            {
                Console.WriteLine("{0} Likes your post",friends[0]);
            }
            else if (count == 2)
            {
                Console.WriteLine("{0} and {1} Likes your post", friends[0],friends[1]);
            }
            else if (count > 2) 
            {
                Console.WriteLine("{0} , {1} and {2} others Likes your post", friends[0], friends[1],count-2);
            }


        }
    }
}
