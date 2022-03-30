using System;
using System.Collections.Generic;

namespace calc.LinkedList
{
    public class LinkedNode
    {
        public int _value { get; set; }
        public LinkedNode _next { get; set; }
        public LinkedNode _before { get; set; }

        public LinkedNode(int value)
        {
            
            _value = value;
            _next = null;
            _before = null;
        }
    }
}
