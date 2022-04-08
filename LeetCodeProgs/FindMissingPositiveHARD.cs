using System;
namespace calc.LeetCodeProgs
{
    public class FindMissingPositiveHARD
    {
        public static int[] unsortedArray = new int[] {1,7,2,4,3,5,8,3,1};
        public static void findMissingPositiveHARD()
        {
          


            for (int i = 1; i < unsortedArray.Length + 1; i++)
            {
                bool yesno = false;
                foreach (var item in unsortedArray)
                {
                    if (i == item)
                    {
                        yesno = true;
                    }
                }
               
              if (yesno == false)
                {
                    Console.WriteLine(i);
                    break;
                }
               
            }
        }
      
        
    }
}
