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

        public void Insert(int elem)
        {
            Node newNode = new Node(elem);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }

        public void InsertFront(int elem)
        {
            Node newNode = new Node(elem);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }


        public void InsertRear(int elem)
        {
            Node newNode = new Node(elem);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }



        public Node GetLastNode()
        {
            Node temp=head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Display()
        {
            Node temp;
            if(head == null)
            {
                Console.WriteLine("Display is Not Possible");
            }
            else
            {
                temp=head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }

            }
            
            Console.WriteLine();
        } 


        public void DeleteFront()
        {
            Node temp;
            if(head == null)
            {
                Console.WriteLine("List is Empty") ;
            }
            else
            {
                Console.WriteLine("Deleted Element is: " + head.data);
                head = head.next;
            }
        }

        public void DeleteLast()
        {
            
            if(head == null)
            {
                Console.WriteLine("No Elements to Delete");
                return;
            }
            if(head.next == null)
            {
                Console.WriteLine("Deleted Element is: "+head.data);
                head = null;
                return;
            }
            else
            {
                Node temp = head;
                Node prev = null;
                while (temp.next!=null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                Console.WriteLine("Deleted ELement is: " + temp.data);
                prev.next = null;

            }
        }
    }
}
