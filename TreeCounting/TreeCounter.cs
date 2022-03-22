using System;
namespace calc.TreeCounting
{
    public class TreeCounter
    {
        
       
        public static void main(string[] args)
        {

            TreeNode a = new TreeNode(2);
            TreeNode aa = new TreeNode(3);
            TreeNode ab = new TreeNode(2);
            TreeNode aaa = new TreeNode(3);
            TreeNode aab = new TreeNode(2);
            TreeNode aba = new TreeNode(4);
            TreeNode abb = new TreeNode(2);
            TreeNode abba = new TreeNode(2);

            a._children.Add(aa);
            a._children.Add(ab);

            aa._children.Add(aaa);
            aa._children.Add(aab);

            ab._children.Add(aba);
            ab._children.Add(abb);

            abb._children.Add(abba);
           
            int result = countValues(a, 0);
        }
        public static int countValues(TreeNode node, int depth)
        {
            int count = 0;
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("Starting");
            foreach (TreeNode child in node._children)
            {
                count += countValues(child, depth + 1);
            }
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(count+node._value);
            return node._value + count ;
        }

       

    }
}
