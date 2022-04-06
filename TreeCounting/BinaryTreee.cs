using System;
namespace calc.TreeCounting
{
    public class BinaryTreee
    {
        int _value;
        BinaryTreee _left { get; set; }
        BinaryTreee _right { get; set; }

        public BinaryTreee(int value)
        {
            _value = value;
            _left = null;
            _right = null;
        }

        public void addNode(int value)
        {
            if (value < _value)
            {
                if (_left == null)
                {
                    _left = new BinaryTreee(value);
                    Console.WriteLine(_left._value + " Left ");

                } else
                {
                    Console.Write("_");
                    _left.addNode(value);
                   
                }
            } else
            {
                if (_right == null)
                {
                    _right = new BinaryTreee(value);
                    Console.WriteLine(_right._value + " Right ");
                }
                else
                {
                    Console.Write("_");
                    _right.addNode(value);
                }
            }
            
        }
    }
}
