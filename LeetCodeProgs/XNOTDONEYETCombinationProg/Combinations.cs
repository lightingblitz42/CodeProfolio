using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class Combinations
    {
        public static IList<IList<int>> myList = new List<IList<int>>();
        static int n = 4;
        static int k = 3;


        public static void hi()
        {



            Code(n, k, 1, new List<int>());
            

        }
        
       public static void Code(int n, int k, int i, List<int> l)
        {
            if (l.Count == k)
            {
                myList.Add(new List<int>(l));
            }
            else
            {
                for (int j = i; j <= n; j++)
                {
                    l.Add(j);
                    Code(n, k, j + 1, l);
                    l.RemoveAt(l.Count - 1);


                }
            }
        }
    }
}
