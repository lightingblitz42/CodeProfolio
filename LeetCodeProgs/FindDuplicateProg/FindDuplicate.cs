using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class FindDuplicate
    {
        public static int[] nums = new int[] { 1, 2, 4, 8, 3, 7, 4, 9 };
        public static void findDuplicate()
        {

            HashSet<int> hashBrown = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(hashBrown.Add(nums[i]) == false)
                {
                    Console.WriteLine(nums[i]);
                    return;
                    
                }
               
                
            }

            
        }
    }
}
