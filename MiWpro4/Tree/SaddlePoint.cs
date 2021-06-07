using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWpro4.Tree
{
    static class SaddlePoint
    {
        public static Graph saddleFull(Graph tmpGraph)
        {
            Node tmpNode = tmpGraph.graphEdges[tmpGraph.graphEdges.Count()-1].masterNode;
            List<Edge> slaveNodeHoldings = new List<Edge>();
            List<int> indexs = new List<int>();
            int counter = 0;
            for (int i = tmpGraph.graphEdges.Count()-1; i>=0;i--)
            {
                
                if (tmpGraph.graphEdges[i].masterNode != tmpNode)
                {
                    int value = saddleStep(slaveNodeHoldings, tmpNode);

                    foreach(var x in indexs)
                    {
                        tmpGraph.graphEdges[x].masterNode.nodeScore = value;
                        if(tmpGraph.graphEdges[x].masterNode.nodeScore == tmpGraph.graphEdges[x].slaveNode.nodeScore && counter == 0)
                        {
                            tmpGraph.graphEdges[x].isColor = true;
                            counter = 1;
                            
                        }
                        
                    }
                   

                  
                    tmpNode = tmpGraph.graphEdges[i].masterNode;
                    slaveNodeHoldings.Clear();
                    indexs.Clear();
                    counter = 0;

                }
                
                slaveNodeHoldings.Add(tmpGraph.graphEdges[i]);
                indexs.Add(i);
                


            }

            int valueRoot = saddleStep(slaveNodeHoldings, tmpNode);
 
            foreach (var x in indexs)
            {
                tmpGraph.graphEdges[x].masterNode.nodeScore = valueRoot;
                
                if (tmpGraph.graphEdges[x].masterNode.nodeScore == tmpGraph.graphEdges[x].slaveNode.nodeScore && counter == 0)
                {
                    tmpGraph.graphEdges[x].isColor = true;
                    counter = 1;
                }
            }


            

            return tmpGraph;
        }
     
        private static int saddleStep(List<Edge> slaveNodeHoldings, Node masterNode)
        {
            List<int> values = new List<int>();

            foreach (var x in slaveNodeHoldings)
            {
                values.Add(x.slaveNode.nodeScore);
            }

            if (slaveNodeHoldings[0].masterNode.nodeType == "Antagonist")
            {
                return values.Min();
            }
            else
            {
                return values.Max();
            }
           
                     
        }
       
    }
}
