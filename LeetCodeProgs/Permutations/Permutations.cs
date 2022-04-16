using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs.Permutations
{
    public class Permutations
    {
       
        public static int counter = 0;
        
        public static IList<IList<int>> y = new List<IList<int>>();
        public static HashSet<IList<int>> hashbrown = new HashSet<IList<int>>();
        public static int[] nums = new int[] { 1, 2, 3 };
        public static IList<int> lil = new List<int>(nums);

        public static void myPermutations()
        {

           
            
            
                other();



            Console.WriteLine(hashbrown.Count + " " + y.Count);
           

        }

        public static void other()
        {
           
      
            for (int i = 0; i < nums.Length - 1; i++)
            {

                bool ony = false;
                List<int> cool = new List<int>(nums);
                if (counter != 0)
                {
                    for (int k = 0; k < cool.Count; k++)
                    {
                        if (cool[k] != lil[k])
                        {
                            ony = true;

                        }
                    }
                    //    return;
                }
                else
                {
                    ony = true;
                }
                if (ony == false)
                {
                    return;

                }
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
