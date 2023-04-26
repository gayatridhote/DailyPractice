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
