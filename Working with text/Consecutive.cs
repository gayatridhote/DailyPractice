

/*Write a program and ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive. For example, 
if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Working_with_text
{
    class Consecutive
    {
        public Consecutive()
        {
            Console.WriteLine("enter a few numbers separated by a hyphen");
            var str = Console.ReadLine();
            var numbers = new List<int>();
            foreach (var number in str.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            var isConsecutive = true; 
            
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }
    }
}
