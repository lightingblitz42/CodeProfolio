using System;
using System.Collections.Generic;

namespace calc.LeetCodeProgs
{
    public class LowestValue
    {


        public static int FirstMissingPositive(int[] nums)
        {
            int length = nums.Length;
            int i = 0;
            while (i < nums.Length)
            {
                int value = nums[i];
                if (value - 1 == i)
                {
                    i++;
                }else
                {
                    nums[i] = -1;
                    if (value > 0 && value < length + 1 && nums[value - 1] != value)
                    {
                        nums[i] = nums[value - 1];
                        nums[value - 1] = value;
                    }
                    else
                    {
                        i++;
                    }
                }
                
            }

            for (int j = 0; j < length; j++)
            {
                if (nums[j] == -1)
                {
                    return j + 1;
                }
            }
            return nums.Length + 1;
        }
    }
}
