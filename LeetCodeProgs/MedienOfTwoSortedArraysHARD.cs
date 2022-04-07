using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class MedienOfTwoSortedArraysHARD
    {
       private static int[] numbers1 = new int[] {9, 10, 8, 4, 1, 3, 6};
       private static int[] numbers2 = new int[] {2, 8, 3, 5, 10 , 8};

        public static void medienOfTwoSortedArraysHARD()
        {
        List<int> combinedArray = new List<int>();
        makeCombination(combinedArray, numbers1);
        makeCombination(combinedArray, numbers2);
        }
        public static void makeCombination(List<int> comArr, int[] theArray)
        {
        for (int i = 0; i < theArray.Length; i++)
        {
        comArr.Add(theArray[i]);
        }
        mergeCode(comArr);   
        }
        public static void mergeCode(List<int> combList)
        {
            if (combList.Count < 2)
            {
            return;
            }
            int middle = combList.Count / 2;
            List<int> Left = new List<int>(middle);//this is a mergesort by the way
            List<int> Right = new List<int>(combList.Count - middle);// the stuff in my () is the count its gana be No values yet
            for (int i = 0; i < middle; i++)
            {
                Left.Add(combList[i]);
            }
            for (int j = middle; j < combList.Count; j++)
            {
                Right.Add(combList[j]) ;
            }
            if(combList.Count > 2)
            {
                mergeCode(Left);
                mergeCode(Right);
                sorting(Left, Right, combList);
            }
        }
        public static void sorting(List<int> listLeft, List<int> listRight, List<int> combList)
        {
            int i = 0;
            int j = 0;
            int k = 0;          
            while (i < listLeft.Count && j < listRight.Count)
            {
                if (listLeft[i] < listRight[j])
                {
                    combList[k] = listLeft[i];
                    i++;
                }
                else
                {
                    combList[k] = listRight[j];
                    j++;
                }
                k++;
            }
            while (i < listLeft.Count)
            {
                combList[k] = listLeft[i];
                i++;
                k++;
            }
            while (j < listRight.Count)
            {
                combList[k] = listRight[j];
                j++;
                k++;
            }
            compile(combList);
        }
        public static void compile(List<int> combList)
        {
            foreach (var item in combList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("");
            if (combList.Count == numbers1.Length + numbers2.Length)
            {
                findTheMedien(combList);
            }
        }
        public static void findTheMedien(List<int> pack)
        {
            if (pack.Count % 2 == 0)
            {
                int half = pack[pack.Count / 2];
                float together = pack[half] + pack[half + 1];
                
                Console.WriteLine(together / 2 + "d");
            }
            else
            {
                Console.WriteLine(pack[pack.Count / 2]);
            }
        }
    }
}
