using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWpro4.Tree
{
    class Graph
    {
        List<int> graphStructure;
        public List<Edge> graphEdges;

        public Graph()
        {

        }
        public Graph(List<int> _graphStructure, bool _type)
        {
            
            this.graphStructure = _graphStructure;
            this.graphEdges = new List<Edge>();
            Node nodePrototype = new Node(!_type, 0, "prototype");
            List<Node> olderNodes = new List<Node>();

            int counter=1;
            int x = -1;
            for (int i = 0; x < i; i++)
            {            
                List<Node> tmpHoldings = new List<Node>();
                int checker = this.graphEdges.Count;

                _type = _type == true ? false : true;
                if (i == 0) olderNodes.Add(new Node(!_type,0,"0"));

                foreach(Node olderMember in olderNodes)
                {                    
                    for (int j = 0; j < graphStructure.Count - 1; j++)
                    {
                        if (olderMember.checkActiveStatus() != true) break;

                        Edge tmpEdge = new Edge(graphStructure[j]);

                        tmpEdge.masterNode = olderMember;
                        tmpEdge.slaveNode = new Node(_type, graphStructure[j] + olderMember.nodeValue,counter.ToString());

                        if (tmpEdge.slaveNode.nodeValue >= graphStructure[graphStructure.Count - 1])
                        {
                            tmpEdge.slaveNode.deactivate();
                            if(tmpEdge.masterNode.nodeType == nodePrototype.nodeType)
                            {
                                if (tmpEdge.slaveNode.nodeValue > graphStructure[graphStructure.Count - 1])
                                {
                                    tmpEdge.slaveNode.nodeScore = 2;
                                }
                                else if (tmpEdge.slaveNode.nodeValue == graphStructure[graphStructure.Count - 1])
                                {
                                    tmpEdge.slaveNode.nodeScore = 1;
                                }
                            }
                            else
                            {
                                if (tmpEdge.slaveNode.nodeValue > graphStructure[graphStructure.Count - 1])
                                {
                                    tmpEdge.slaveNode.nodeScore = 0;
                                }
                                else if (tmpEdge.slaveNode.nodeValue == graphStructure[graphStructure.Count - 1])
                                {
                                    tmpEdge.slaveNode.nodeScore = 1;
                                }
                            }
                           
                        } 
                            

                        this.graphEdges.Add(tmpEdge);
                        tmpHoldings.Add(tmpEdge.slaveNode);
                        counter++;
                    }
                }


                olderNodes.Clear();
                olderNodes = tmpHoldings.GetRange(0, tmpHoldings.Count);

                if (this.graphEdges.Count == checker) break;
            }

                   
        }
    }
}
