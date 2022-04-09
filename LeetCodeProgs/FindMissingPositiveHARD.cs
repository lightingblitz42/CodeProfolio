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
      
        
    }
}
