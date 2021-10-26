using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int a = Convert.ToInt32(Console.ReadLine()); 
        double r = Convert.ToDouble(Console.ReadLine());
        string p = Convert.ToString(Console.ReadLine());
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(a + i);
        // Print the sum of the double variables on a new line.
        var z = string.Format("{0:0.0}", (r + d));
        Console.WriteLine(z);
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + p);

    }
}
