using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {
        private Node head;
        private int llsize;

        public LinkedList() 
        {
            this.head = null;
            this.llsize = 0;
        }

        public bool IsEmpty
        {
            get
            {
                return this.llsize == 0;
            }
        }

        public int LinkedListSize
        {
            get 
            {
                return this.llsize;
            }
        }
    }
}
