using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWpro4.Tree
{
    public class Edge
    {
        public Node masterNode;
        public Node slaveNode;
        public bool isColor;
        public float value;

        public Edge(float _value)
        {
            this.value = _value;
        }
    }
}
