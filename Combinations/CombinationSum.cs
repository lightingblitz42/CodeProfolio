using System;
using System.Collections.Generic;
namespace calc
{
    public class CombinationSum
    {
        public static IList<IList<int>> myAnswer = new List<IList<int>>();
        public static int[] candidates = new int[] { 1, 7, 3, 4, 2, 4, 6 ,1 ,5, 8 ,5 ,3 , 2 , 1 };
        public static int target = 10;
        public static void combinationSum()
        {
            for (int i = 1; i <= 2 ; i++)
            {
                Console.WriteLine(candidates[i]);
            }
            myCode(0, 0, 0);
        }
        public static void myCode(int i, int before, int j)
        {
            if(i == candidates.Length)
            {
                foreach (var item in myAnswer)
                {
                    foreach (var number in item)
                    {
                        Console.Write(number + ", ");
                    }
                    Console.WriteLine("");
                }
                return;
            }else if(j == candidates.Length){
                
                myCode(i + 1, 0, i + 1); 
            }
            else if (candidates[j] + before > target)
            {
                
                myCode(i + 1, 0, i + 1);
            }
            else if (candidates[j] + before < target)
            {
                
                myCode(i, before + candidates[j], j + 1);
            }
            else if (candidates[j] + before == target)
            {
                Console.WriteLine(i + " d " + before + candidates[j]);
                List<int> babyAnswer = new List<int>();
                for (int poop = i; poop <= j; poop++)
                {
                    babyAnswer.Add(candidates[poop]);
                    Console.WriteLine(candidates[poop] + " dddd" + poop + " " + i + " " + j);
                }
                myAnswer.Add(babyAnswer);
                
                myCode(i + 1, 0, i + 1);
            }
        }
    }
}
