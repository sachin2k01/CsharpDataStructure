using System;

namespace DataStructure
{
    public class TNode
    {
        public int data;
        public TNode left;
        public TNode right;

        public void show()
        {
            Console.WriteLine($"[ {data} ]");
        }

    }
    public class Tree
    {
        public TNode root;
        public Tree( )
        {
            root = null;

        }
        public TNode ReturnRoot( )
        {
            return root;
        }

        public void Insert(int x)
        {
            TNode newnode=new TNode();
            newnode.data = x;
            if( root == null ) 
            {
                root=newnode;
            }
            else
            {
                TNode current=root;
                TNode parent;
                while(true)
                {
                    parent=current;
                    if(x<current.data)
                    {
                        parent.left = newnode;
                        return;
                    }
                    else
                    {
                        current = current.right;
                        if(current==null)
                        {
                            parent.right = newnode;
                            return;
                        }
                    }
                }
            }
        }

        public void Pre_0rder(TNode Root)
        {
            if( Root != null )
            {
                Console.Write(Root.data + " ");
                Pre_0rder(Root.left);
                Pre_0rder(Root.right);
            }
        }

        public void In_order(TNode Root)
        {
            if( Root != null )
            {
                In_order(Root.left);
                Console.Write(Root.data + " ");
                In_order(Root.right);
            }
        }
        public void Post_order(TNode Root)
        {
            if ( Root != null )
            {
                Post_order(Root.left);
                Post_order(Root.right);
                Console.Write(Root.data + " ");
            }
        }
    }
}
