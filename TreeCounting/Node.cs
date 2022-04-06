using System;
namespace calc.TreeCounting
{
    public class Node
    {

        public static void boni()
        {

            
            int[] nums = new int[] { 5,3,1,4,8,7,9 };
            Bina a = new Bina(nums);
            Console.WriteLine(a.left.left.value);



            //Console.WriteLine(a.right.right.value);
        }
    }

}
