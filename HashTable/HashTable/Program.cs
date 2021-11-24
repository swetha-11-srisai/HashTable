using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash<int , string> hash = new Hash<int,string>(3);

            hash.Add(0, "Hii");
            hash.Add(1, "Hi");
            hash.Add(2, "Hello");
            string hash3= hash.Get(2);
            Console.WriteLine(hash3);
            hash.Remove(0);
            string hash2 = hash.Get(1);
            Console.WriteLine(hash2);
        }
    }
}
