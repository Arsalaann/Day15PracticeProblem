namespace Day15Solutions{
    class Program{
        public static void Main(string [] args){
            //Console.WriteLine("Enter a sentence: ");
            string temp="Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Sentence=temp.Split(' ');
            MyHashTable HashTable=new MyHashTable();
            foreach(string tmp in Sentence)
                HashTable.Add(tmp);
            HashTable.Display();
        }
    }
}