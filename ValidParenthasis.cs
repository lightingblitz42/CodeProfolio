using System;
using System.Collections.Generic;
namespace calc
{
    public class ValidParenthasis
    {
        public static Stack<int> stack = new Stack<int>();
        public static string s = "()";
        
        public static bool validParenthasis()
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(i);
                }else{
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(false);
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }

                }
            }


            if (stack.Count != 0)
            {
                Console.WriteLine(false);
                return false;
            }
            Console.WriteLine(true);
            return true;
           
        }
    }
}
