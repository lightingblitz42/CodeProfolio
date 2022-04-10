using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class LongestSubsringWithoutRepetingChars
    {
        public static string charsinstring = "ddddumbowoomuhahhaha";
        public static void longestSubsringWithoutRepetingChars()
        {

            char[] d = charsinstring.ToCharArray();
            HashSet<char> hashbrowns = new HashSet<char>();
            int count = 0;
            foreach (var item in d)
            {
                if (hashbrowns.Add(item) == true)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
