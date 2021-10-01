using System;

namespace Conditionals
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number:");
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else 
            {
                Console.WriteLine("Invalid");

            }
        }
    }
}
