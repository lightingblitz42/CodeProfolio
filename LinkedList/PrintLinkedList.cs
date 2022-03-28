using System;
using System.Collections.Generic;
namespace calc.LinkedList
{
    public class PrintLinkedList
    {
        public static void main(string[] args)
        {
            var a = new LinkedNode(1);
            var b = new LinkedNode(2);
            var c = new LinkedNode(3);

            a._next = b;
            b._next = c;
            c._before = b;
            b._before = a;

            printHeadToTail(a);
            printTailToHead(a);
        }

        public static void printHeadToTail(LinkedNode head)
        {
            var currentnode = head;
            Console.Write(currentnode._value + ", ");
            while (currentnode._next != null)
            {
                currentnode = currentnode._next;
                Console.Write(currentnode._value + ", ");
                


            }

          

        }

        public static void printTailToHead(LinkedNode head)
        {
            var currentnode = head;
            Console.WriteLine("");

            while (currentnode._next != null)
            {
                currentnode = currentnode._next;
            }
            Console.Write(currentnode._value + ", ");
            while (currentnode._before != null)
            {
                
                currentnode = currentnode._before;
                Console.Write(currentnode._value + ", ");
            }
            Console.WriteLine("");
        }
    }
}
