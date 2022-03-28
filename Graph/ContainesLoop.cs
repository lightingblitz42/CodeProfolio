using System;
using System.Collections.Generic;
namespace calc.Graph
{
    public class ContainesLoop
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Problem1:" + problem1());
            Console.WriteLine("Problem2:" + problem2());
            Console.WriteLine("Problem3:" + problem3());
        }

        public static bool problem1()
        {
            var a = new GraphNode(1);
            var b = new GraphNode(2);
            var c = new GraphNode(3);
            var d = new GraphNode(4);
            var e = new GraphNode(5);
            var f = new GraphNode(6);
            var g = new GraphNode(7);

            a._relations.Add(b);
            a._relations.Add(c);
            b._relations.Add(c);
            c._relations.Add(d);
            d._relations.Add(e);
            d._relations.Add(f);
            f._relations.Add(g);
            List<int> lis = new List<int>();
            HashSet<int> hashbrown = new HashSet<int>();//hashbrowns taste good but only in the morning : yes yes i agree =D : hahahhahah hashybashys
            return containsLoop(a, false, hashbrown, lis);
        }

        public static bool problem2()
        {
            var a = new GraphNode(1);
            var b = new GraphNode(2);
            var c = new GraphNode(3);
            var d = new GraphNode(4);
            var e = new GraphNode(5);
            var f = new GraphNode(6);
            var g = new GraphNode(7);

            a._relations.Add(b);
            a._relations.Add(c);
            b._relations.Add(f);
            c._relations.Add(d);
            d._relations.Add(e);
            d._relations.Add(f);
            f._relations.Add(g);
            List<int> lis = new List<int>();
            HashSet<int> hashbrown = new HashSet<int>();//hashbrowns taste good but only in the morning : yes yes i agree =D : hahahhahah hashybashys
            return containsLoop(a, false, hashbrown, lis);
        }

        public static bool problem3()
        {
            var a = new GraphNode(1);
            var b = new GraphNode(2);
            var c = new GraphNode(3);
            var d = new GraphNode(4);
            var e = new GraphNode(5);
            var f = new GraphNode(6);
            var g = new GraphNode(7);

            a._relations.Add(b);
            a._relations.Add(c);
            c._relations.Add(d);
            d._relations.Add(e);
            d._relations.Add(f);
            f._relations.Add(g);
            List<int> lis = new List<int>();
            HashSet<int> hashbrown = new HashSet<int>();//hashbrowns taste good but only in the morning : yes yes i agree =D : hahahhahah hashybashys
            return containsLoop(a, false, hashbrown, lis);
        }

        public static bool containsLoop(GraphNode node, bool k, HashSet<int> hashys, List<int> listys)
        {

            if (k == true)
            {
                return false;
            }
          //  Console.WriteLine(node._relations.Count);

            foreach (GraphNode item in node._relations)
            {
                listys.Add(item._value);
                hashys.Add(item._value);
                Console.Write(item._value + ", ");
                containsLoop(item, k = false, hashys, listys);
            }
            Console.WriteLine("");
            foreach (var item in hashys)
            {
                Console.Write(item + ",");
            }
            foreach(var item in listys)
            {
                Console.Write(item + "de ");
            }
            Console.WriteLine("");
           if(listys.Count > hashys.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
            return containsLoop(node, k = true, hashys, listys);
           
        }
    }
}
