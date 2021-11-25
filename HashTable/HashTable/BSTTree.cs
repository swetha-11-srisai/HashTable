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
        public bool IfExists(T element, BSTTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.data.Equals(element))
            {
                Console.WriteLine("Found the Element in Binary Search Tree" + " " + node.data);
                return true;
                
            }
            else
            {
                Console.WriteLine("Current Element is {0} in Binary Search Tree", node.data);
            }
            if (element.CompareTo(node.data) < 0)
            {

                IfExists(element, node.Left);
            }
            if (element.CompareTo(node.data) > 0)
            {
                IfExists(element,node.Right);
            }
            return true;
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

       
       