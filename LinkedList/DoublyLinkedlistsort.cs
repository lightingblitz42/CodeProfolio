using System;
namespace calc.LinkedList
{
    public class DoublyLinkedlistsort
    {
        public static void doublyLinkedlistsort()
        {
            var a = new LinkedNode(122);
            var b = new LinkedNode(31);
            var c = new LinkedNode(22);
            var d = new LinkedNode(40);
            var f = new LinkedNode(52);
            var g = new LinkedNode(9);
            var s = new LinkedNode(6);
            var z = new LinkedNode(1);

            a._next = b;
            b._next = c;
            c._before = b;
            b._before = a;
            c._next = d;
            d._before = c;
            d._next = f;
            f._before = d;
            f._next = g;
            g._before = f;
            g._next = s;
            s._before = g;
            s._next = z;
            z._before = s;
            dd(a);
        }

        public static void dd(LinkedNode head)
        {
            var otherthing = head;
            var thing = head;


            while (otherthing._next != null)
            {
                while (thing._next != null)
                {

                    if (thing._value > thing._next._value)
                    {
                        var temp = thing._value;
                        var temp2 = thing._next._value;
                        thing._value = temp2;
                        thing._next._value = temp;
                        Console.Write(thing._value + ", ");
                    }
                    else

                        Console.WriteLine();

                    thing = thing._next;

                }
                thing = head;
                otherthing = otherthing._next;
            }


            while (otherthing._before != null)
            {
                Console.Write(otherthing._value + ", ");
                otherthing = otherthing._before;
            }

            Console.WriteLine("");



        }
    }
}
