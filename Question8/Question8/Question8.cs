//https://leetcode.com/problems/roman-to-integer/description/
//Roman to Integer
using System;
using System.Collections.Generic;
namespace MyLeetCodeSolutions
{
    class Question8
    {
        public static int RomanToInt(String s)
        {
            Dictionary<char, int> map = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int r = 0;
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (i < s.Length - 1)
                {
                    char next_c = s[i + 1];
                    if (map[c] < map[next_c])
                    {
                        r = r + map[next_c] - map[c]; 
                        i++;
                    }
                    else
                    {
                        r += map[c];  
                    }
                }
                else
                {
                    sum += map[c]; 
                }
            }
            sum += r; 
            return sum;

        }
        public static void Main()
        {
            Console.WriteLine( RomanToInt("III")); //3
            Console.WriteLine(RomanToInt("LVIII"));//58
            Console.WriteLine(RomanToInt("MCMXCIV"));//1994
        }
    }
}