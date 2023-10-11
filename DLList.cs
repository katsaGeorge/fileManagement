using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace File_Management
{
    internal class DLList
    {

        public Node? Head {get;set;}
        public Node? Tail { get;set;}

        public DLList()
        {
            Head = null;
            Tail = null;        
        }

        public void InsertFirst(Char t)
        {
            Node tmp = new();
            tmp.Value = t;
            tmp.Next = Head;
            tmp.Prev = null;

            tmp.count++;

            if (Head is null)
            {
                Tail = tmp;
            }
             Head = tmp;
        }

        public void InsertLast (Char t)
        {
            if (Head is null)
            {
               InsertFirst(t);
                return;    
            }

            Node tmp = new();

            tmp.Value = t;
            tmp.Next = null;
            tmp.Prev = Tail;

            tmp.count++;

            Tail!.Next = tmp;
            Tail = tmp;
        }

        public void Traverse(int count)
        {
            if (Head is null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            Console.WriteLine($"Total chars: {count}");

            for (Node node = Head; node != null; node = node.Next!) 
            {
                Console.WriteLine($" value: {node.Value}, Count: {node.count}, Frequency: {((double)node.count / count) * 100 :N2}");
            }
        }

        public Node GetNodePosition(Char t)
        {
            Node tmp = Head!;

            while (tmp != null) 
            {
                if (tmp.Value.Equals(t))
                {
                    return tmp;
                }
                tmp = tmp.Next!;

            }

            return null!;
        }

        public void IncreaseCount(Node node)
        {
            node.count++;
        }

        public void IncreaseCount(Char t)
        {
            GetNodePosition(t).count++; 
        }


    }
}
