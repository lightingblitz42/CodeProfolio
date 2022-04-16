using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs.Permutations
{
    public class PermutionsDoingItRight
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> pairs = new List<IList<int>>();
            if (nums.Length > 2)
            {
                //Loop through all the values
                for (int i = 0; i < nums.Length; i++)
                {
                    //Make and populate the subNums
                    int[] subNums = makeSubNums(nums[i], nums);
                    IList<IList<int>> subPermutes = Permute(subNums);
                    foreach (IList<int> subPermute in subPermutes)
                    {
                        IList<int> pair1 = new List<int>();
                        pair1.Add(nums[i]);
                        foreach (int aValue in subPermute)
                        {
                            Console.WriteLine(aValue);
                            pair1.Add(aValue);
                        }
                        pairs.Add(pair1);
                    }
                }
            }
            else if (nums.Length == 2)
            {
                IList<int> pair1 = new List<int>();
                pair1.Add(nums[0]);
                pair1.Add(nums[1]);
                pairs.Add(pair1);
                IList<int> pair2 = new List<int>();
                pair2.Add(nums[1]);
                pair2.Add(nums[0]);
                pairs.Add(pair2);

            }
            else
            {
                IList<int> pair1 = new List<int>();
                pair1.Add(nums[0]);
                pairs.Add(pair1);
            }
            return pairs;

        }

        public int[] makeSubNums(int dontInclude, int[] nums)
        {
            int[] subNums = new int[nums.Length - 1];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != dontInclude)
                {
                    subNums[index] = nums[i];
                    index += 1;
                }
            }
            return subNums;
        }
    }
}