using System;
using System.Collections.Generic;
namespace calc.ArrayWalking
{
    public class ValidPalindromeII
    {
        static string[] words = new string[3]
        {
            "ana",
            "pppop",
            "wow",
           
        };
        public static void validPalindromeII()
        {
            foreach (var item in words)
            {
                List<char> letters = new List<char>(item.ToCharArray());
                CheckOgram(letters, -1);
            }
            
        }
        public static bool CheckOgram(List<char> letters, int l)
        {
            int j = 0;
            int r = 0;
            
            int k = letters.Count - 1;

            if (letters.Count <= 1)
            {
                return false;
            }
            if(l >= letters.Count)
            {
                return false;
            }
            while (k - r > j)
            {
                //Console.WriteLine(r + " " + j + " " + k);
                if (letters[j] != letters[k - r] && j != l)
                {
                   if(j != l)
                    {
                        //Console.WriteLine(letters[j] + " " + letters[k - r]);
                        // Console.Write("aw this ones false");
                        Console.WriteLine("wrong" + l);
                        l += 1;
                        return CheckOgram(letters, l);
                    }

                   
                }
                if (j == l)
                {
                    j++;
                }
                else
                {
                    j++;
                    r++;
                }
                    
               

            }
            
            Console.WriteLine("this ones right");
            return true;

        }
    }
}
