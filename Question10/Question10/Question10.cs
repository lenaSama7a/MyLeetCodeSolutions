//https://leetcode.com/problems/median-of-two-sorted-arrays/description/
//Median of Two Sorted Arrays
using System;
namespace MyLeetCodeSolutions
{
    class Question10
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double d = 0.0f;
            long[] nums3 = new long[nums1.Length + nums2.Length];
            if (nums1.Length >= nums2.Length)
            {
                int i;
                for (i = 0; i < nums1.Length; i++)
                {
                    nums3[i] = nums1[i];
                }
                for (int j = 0; j < nums2.Length; j++)
                {
                    nums3[i] = nums2[j];
                    i++;
                }
            }
            else if (nums2.Length >= nums1.Length)
            {
                int i;
                for (i = 0; i < nums2.Length; i++)
                {
                    nums3[i] = nums2[i];
                }
                for (int j = 0; j < nums1.Length; j++)
                {
                    nums3[i] = nums1[j];
                    i++;
                }
            }
            Array.Sort(nums3);
            if (nums3.Length % 2 == 0)
            {
                int mid = nums3.Length / 2;
                int mid1 = (nums3.Length / 2) - 1;
                d = (nums3[mid] + nums3[mid1]) / 2.0;
            }
            else if (nums3.Length % 2 != 0)
            {
                int mid = (nums3.Length - 1) / 2;
                d = nums3[mid];
            }
            return d;
        }
        public static void Main()
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2)); //2

            int[] nums3 = { 1, 2 };
            int[] nums4 = { 3, 4 };
            Console.WriteLine(FindMedianSortedArrays(nums3, nums4)); //2.5

            int[] nums5 = { 1 };
            int[] nums6 = { 2 };
            Console.WriteLine(FindMedianSortedArrays(nums5, nums6)); //1.5
        }
    }
}