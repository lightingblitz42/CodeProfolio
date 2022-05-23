using System;
using System.Collections.Generic;
namespace calc
{
    public class PermutiansTwo
    {
         
        public static IList<IList<int>> answer = new List<IList<int>>();
        public static void permutionsOne()
        {

            int[] nums = new int[] { 1, 2, 3, 4};
            permutiansTwo(nums);
        }
        public static IList<IList<int>> permutiansTwo(int[] nums)
        {
            Console.WriteLine(nums.Length);
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            if (nums.Length > 2)
            {
                
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(i + "l, ");
                    int[] subNums = subMaker(nums[i], nums);
                    IList<IList<int>> subys = permutiansTwo(subNums);
                    int ddd = subys.Count;
                    foreach (var item in subys)
                    {
                        List<int> dd = new List<int>();
                        dd.Add(nums[i]);

                        foreach (int thing in item)
                        {
                            dd.Add(11);
                        }
                       // answer.Add(dd);
                    }

                }
                
            }
            else if(nums.Length == 2)
            {
                List<int> pairOne = new List<int>();
                pairOne.Add(nums[0]);
                pairOne.Add(nums[1]);
                answer.Add(pairOne);
                List<int> pairTwo = new List<int>();
                pairTwo.Add(nums[1]);
                pairTwo.Add(nums[0]);
                answer.Add(pairTwo);
            }
            else
            {
                List<int> ob = new List<int>();
                ob.Add(nums[0]);
                answer.Add(ob);
            }


            foreach (var item in answer)
            {
                foreach (var thing in item)
                {
                    Console.Write(thing + ", ");
                }
                Console.WriteLine();
            }
            return answer;
        }
        public static int[] subMaker(int dontHave, int[] nums)
        {
            int index = 0;
            //go through array
            int[] subNums = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != dontHave)
                {
                    subNums[index] = nums[i];
                    index++;
                }
                
            }
            return subNums;
           
        }
    }
}
