using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class subarraywithonlyamount
    {
        public static int[] nums = new int[] { 1, 2, 1, 2, 3 };
        public static int k = 2;
        public static int temp = 0;
        public static void Subarraywithonlyamount()
        {
            int temp = 0;
            HashSet<int> hashbrown = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int w = i;
                int hashCount = 0;
                while (i < nums.Length && hashCount <= k)
                {
                    if (hashbrown.Add(nums[i]))
                    {
                        hashCount += 1;
                    }
                    //hashCount = hashbrown.Count();
                    if (hashCount == k)
                    {
                        temp++;
                    }
                    i++;
                    if (i == nums.Length && hashCount < k)
                    {
                        Console.WriteLine(temp);
                        return;
                    }
                }
                hashbrown.Clear();
                i = w;
            }
            Console.WriteLine(temp);
            return;
        }
    }

    
}
