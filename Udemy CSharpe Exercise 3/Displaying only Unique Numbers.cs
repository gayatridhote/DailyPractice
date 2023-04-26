/* Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. 
Display the unique numbers that the user has entered.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Udemy_CSharpe_Exercise_3
{
    class Displaying_only_Unique_Numbers
    {
        public Displaying_only_Unique_Numbers()
        {
            List<long> numbers = new List<long>();
            while (true)
            {
                Console.WriteLine("Enter a number or \'quit\' to exit");
                var n = Console.ReadLine();
                if(n != "quit")
                {
                    numbers.Add(Convert.ToInt64(n));
                }
                else
                {
                    break;
                }
            }
            numbers.Sort();

            for (int i = 1; i < numbers.Count();i++)
            {
                
                if (numbers[i]==numbers[i-1])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(numbers[i-1]);
                }
                
            }
        }
    }
}
