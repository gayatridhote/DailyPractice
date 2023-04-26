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
