using System;
using System.Collections.Generic;
namespace calc.Combinations
{
    public class CombinationSumRetry
    {
        public static int target = 10;
        public static int[] candidates = new int[] { 1,2};
        public static IList<IList<int>> answer = new List<IList<int>>();
        public static void combinationSumRetry()
        {
            MergeSort.othermerge(candidates);
            Code(candidates, candidates.Length - 1, new List<int>());
           
            for (int k = 0; k < answer.Count; k++)
            {
                for (int i = 0; i < answer.Count; i++)
                {
                    if (answer[k].Count != answer[i].Count)
                    {
                        continue;
                    }
                    else
                    {
                        bool hi = false;
                        for (int l = 0; l < answer[k].Count; l++)
                        {
                            if (k == i)
                            {
                                break;
                            }
                            if (answer[k][l] != answer[i][l])
                            {

                                hi = false;
                                break;

                            }
                            else if(answer[k][l] == answer[i][l])
                            {
                               
                                hi = true;
                                
                            }
                            
                        }
                        if(hi == true)
                        {
                           
                            answer.RemoveAt(i);
                            
                        }
                    }
                }
               
            }
            foreach (var item in answer)
            {
                foreach (var thing in item)
                {
                    Console.Write(thing + ", ");
                }
                Console.WriteLine("");
            }
           
        }
        public static void Code(int[] numbers, int i, List<int> tempadd)
        {
            int d = 0;
            foreach (var item in tempadd)
            {
                d += item;
            }
            
            if (i < 0)
            {
                
                return;
            }
            else if (numbers[i] + d > target)
            {
                
                Code(numbers, i - 1, new List<int>());
            }
            else if (numbers[i] + d < target)
            {
                
                for (int j = i; j > -1; --j)
                {
                    //Console.WriteLine(j);
                    List<int> temp = new List<int>(tempadd);
                    temp.Add(numbers[j]);
                    Code(numbers, i, temp);
                }

            }
            else if (numbers[i] + d == target)
            {
                Console.WriteLine(d + " " + numbers[i] + " " + i);
                Console.WriteLine("it is done");
                tempadd.Add(numbers[i]);
                answer.Add(tempadd);
                Code(numbers, i - 1, new List<int>());
            }


        }
    }
}
