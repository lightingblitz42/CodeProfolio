using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class AllValidParenthisis
    {
        public static string s = ")()())";
        public static void longestValueParenthisis()
        {
            char[] charsOfS = s.ToCharArray();
            int result = 0;


            List<int> holder1 = new List<int>();
            List<int> holder2 = new List<int>();
            
            for (int i = 0; i < charsOfS.Length; i++)
            {

                if (charsOfS[i] == ')')
                {
                    holder1.Add(i);
                }
                else if (charsOfS[i] == '(')
                {
                    holder2.Add(i);
                }

            }
            if (holder1.Count < holder2.Count)
            {
                for (int j = 0; j < holder1.Count; j++)
                {
                    for (int k = 0; k < holder2.Count; k++)
                    {
                        if (holder1[j] > holder2[k])
                        {
                            Console.WriteLine(holder1[j] + " " + holder2[k]);
                            holder1[j] = 0;
                            holder2[k] = 0;
                            result += 2;

                            break;
                        }

                    }
                    Console.WriteLine(holder1.Count + " " + j + " " + holder2.Count);

                }
            }
            else
            {
                for (int j = 0; j < holder2.Count; j++)
                {
                    for (int k = 0; k < holder1.Count; k++)
                    {
                        if (holder1[k] > holder2[j])
                        {
                            Console.WriteLine(holder1[k] + " " + holder2[j]);
                            holder1[k] = 0;
                            holder2[j] = 0;
                            result += 2;

                            break;
                        }

                    }
                    Console.WriteLine(holder1.Count + " " + j + " " + holder2.Count);

                }
            }

            Console.WriteLine(result);


        }
    }
}
