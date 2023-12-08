using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        private object data; 
        private Node link; 

        public Node(object data, Node next)
        {
            this.data = data;
            link = next;
            
        }

        public object Data 
        {
            get { return this.data; }
            set { this.data = value; }
            
        }

        public Node Link
        {
            get { return this.link; }
            set { this.link = value; }
        }

    }
}
