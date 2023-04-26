using System;
using System.Collections.Generic;
using System.Text;

namespace Working_with_text
{
    class Duplicate
    {
        public Duplicate()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var str = Console.ReadLine();
            if (!(String.IsNullOrEmpty(str)))
            {
                var numbers = new List<int>();
                foreach (var number in str.Split("-")
                {
                    numbers.Add(Convert.ToInt32(number));
                }
                var unique = new 
            }
           
        }
    }
}
