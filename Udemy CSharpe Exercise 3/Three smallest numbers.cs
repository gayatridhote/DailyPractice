/*Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercise_3
{
    class Three_smallest_numbers
    {
        public Three_smallest_numbers()
        {
            
            Console.WriteLine("supply a list of comma separated numbers");
            var str = Console.ReadLine();
            str = str.Replace(",", "");
            char[] numbers = str.ToCharArray();
            if(numbers.Length <5)
            {
                Console.WriteLine("Invalid List . Try again.");
            }
            else
            {
                Array.Sort(numbers);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                ;
            }

        }
    }
}
