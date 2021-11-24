using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Node
    {
       
            public int data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        public Node(int data)
        {
            this.data = data;

        }

    }
}
