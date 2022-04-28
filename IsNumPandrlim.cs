using System;
using System.Collections.Generic;
namespace calc
{
    public class IsNumPandrlim
    {
        static int num = 121;
        public static void isNumPandrlim()
        {
            
            Console.WriteLine(Code(num));
        }

        public static bool Code(int nums)
        {
            if (nums <= 0)
            {
                return false;
            }
            string hi = nums.ToString();
            char[] charray = hi.ToCharArray();
            int p = charray.Length - 1;
            for (int k = 0; k < charray.Length; k++)
            {
                if (charray[p] != charray[k])
                {
                    return false;
                }
                p -= 1;
            }
           
            return true;
        }
    }
}
