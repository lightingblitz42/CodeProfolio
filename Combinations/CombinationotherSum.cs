using System;
using System.Collections.Generic;
namespace calc
{
    public class MyCombinationSum
    {
        public static IList<IList<int>> myAnswer = new List<IList<int>>();
        public static int[] candidates = new int[] { 1, 2, 1};
        public static int target = 4;
        
        public static void combinationSum()
        {
            for (int i = 1; i <= 2 ; i++)
            {
            //    Console.WriteLine(candidates[i]);
            }
            
            myCode(0, 0, 0, new List<int>());
            for (int p = 0; p < myAnswer.Count; p++)
            {
                for (int s = 0; s < myAnswer.Count; s++)
                {
                    if (p == s)
                    {
                        continue;
                    }
                    int hi = myAnswer[p].Count;
                    int ji = myAnswer[s].Count;
                    if (ji != hi)
                    {
                        continue;
                    }
                    else
                    {
                        for (int n = 0; n < myAnswer[p].Count; n++)
                        {
                            if (myAnswer[p][n] != myAnswer[s][n])
                            {
                                break;
                            }
                            myAnswer.Remove(myAnswer[p]);
                        }
                    }
                }
                
            }
            foreach (var item in myAnswer)
            {
                foreach (var obj in item)
                {
                    Console.Write(item);
                }
                Console.WriteLine("");
            }
        }
        public static void myCode(int i, int before, int j, List<int> myList)
        {
            if(i == candidates.Length)
            {

                return;
            }else if(j == candidates.Length){
                
                myCode(i + 1, 0, i + 1, new List<int>());
                return;
            }
            else if (candidates[j] + before > target)
            {
                
                myCode(i + 1, 0, i + 1, new List<int>());
                return;
            }
            else if (candidates[j] + before < target)
            {
                myList.Add(candidates[j]);
                for (int k = 0; k < candidates.Length; k++)
                {

                    if (before + candidates[k] + candidates[j] <= target)
                    {
                        myCode(i, before + candidates[j], k, myList);
                    }
                    
                }
               
                return;
                
            }
            else if (candidates[j] + before == target)
            {
             //   Console.WriteLine(i + " d " + before +  " " + candidates[j]);
                
              
               
                myAnswer.Add(myList);
                
                myCode(i + 1, 0, i + 1, new List<int>());
            }
        }
    }
}
