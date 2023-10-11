using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Management
{
    internal class Node
    {
        public char Value { get; set; }
        public int count { get; set; }
        public Node? Next { get; set; }
        public Node? Prev { get; set; }
    }
}
