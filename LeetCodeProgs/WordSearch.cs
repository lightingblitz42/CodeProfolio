using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public static class WordSearch
    {
        public static char[] f = new char[] { 'O', 'B', 'C', 'P'};
        public static List<char> k = new List<char> { 'O', 'B', 'C', 'P' };
        public static char[] c = new char[] { 'S', 'F', 'C', 'S' };
        public static char[] t = new char[] { 'A', 'D', 'E', 'E' };
        public static char[][] board = new char[][] {f, c, t};
        static string word = "OBIEHIFBH";
        public static List<char> otherword = new List<char>(word.ToCharArray());
        



        public static void wordSearch()
        {
            for (int o = 0; o < board.Length; o++)
            {
               List<char> dtherword = new List<char>(board[o]);
                Code(dtherword);
            }
            Code(k);

            if (otherword.Count <= 0)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
                foreach (var item in otherword)
                {
                    Console.Write(item);
                }
                Console.WriteLine("");
            }
           
        }
        public static void Code(List<char> Chocolate)
        {
            
               int Chocolatecount = Chocolate.Count;
               int othercount = otherword.Count;
               for (int i = 0; i < otherword.Count; i++)
               {
                if (otherword.Count == i)
                {
                    return;
                }
                for (int j = 0; j < Chocolate.Count; j++)
                   {
                    if (otherword.Count == i)
                    {
                        return;
                    }
                    var er = Chocolate[j];
                    var err = otherword[i];
                    
                    
                    if(er == err)
                    {
                        Console.WriteLine(er + " " + err);
                      //    Chocolate.Remove(Chocolate[j]);
                        //Chocolatecount--;
                          otherword.Remove(otherword[i]);
                        //  othercount--;
                    }


                    //{
                    //         Console.WriteLine(i + ", " + otherword[i]);
                    //   return;
                    //  Chocolate.Remove(Chocolate[j]);
                    //Chocolatecount--;
                    //  otherword.Remove(otherword[j]);
                    //  othercount--;
                    //  }



                }
               }
            

        }
    }
}
