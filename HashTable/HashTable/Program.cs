using System;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Frequency using Hash Table");
            HashTable.MyMapNode<int, string> table = new HashTable.MyMapNode<int, string>();
            table.add(0, "to");
            table.add(1, "be");
            table.add(2, "or");
            table.add(3, "not");
            table.add(4, "to");
            table.add(5, "be");
            table.GetFreq("to");                       
        }        
    }
}