using System;
using System.Collections.Generic;

namespace calc.Graph
{
    public class GraphNode
    {
        public int _value { get; }
        public List<GraphNode> _relations { get; }

        public GraphNode(int value)
        {
            _value = value;
            _relations = new List<GraphNode>();
        }
    }
}
