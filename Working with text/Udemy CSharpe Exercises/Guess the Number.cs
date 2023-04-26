using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercises
{
    class Guess_the_Number
    {
        public Guess_the_Number()
        {
            var random = new Random();
            var a = random.Next(1, 10);
            Console.WriteLine("Guess the secret number");
            for (int i = 0; i < 4; i++)
            {
                
                var n = Convert.ToInt32(Console.ReadLine());
                if (n == a)
                {
                    Console.WriteLine("You Won");
                    Console.WriteLine("The secret number is " + a);
                    break;
                }
                else
                {
                    if (i < 3)
                    {
                        Console.WriteLine("Try again ");
                    }
                    else
                    {
                        Console.WriteLine("You Lost\nThe secret number is " + a);
                    }
                }

                
            }

           



        }
    }
}
