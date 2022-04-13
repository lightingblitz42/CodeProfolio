using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public static class WordSearch
    {
        public static char[] f = new char[] { 'L', 'K', 'C', 'P' };
        public static List<char> k = new List<char> { 'O', 'B', 'C', 'P' };
        public static char[] c = new char[] { 'S', 'F', 'C', 'S' };
        public static char[] t = new char[] { 'A', 'D', 'E', 'E' };
        public static char[][] board = new char[][] { f, c, t };
        static string word = "SAUJFWYUTYCRFTDH";

        public static List<char> otherwordfake = new List<char>(word.ToCharArray());
        public static List<char> hashysjuner = new List<char>(otherwordfake);
        public static List<char> hashys = new List<char>();
        public static List<char> befored = new List<char>();
        public static int hashycount = 0;


        public static void wordSearch()
        {

            for (int o = 0; o < board.Length; o++)
            {
                List<char> dtherword = new List<char>(board[o]);
                Code(dtherword);
            }



            for (int op = 0; op < hashysjuner.Count; op++)
            {
                if (hashys.Contains(hashysjuner[op]))
                {
                    hashys.Remove(hashysjuner[op]);
                }
                else
                {
                    Console.WriteLine(hashysjuner[op] + "wduywudya");
                    Console.WriteLine(false);
                }
            }

            if (hashycount >= hashysjuner.Count)
            {
                foreach (var item in hashys)
                {
                    Console.Write(item);
                }
                Console.WriteLine("");
                Console.WriteLine(hashycount);
                Console.WriteLine("True");



            }
            else
            {

                foreach (var item in hashys)
                {
                    Console.Write(item);
                }
                Console.WriteLine("");
                Console.WriteLine(hashycount + ", " + hashysjuner.Count);
                Console.WriteLine(false);
            }

        }
        public static void Code(List<char> Chocolate)
        {


            int Chocolatecount = Chocolate.Count;
            int othercount = otherwordfake.Count;
            int ff = 0;
            for (int i = 0; i < Chocolate.Count; i++)
            {

                if (othercount == ff)
                {
                    Console.WriteLine("d");
                    return;
                }
                for (int j = 0; j < othercount; j++)
                {
                    ff = j;
                    if (othercount == j)
                    {
                        Console.WriteLine("d");
                        return;
                    }
                    var er = Chocolate[i];
                    var err = otherwordfake[j];


                    if (er == err)
                    {

                        Console.WriteLine(er + " " + err);


                        hashycount++;
                        Console.WriteLine(hashycount + ", ");
                        hashys.Add(Chocolate[i]);
                        break;
                        //     Chocolate.Remove(Chocolate[j]);
                        //Chocolatecount--;
                        //otherword.Remove(otherword[j]);
                        //  othercount--;
                    }
                    else
                    {
                        Console.WriteLine(er + " " + err + "ldd" + j);

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






