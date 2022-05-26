using System;
namespace calc
{
    public class FindMedianOfSortedArrays
    {
        public static int[] nums1 = new int[] {};
        public static int[] nums2 = new int[] {1, 5, 9};
        public static void findMedianOfSortedArrays()
        {
            int[] combinationsOfArray = new int[nums1.Length + nums2.Length];
            int k = 0;//if it == combinations Length then the arr is full
            int j = 0;
            int l = 0;

            while (j < nums1.Length && l < nums2.Length)
            {
                if (nums1[j] < nums2[l])
                {
                    Console.WriteLine(j + " j" );
                    combinationsOfArray[k] = nums1[j];
                    j += 1;
                }
                else
                {
                    Console.WriteLine(l + " l");
                    combinationsOfArray[k] = nums2[l];
                    l += 1;
                    
                }
                k++;
            }
            while (l < nums2.Length)
            {
                combinationsOfArray[k] = nums2[l];
                l += 1;
                k += 1;
            }
            while (j < nums1.Length)
            {
                combinationsOfArray[k] = nums1[j];
                j += 1;
                k += 1;
            }
            foreach (var item in combinationsOfArray)
            {
                Console.Write(item + "ds");
            }
            Console.WriteLine();
            if (combinationsOfArray.Length % 2 == 1)
            {
                Console.WriteLine(combinationsOfArray[combinationsOfArray.Length / 2] + "d");
            }
            else
            {
                double dopple = (combinationsOfArray[combinationsOfArray.Length / 2] + combinationsOfArray[combinationsOfArray.Length / 2 - 1]) / 2;
                Console.WriteLine(dopple);
            }
            
        }
    }
}
