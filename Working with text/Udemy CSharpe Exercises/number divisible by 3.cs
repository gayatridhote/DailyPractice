/*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercises
{
    class Number_divisible_by_3
    {
        public  Number_divisible_by_3()
        {
            int count = 0;
            for ( int i=1;i<=100;i++)
            {

                
                var a = i % 3;
                
                if (a==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
