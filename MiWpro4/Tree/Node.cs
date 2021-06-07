using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWpro4.Tree
{
    public class Node
    {
        bool isActive;
        public bool isColor;
        public string nodeId;
        public string nodeType;
        public int nodeValue;
        public int nodeScore;
        
        
        public Node(bool _nodeType, int _nodeValue, string _nodeName)
        {
            this.nodeType = _nodeType == true ? "Protagonist" : "Antagonist";
            this.nodeValue = _nodeValue;
            this.isActive = true;
            this.nodeId = _nodeName;
            this.nodeScore = -1;
        }

        public void deactivate()
        {
            this.isActive = false;
        }
        public bool checkActiveStatus()
        {
            if(this.isActive == true) return true;
                else return false;
            
        }
        
    }
}
