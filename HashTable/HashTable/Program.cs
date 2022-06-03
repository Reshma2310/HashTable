using System;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----UC1-Freq of Words-----
            /*Console.WriteLine("Getting Frequency using Hash Table");
            HashTable.MyMapNode<int, string> table = new HashTable.MyMapNode<int, string>();
            table.add(0, "to");
            table.add(1, "be");
            table.add(2, "or");
            table.add(3, "not");
            table.add(4, "to");
            table.add(5, "be");
            table.GetFreq("to");*/
            //-------UC2 Freq of Sentence--------
            
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = phrase.ToLower().Split(" ");
            var dist = words.Distinct();
            int length = 0;
            foreach (var word in dist)
                length++;
            HashTable.MyMapNode<string, int> map = new HashTable.MyMapNode<string, int>(length);
            int count = 1;
            foreach (string word in words)
            {
                if (word == "avoidable")//To Remove 'avoidable' word... added if...else.
                {
                    continue;
                }
                else if (map.ContainsKey(word))
                {
                    count = map.GetValue(word) + 1;
                    map.Remove(word);
                    map.add(word, count);
                }
                else
                {
                    map.add(word, 1);
                }
            }
            Console.WriteLine("Frequency ---> Count");
            foreach (string key in dist)
            {
                Console.WriteLine(key + " ---> " + map.GetValue(key));
            }
        }        
    }
}