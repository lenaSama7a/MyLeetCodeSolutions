// https://leetcode.com/problems/powx-n/description/
// 50. Pow(x, n)
// Implement pow(x, n), which calculates x raised to the power n 
//with O( logn ) (by recusive )

using System;
namespace MyLeetCodeSolutions
{
    class Question7
    {
        public static double MyPow(double x, int n)
        {
            long N = n;
            if (n > 0)
            {
                return quickMul(x, N);
            }
            else
            {
                return 1.0 / quickMul(x, -N);
            }
        }

        public static double quickMul(double x, long n)
        {
            if (n == 0)
            {
                return 1.0;
            }

            double y = quickMul(x, n / 2);
            if (n % 2 == 0)
            {
                return y * y;
            }
            else
            {
                return y * y * x;
            }
        }

        public static void Main()
        {
            Console.WriteLine(MyPow(2, 10));
            Console.WriteLine(MyPow(2, -2));
            Console.WriteLine(MyPow(0.00001, 2147483647));
            Console.WriteLine(MyPow(-1.0000, 2147483647));


        }
    }
}