/*Write a program and continuously ask the user to enter a number or "ok" to exit. 
Calculate the sum of all the previously entered numbers and display it on the console.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercises
{
    class Sum_of_numbers
    {
        public Sum_of_numbers()
        {
            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or enter Ok to exit");
                var a = Console.ReadLine();

                if (a == "Ok")
                {
                    break;
                }
                else
                {
                    int b = Convert.ToInt32(a) ;
                    count += b;
                }
            }
            Console.WriteLine(count);

        }
    }
}
