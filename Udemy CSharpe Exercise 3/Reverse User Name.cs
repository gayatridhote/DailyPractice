/*Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_CSharpe_Exercise_3
{
    class Reverse_User_Name
    {
        public Reverse_User_Name()
        {
            Console.WriteLine("Enter your Name");
            var name = Console.ReadLine();
            char[] username = name.ToCharArray();
            Array.Reverse(username);
            string reversedName = new string(username);
            Console.WriteLine(reversedName);
        }
    }
}
