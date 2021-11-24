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
            tree.Insert(22);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(95);
            tree.Insert(65);
            tree.Insert(63);
            tree.Insert(67);
            tree.Insert(11);
            tree.Insert(3);
            tree.Insert(16);
            bool result = tree.IfExists(63, tree);
            Console.WriteLine(result);
            tree.DisplayTree();
            
        }
    }
    
}
