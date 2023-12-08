using System;


namespace DataStructure
{
    internal class LinkedList<T>
    {
        public Node<T> First { get; private set; }         //first node pointer

        public Node<T> Last { get; private set; }              //last node pointer

        public int Count { get; private set; }           //to count how many Data LinkedList have


        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }


        public void AddFirst(Node<T> newNode)    //Add operation to first element
        {
            if (this.First == null)   //for empty linked list
            {
                this.First = newNode;      //show the first and last pointer to first newNode
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }


        public void AddLast(Node<T> newNode)
        {
            if (this.First == null)
            {                                    //if Linked List is Empty insert to starting(create Node)
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;            // add to last node if not empty
                Last = newNode;
            }
            Count++;
        }
        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            if (Last.Next == existingNode)  // adding last thrn repoint last to newnode
            {
                Last = newNode;
                return;

            }
            newNode.Next = existingNode;          // NewNode Next-> points to existing Node
            existingNode.Next = newNode;              //existing Next=> new node
            this.Count++;
            return;
        }

        public Node<T> Find(T target)
        {
            Node<T> currentNode = First;                              // start from first Node
            while (currentNode != null && !currentNode.Data.Equals(target))       // check cond  current node not eqal to numm or its data equal to target
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public void RemoveFirst()           // remove first
        {
            if (First == null && this.Count == 0)          // if No Data then Return Empty
            {
                return;  //return empty
            }
            First = First.Next;             // if it has valur then Move the Pointer from Current first to its Next address elemnt
            Count--;                        // decrement count
        }


        public void Remove(Node<T> doomedNode)
        {
            if (First == null && this.Count == 0)
            {
                return;
            }

            if (this.First == doomedNode)
            {
                this.RemoveFirst();
                return;
            }


            //else you need to traverse ll to find that node
            Node<T> previous = First;
            Node<T> current = previous.Next;

            while (current != null && current != doomedNode)
            {
                //move to the next Node
                previous = current;
                current = previous.Next;
            }

            //remove it
            if (current != null)
            {
                previous.Next = current.Next;
                this.Count--;
            }
        }

        public void Traverse()
        {
            Console.WriteLine("\nFirst " + this.First.Data);
            Console.WriteLine("Last " + this.Last.Data);

            Node<T> node = this.First;

            while (node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);
        }
    }
}
