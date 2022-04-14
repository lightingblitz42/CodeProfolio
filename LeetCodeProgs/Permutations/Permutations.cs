using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs.Permutations
{
    public class Permutations
    {
       
        public static int counter = 0;
        public static IList<IList<int>> y = new List<IList<int>>();
        public static HashSet<List<int>> hashbrown = new HashSet<List<int>>();
        public static int[] nums = new int[] { 1, 2, 3 };
     
       
        public static void myPermutations()
        {
           

            
            
                other();



            Console.WriteLine(y.Count);


        }

        public static void other()
        {
           
      
            for (int i = 0; i < nums.Length - 1; i++)
            {

               
                List<int> cool = new List<int>(nums);
                hashbrown.Add(cool);
                y.Add(cool);
                foreach (var item in cool)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("");
                int TEMP1 = nums[i];
                int TEMP2 = nums[i + 1];
                nums[i] = TEMP2;
                nums[i + 1] = TEMP1;
                if (counter > nums.Length * nums.Length)
                {
                    
                      
                        
                        return;
                       
                    
                }
                if (counter != 0 && y[0] != y[counter])
                {

                //    return;
                }
                counter++;
            }


           

            foreach (var boo in y)
            {
                foreach (var hi in boo)
                {
                    Console.Write(hi + ", d");
                }
                Console.WriteLine("");
            }
         //   Console.WriteLine("");

           
            
            other();
        }
    }
}
