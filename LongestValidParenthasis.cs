using System;
using System.Collections.Generic;
namespace calc
{
    public class LongestValidParenthasis
    {
        public static List<int> rightList = new List<int>();
        public static List<int> leftList = new List<int>();
        public static string s = "((()()())";
        public static int numberOfRighties = 0;
        public static char[] myCharArr = s.ToCharArray();
        public static int temp = 0;
        
        public static int firstContact = 0;
        public static void longestValidParenthasis()
        {
            if (s.Length == 0)
            {
                Console.WriteLine("Nothing inside");
                return;
            }
            int numberOfLefties = 0;
            for (int i = 0; i < myCharArr.Length; i++)
            {
                if (myCharArr[i] == '(')
                {
                    firstContact = i;
                    break;
                }
                
            }
            for (int l = 0; l < myCharArr.Length; l++)
            {
                if (myCharArr[l] == ')')
                {
                    leftList.Add(l);
                    numberOfLefties += 1;
                }
                else
                {
                    rightList.Add(l);
                    numberOfRighties += 1;
                }
            }
            Console.WriteLine(numberOfRighties + ", " + numberOfLefties);
            for (int m = 0; m < myCharArr.Length; m++)
            {
                for (int j = 0; j < myCharArr.Length; j++)
                {

                }
            }
           // myCode(numberOfLefties, 0, 0);

        }
       
        public static void myCode(int currentAmountLeft, int amountRun, int currentAmountRight)
        {
            Console.WriteLine(currentAmountLeft + ", " + currentAmountRight);
            int miniAnswer = 0;
            if (amountRun == myCharArr.Length)
            {
                Console.WriteLine(temp);
                return;
            }
            
            if (myCharArr[amountRun] == ')')
            {
                currentAmountLeft -= 1;
            } else if(myCharArr[amountRun] == '(')
            {
                currentAmountRight += 1;
            }
            if (currentAmountLeft < currentAmountRight)
            {
                miniAnswer = currentAmountLeft * 2;
            }
            else
            {
                miniAnswer = currentAmountRight * 2;
            }
            if (miniAnswer > temp)
            {
                temp = miniAnswer;
            }
            
            myCode(currentAmountLeft, amountRun + 1, currentAmountRight);
        }
    }
}
