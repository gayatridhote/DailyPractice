/*When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

      If no one likes your post, it doesn't display anything.
      If only one person likes your post, it displays: [Friend's Name] likes your post.
      If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
      If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercise_3
{
    class Facebook_Likes
    {
        public Facebook_Likes()
        {
            string name;
            int totalnames=0;
            List<string> names = new List<string> { };
            while (true) 
            {
                Console.WriteLine("Enter different name");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                {
                    break;
                }
                names.Add(name);
                totalnames++;
                
            }


            switch (totalnames)
            {
                case 1 :
                    Console.WriteLine(names[0] + " likes your post.");
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} like your post." , names[0],names[1]);
                    break;

                default:
                    Console.WriteLine("{0} , {1} and {2} others like your post.", names[0],names[1],totalnames-2);
                    break;
            }

        }
    }
}
