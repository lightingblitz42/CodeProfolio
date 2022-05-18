using System;
using System.Collections.Generic;
namespace calc
{
    public class Test
    {
        public static void test()
        {
            var pairs = new List<(int left, int right)>();
            (int left, int right) pair = (0, 0);
            Console.WriteLine(pair.left + ", " + pair.right);//writes out both right and left pair
            Stack<int> leftLocStack = new Stack<int>();
            leftLocStack.Push(12);
            leftLocStack.Push(1);
            leftLocStack.Pop();//pops the top which is 1
            int macl = leftLocStack.Pop();//macl is the top of the stack
            Console.WriteLine(leftLocStack.Peek() + "d");//writes 12d count is 1btw
            Console.WriteLine(Math.Max(1, 2));
            }
        


    }
}
