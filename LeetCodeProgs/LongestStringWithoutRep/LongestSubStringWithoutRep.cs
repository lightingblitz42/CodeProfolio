using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class LongestSubStringWithoutRep
    {
      public static string s = "qwwkew";
        public static void longestSubStringWithoutRep()
        {
            int temphighest = 0;
            char[] d = s.ToCharArray();
            
            for (int i = 0; i < d.Length; i++)
            {
                HashSet<char> dd = new HashSet<char>();
                for (int j = i; j < d.Length; j++)
                {
                    if (dd.Add(d[j]) == false)
                    {
                        break;
                    }
                    else
                    {
                        
                        if (temphighest < dd.Count)
                        {
                            temphighest = dd.Count;
                        }
                        
                    }
                   
                }
            }
        }
    }
}
