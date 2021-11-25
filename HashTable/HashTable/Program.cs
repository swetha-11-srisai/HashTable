using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           
                BSTTree<int> tree = new BSTTree<int>();
                Node root = new Node(56);
            Node rootone = new Node(30);
            Node roottwo = new Node(70);
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.DisplayTree();
            
        }
    }
    
}
