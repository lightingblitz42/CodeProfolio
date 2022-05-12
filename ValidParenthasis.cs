using System;
using System.Collections.Generic;
namespace calc
{
    public class ValidParenthasis
    {
        //public static string s = ")()))(((()";
        
        public static bool validParenthasis(List<char> myCharLis)
        {
           
            if (myCharLis.Count == 0 || myCharLis.Count % 2 == 1)
            {
                Console.WriteLine("Nothing in here");
            }
            List<int> right = new List<int>();
            List<int> left = new List<int>();
            for (int j = 0; j < myCharLis.Count; j++)
            {
                if (myCharLis[j] == ')')
                {
                   left.Add(j);
                }
                else
                {
                    right.Add(j);
                }
            }
            if (right.Count != left.Count)
            {
                Console.WriteLine(false);
                return false;
            }
            for (int i = 0; i < right.Count || i < left.Count; i++)
            {
                if (right[i] > left[i])
                {
                    Console.WriteLine("False");
                    return false;
                }
            }


            return true;
           
        }
    }
}
