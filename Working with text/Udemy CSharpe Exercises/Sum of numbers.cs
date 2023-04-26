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
