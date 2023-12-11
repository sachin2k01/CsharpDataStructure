using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class TreeDS
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            t.Insert(34);
            t.Insert(23);
            t.Insert(76);
            t.Insert(56);
            t.Insert(84);
            t.Insert(99);
            t.Insert(11);

            Console.WriteLine("InOrder Traversal of a Tree");
            t.In_order(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("PreOrder Traversal of a Tree");
            t.Pre_0rder(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("PostOrder Traversal of a Tree");
            t.Post_order(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
        }
    }
}
