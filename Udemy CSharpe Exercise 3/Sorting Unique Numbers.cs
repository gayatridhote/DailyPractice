/*Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercise_3
{
    class Sorting_Unique_Numbers
    {
        public Sorting_Unique_Numbers()
        {
            List<int> numbers = new List<int> { };
            int n;
            do
            {
                Console.WriteLine("Enter a number");
                n = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(n))
                {
                    Console.WriteLine("Number already exist. Try another number");
                }
                else
                {
                    numbers.Add(n);
                }


            } while (numbers.Count != 5);

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            

        }
    }
}
