/*Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercises
{
    class Max_number_in_series_of_Numbers
    {
        public Max_number_in_series_of_Numbers()
        {
            Console.WriteLine("Enter a series of numbers separated by comma.");
            var series = Console.ReadLine();
            series = series.Replace(",","");
            char[] numbers = series.ToCharArray();
            foreach (char i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Array.Sort(numbers);
            foreach (char i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Array.Reverse(numbers);
            foreach (char i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(numbers[0]);
            

        }
        
    }
}
