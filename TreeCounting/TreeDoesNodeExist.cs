using System;
namespace calc.TreeCounting
{
    public class TreeDoesNodeExist
    {
        public static void Main(string[] args)
        {

            TreeNode a = new TreeNode(6);
            TreeNode aa = new TreeNode(3);
            TreeNode ab = new TreeNode(2);
            TreeNode aaa = new TreeNode(3);
            TreeNode aab = new TreeNode(2);
            TreeNode aba = new TreeNode(4);
            TreeNode abb = new TreeNode(6);
            TreeNode abba = new TreeNode(2);

            a._children.Add(aa);
            a._children.Add(ab);

            aa._children.Add(aaa);
            aa._children.Add(aab);

            ab._children.Add(aba);
            ab._children.Add(abb);

            abb._children.Add(abba);
            
            int result = doesNodeExist(a, 6, 0);
            Console.WriteLine("Result:" + result);
        }

        public static int doesNodeExist(TreeNode node, int findValue, int depth)
        {
            
            foreach (var child in node._children)
            {

                
               

                if (findValue == doesNodeExist(child, findValue, depth))
                {
                    for (int i = 0; i < depth; i++)
                    {
                        Console.Write("_");
                    }
                    Console.WriteLine(" this is the one " + doesNodeExist(child, findValue, depth));

                    depth = 0;
                    return 6;
                   

                }
                else
                {
                    depth+= 1;
                    for (int i = 0; i < depth; i++)
                    {
                        Console.Write("_");
                    }
                    Console.WriteLine(doesNodeExist(child, findValue, depth) + "ww");

                 //   return 1;
                }
            }
            return node._value;
        }
    }
}

