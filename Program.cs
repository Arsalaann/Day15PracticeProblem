namespace Day15Solutions{
    class Program{
        public static void main(string [] args){
            Console.WriteLine("Enter a sentence: ");
            string[] Sentence=Console.ReadLine().Split(' ');
            MyHashTable HashTable=new MyHashTable();
            foreach(string tmp in Sentence)
                HashTable.Add(tmp);
            HashTable.Display();
        }
    }
}