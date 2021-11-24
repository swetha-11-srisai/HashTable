using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Hash<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public  Hash(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K Key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K Key)
        {
            int position = GetArrayPosition(Key);

            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(Key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(K Key)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(Key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList( int position)
        {
             LinkedList<KeyValue<K, V>> linkedList = items[position];
             if(linkedList==null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position]=linkedList;
            }
            return linkedList;
        }
        public struct KeyValue<k, v>
        {
             public k Key { get; set; }
                public v Value { get; set; }
        }
    }
}
    
       

        
            
        


 
        