using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace DataStructure
{
    class LinkedListDS
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            Node<string> a = new Node<string>("hello");
            list.AddFirst(a);
            Node<string> b = new Node<string>("Welcome");
            list.AddFirst(b);
            Node<string> c = new Node<string>("to");
            list.AddFirst(c);
            Node<string> d = new Node<string>("Linked List");
            list.AddFirst(d);

            list.Traverse();

            //Console.WriteLine("After Node d");
            //list.AddAfter(new Node<string>("Data Structure"), c);
            

            list.RemoveFirst();
            list.Traverse();

        }


    }
}
