using System;
using System.Collections.Generic;
namespace calc
{
    public class SortandFind
    {
        public static IList<int> TargetIndices(int[] nums, int target)
        {
            IList<int> bob = new List<int>();

            bool hi = false;
            
            Sort(nums);

            
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == target)
                {
                    bob.Add(j);
                }


            }
            foreach (int item in nums)
            {
                Console.Write(item + ", ");
            }
            return bob;
        }
        public static void Sort(int[] numarr)
        {
            if (numarr.Length < 2)
            {
                return;
            }
            int middle =  numarr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[numarr.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = numarr[i];
            }
            for (int j = middle; j < numarr.Length; j++)
            {
                right[j] = numarr[j];
            }
            Sort(left);
            Sort(right);

            sortOther(left, right, numarr);

        }
        public static void sortOther(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < right.Length && j < left.Length)
            {
                if (left[j] >= right[i])
                {
                    arr[k] = right[i];
                    i += 1;

                }
                else
                {
                    arr[k] = left[j];
                    j += 1;

                }
                k += 1;
            }
            if (i < right.Length)
            {
                arr[k] = right[i];
                i += 1;
                k += 1;
            }
            if (j < left.Length)
            {
                arr[k] = left[j];
                j += 1;
                k += 1;
            }
        }


            
            
    }
}

