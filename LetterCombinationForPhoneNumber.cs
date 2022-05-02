using System;
using System.Collections.Generic;
namespace calc
{
    public class LetterCombinationForPhoneNumber
    {
        public static List<string> solution = new List<string>();
        public static string digits = "27";
        public static Dictionary<char, List<string>> sortingIntoList = new Dictionary<char, List<string>>();
        public static void letterCombinationForPhoneNumber()
        {
            
            
            

            
            sortingIntoList.Add('2', new List<string> { "a", "b", "c" });
            sortingIntoList.Add('3', new List<string> { "d", "e", "f" });
            sortingIntoList.Add('4', new List<string> { "g", "h", "i" });
            sortingIntoList.Add('5', new List<string> { "j", "k", "l" });
            sortingIntoList.Add('6', new List<string> { "m", "n", "o" });
            sortingIntoList.Add('7', new List<string> { "p", "q", "r", "s" });
            sortingIntoList.Add('8', new List<string> { "t", "u", "v" });
            sortingIntoList.Add('9', new List<string> { "w", "x", "y", "z" });

            backtrack(0, string.Empty);
        }
        public static void backtrack(int i, string currentString)
        {
            char[] allMyNums = digits.ToCharArray();
            if (currentString.Length == digits.Length)
            {
                solution.Add(currentString);
                return;
            }
            else
            {
                for (int j = 0; j < sortingIntoList[allMyNums[i]].Count; j++)
                {
                    backtrack(i + 1, currentString + sortingIntoList[allMyNums[i]][j]);
                }
            }
        }
    }
}
/*for (int i = 0; i < sortingIntoList[allMyNums[0]].Count; i++)
        {
            Console.WriteLine(sortingIntoList[allMyNums[0]][i]);
            for (int j = 0; j < sortingIntoList[allMyNums[1]].Count; j++)
            {
                Console.WriteLine(sortingIntoList[allMyNums[0]][i] + sortingIntoList[allMyNums[1]][j]);
            }
            Console.WriteLine("");
        }*/