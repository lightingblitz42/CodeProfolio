using System;
using System.Linq;
using System.Collections.Generic;
namespace calc
{
    public static class MergeSort
    {
       

        
        public static int[] numbers = new int[15];
        public static Random rnd = new Random();


        public static void sortMerge()
        {
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 20);
                Console.Write(numbers[i] + ", ");
                
            }
            Console.WriteLine("");
      

            othermerge(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                
                Console.Write(numbers[i] + ", ");

            }
            Console.WriteLine("");

        }
        public static void othermerge(int[] inputArray)
        {

            int inputLength = inputArray.Length;
            int middle = inputLength / 2;
            if (inputLength < 2)
            {
                return;
            }
            
            int[] Left = new int[middle];
            int[] Right = new int[inputLength - middle];
            for (int j = 0; j < middle; j++)
            {
                Left[j] = inputArray[j];
            }
            for (int i = middle; i < inputLength; i++)//Since its starting at middle it will only count up to half when going up to numbers.length when it says i = middle it means it starts adding values at middle so the thing above doesent overlap
            {
                Right[i - middle] = inputArray[i];//when it wrfiƒtes i - middle its becasue we want the sub array to start at 0 to num and stuff 
            }
            othermerge(Left);
            othermerge(Right);

            merge(inputArray, Left, Right);

            
        }

        private static void merge(int[] inputArray, int[] Left, int[] Right)
        {
            int Rightsize = Right.Length;
            int leftSize = Left.Length;

            int i = 0;
            int k = 0;
            int j = 0;
            

            while (j < leftSize && i < Rightsize)
            {
                if(Left[j] <= Right[i])
                {
                    inputArray[k] = Left[j];
                    j++;
                   
                }
                else
                {
                    inputArray[k] = Right[i];
                    i++;
                    
                }
                k++;
            }
            while(j < leftSize)
            {
                inputArray[k] = Left[j];
                j++;
                k++;
            }
            while (i < Rightsize)
            {
                inputArray[k] = Right[i];
                i++;
                k++;
            }


        }
            
        


      
    }
}
/*
 *  public static List<int> listers = new List<int>();
        public static void sortMerge()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                listers.Add(numbers[i]);
                Console.WriteLine(i);
                
            }
            Console.WriteLine("");
            for (int p = 0; p < listers.Count - 1; p += 2)
            {
                if (listers[p] >= listers[p + 1])
                {
                    int dif = listers[p] - listers[p + 1];
                    listers[p + 1] += dif;
                    listers[p] -= dif;
                    Console.WriteLine(listers[p] + ", " + listers[p + 1]);
 *  if (array.Length % 2 == 0)
            {
                middle = array.Length / 2;
                Console.WriteLine("hah " + middle);
            }
            else
            {
                middle = (array.Length + 1) / 2;
            }
            Console.WriteLine(middle);
 * 
 * 
 * 
 * 
 * 
 * 
 * 
       public static int numI;
       public static int[] numbers = new int[6]
       {
           2,
           8,
           3,
           5,
           7,
           2
       };
       static List<int> thelist = new List<int>();



       private static int mid = (numbers.Length + 1) / 2;
       static int[] firsthalf = numbers.Take(mid).ToArray();
       static int[] otherhalf = numbers.Skip(mid).ToArray();
       public static void sortMerge()
       {
           thelist.Add(numbers[0]);
           Console.WriteLine(thelist[0]);
           Console.WriteLine(String.Join(", ", firsthalf));
           Console.WriteLine(String.Join(", ", otherhalf));




       }
       public static void d()
       {
           if (firsthalf[numI] > firsthalf[numI + 1])
           {
               int d = firsthalf[numI + 1];
               int f = firsthalf[numI];
           }
       }
       */
