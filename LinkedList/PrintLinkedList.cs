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
            printTailToHeadWithoutmid(a);
            changeaValue(a);
           // getRidOfValue(a);
            addValue(a);
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
        public static void printTailToHeadWithoutmid(LinkedNode head)
        {
            var currentnode = head;
            Console.Write(currentnode._value + ", ");
            if (currentnode._next._next != null)
            {
                currentnode = head._next._next;
                Console.Write(currentnode._value + ", ");
            }
            Console.WriteLine("");
        }
        public static void changeaValue(LinkedNode head)
        {
            var ot = head;
            while (ot != null)
            {

               
             //   Console.Write(ot._value + ", ");
                int ik = ot._value;
                ik += ot._value;
                 head = ot;
                Console.Write(ot._value + ik + ", ");
               ot = ot._next;
            }
            Console.WriteLine("");
        }
        public static void getRidOfValue(LinkedNode head)
        {
            var f = head;
            var d = head;
            Console.Write(head._value + ", ");
            if (d._next._next != null)
            {


                d = d._next;
               
                d._next._next = null;
                head._next._next = null;
            }
            head = f;
            while (f._next != null)
            {
                f = f._next;
                Console.Write(f._value + ", ");
            }
            Console.WriteLine("");
        }

        public static void addValue(LinkedNode head)
        {
           

        
              LinkedNode tp = head;
            LinkedNode temp2 = new LinkedNode(5);
            LinkedNode temp = new LinkedNode(4);
            while (tp._next != null)
              {
                  tp = tp._next;
              }
          
              tp._next = temp;
              temp._before = tp;
            temp._next = temp2;
            temp2._before = temp;
           var t = head;
            Console.Write(t._value + ", ");
            while(t._next != null)
            {
                t = t._next;
                Console.Write(t._value + ", ");
            }

              /* var a = new LinkedNode(1);
               var b = new LinkedNode(2);
               var c = new LinkedNode(3);
               var d = new LinkedNode(4);

               a._next = b;
               b._next = c;
               c._before = b;
               b._before = a;
               c._next = d;
               d._before = c;
               /* var temp = head._next;
                var temp2 = temp._next;
                temp._next = d;
                temp2._before = d;
                d._next = temp2;
                d._before = temp;





               var currentnode = a;


               while (currentnode != null)
               {
                   Console.Write(currentnode._value + ", ");
                   currentnode = currentnode._next;


               }
              */
        }
    }
   
}
