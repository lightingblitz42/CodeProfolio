using System;
using System.Collections.Generic;
namespace calc.TreeCounting
{
    public class BinaryTree
    {

        public static void main(string[] args)
        {
            int[] nums = new int[]{5,3,1,0,-8,7,9,10,11,2,100,3};

            var root = new BinaryTreee(nums[0]);

            Console.WriteLine("d");
            for (int i = 1; i < nums.Length; i++)
            {
                root.addNode(nums[i]);
            }
           

            
        }


    }
}
