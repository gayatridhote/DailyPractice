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
