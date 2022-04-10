using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class FindMissingPositiveHARD
    {
        public static int[] unsortedArray = new int[] {};
        public static void findMissingPositiveHARD()
        {

           HashSet<int> dic = new HashSet<int>(unsortedArray);
            int i = 1;
            while (true)
            {
                if (!dic.Contains(i))
                {
                    Console.WriteLine(i);
                    return;
                }
                i++;
            }

            
        }

        public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int[] bucketedNums = new int[nums.Length];
        int[] bucketCounters = new int[Math.Max(0, nums.Length/256) + 1];
        for (int i = 0; i < nums.Length; i++) {
            int value = nums[i];
            if (value > 0) {
                int bucket = value/256;
                if (bucket < bucketCounters.Length) {
                    int bucketPos = bucketCounters[bucket];
                    if (bucketPos + bucket*256 < bucketedNums.Length) {
                        bucketedNums[bucketPos + bucket*256] = value;
                        bucketCounters[bucket] = bucketPos + 1;    
                    }
                }
            }
        }

        for (int bucket = 0; bucket < bucketCounters.Length; bucket++) {
            HashSet<int> hashSet = new HashSet<int>();
            int addCount = 0;
            int highValue = Math.Min(bucketedNums.Length, bucket*256 + 256);
            for (int i = bucket*256; i < highValue; i++) {
                if (bucketedNums[i] > 0) {
                    if (hashSet.Add(bucketedNums[i])) {
                        addCount++;
                    }
                }
            }
            
            int addIndexes = bucket*256 + bucket*1;
            
            if (addCount < 256) {
                for (int i = 0; i < 256; i++) {
                    if (!hashSet.Contains(i + 1 + bucket*256)) {
                        
                        return i + addIndexes + 1;
                    }
                }
            }
        }
        return nums.Length; 
    }
}
      
        
    }
}
