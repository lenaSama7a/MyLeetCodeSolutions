//https://leetcode.com/problems/two-sum/description/
//Two Sum

using System;
namespace MyLeetCodeSolutions
{
    class Question9
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int temp;
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp = nums[i] + nums[j];
                    if (temp == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        break;
                    }
                }
            }
            return arr;
        }

        public static void Main()
        {
            int[] nums = { 2, 7, 11, 15};
            TwoSum(nums, 9).ToList().ForEach(i => Console.Write(i.ToString() + " "));

            Console.WriteLine();

            int[] nums1 = {3,2,4 };
            TwoSum(nums1, 6).ToList().ForEach(i => Console.Write(i.ToString() + " "));

            Console.WriteLine();

            int[] nums2 = {3,3 };
            TwoSum(nums2, 6).ToList().ForEach(i => Console.Write(i.ToString() + " "));

        }
    }
}