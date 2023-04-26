/*Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercises
{
    class Factorial_of_Number
    {
        public Factorial_of_Number()
        {
            var fact=1;
            Console.WriteLine("Enter a number");
            var a = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i > 0; i --)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
