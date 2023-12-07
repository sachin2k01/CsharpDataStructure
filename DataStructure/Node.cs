using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Node <T>
    {
        public T Data { get; set; }    //data

        public Node<T> Next { get; internal set; }     //link

        public Node(T data)                              //constructor
        {
            this.Data = data;
        }
    }
}
