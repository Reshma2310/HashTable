using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        LinkedList<KeyValue<K, V>> myList = new LinkedList<KeyValue<K, V>>();
        public void add(K key, V value)
        {
            KeyValue<K, V> kv = new KeyValue<K, V>() { key = key, value = value };
            myList.AddLast(kv);
        }
        public void GetFreq(V word)
        {
            int count = 0;
            if (myList == null)
            {
                Console.WriteLine("Hash Table is empty.");
                return;
            }
            foreach (KeyValue<K, V> item in myList)
            {
                foreach (KeyValue<K, V> value in myList)
                {
                    if (item.value.Equals(value.value))
                        count++;
                }
                Console.WriteLine("Frequency of " + item.value + " is " + count);
                count = 0;
            }
        }
    }
    public struct KeyValue<K, V>
    {
        public K key;
        public V value;
    } 
}
