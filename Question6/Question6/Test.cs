using System;
using System.Collections.Generic;


namespace MyLeetCodeSolutions
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Question6.IsValid("()"));
            Console.WriteLine(Question6.IsValid("()[]{}"));
            Console.WriteLine(Question6.IsValid("(]"));
            Console.WriteLine(Question6.IsValid("{[]}}"));

        }
    }
}
