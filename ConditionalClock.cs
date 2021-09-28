using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 2;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon.");
            }
            else
            {
                Console.WriteLine("Its evening.");
            }
            
        }
    }
}
