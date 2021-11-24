using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class BSTTree<T> where T : IComparable<T>
    {
        public T data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public void Node(T data)
        {
            this.data = data;
           

        }


        public Node _root;
        public BSTTree()
        {
            _root = null;
        }
        public void Insert(int  data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRec(_root, new Node(data));
        }
        public void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.data < root.data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        
        public void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
        
}

       
       