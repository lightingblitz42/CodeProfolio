using System;
using System.Collections.Generic;
namespace calc
{
    public class ValidParenthasis
    {
        public static string s = "]]]]]";
        public static bool validParenthasis()
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('[', ']');
            dict.Add('{', '}');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {                    
                    if (stack.Count == 0 || dict[stack.Peek()] != s[i])
                    {
                        //Console.WriteLine(false);
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
                //Console.WriteLine(false);
                return false;
            }
            //Console.WriteLine(true);
            return true;
        }
    }
}
