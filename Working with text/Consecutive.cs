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
