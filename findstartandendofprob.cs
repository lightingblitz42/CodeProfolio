using System;
namespace calc
{
    public class findstartandendofprob
    {
        public static void Findstartandendofprob()
        {
            Console.WriteLine(SearchRange(new int[]{1,2,3, 4, 6, 6 }, 6));
             int[] SearchRange(int[] nums, int target)
            {
               
                if (nums.Length == 1 && nums[0] == target)
                {
                    return new int[] { 0, 0 };
                }
                else if (nums.Length == 1 && nums[0] != target)
                {
                    return new int[] { -1, -1 };
                }

                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] == target)
                    {
                        return vode(i, nums, target);
                    }
                }
                return new int[] { -1, -1 };

            }

             int[] vode(int num, int[] nums, int target)
            {
                for (int k = num; k < nums.Length; k++)
                {
                    if (k == nums.Length - 1 || nums[k + 1] != target)
                    {
                        return new int[] { num, k };
                    }
                }
                return new int[] { num, num };

            }
        }
    }
}
