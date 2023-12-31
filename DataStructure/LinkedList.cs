﻿using System;
using System.CodeDom.Compiler;
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
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
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
            if (head == null)
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

        public void DeleteByValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty. Deletion not possible.");
                return;
            }

            Node temp = head;
            Node prev = null;

            if (temp.data == value)
            {
                head = temp.next;
                return;
            }

            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Element not found. Deletion not possible.");
                return;
            }

            prev.next = temp.next;
        }

        public void SearchNode(int key)
        {
            if(head==null)
            {
                Console.WriteLine("No Element in List to Search");
            }
            else
            {
                Node temp=head;
                bool found=false;
                while(temp!=null)
                {
                    if(key==temp.data)
                    {
                        found = true;
                        break;
                    }
                    temp = temp.next;                   
                }
                if(found==true)
                {
                    Console.WriteLine("ELement is Found");
                }
                else
                {
                    Console.WriteLine("ELement Not Found");
                }
            }

        }

    }
}
