namespace Day15Solutions{
    public class MyHashTable{
        Dictionary <string,int> myHashTable=new Dictionary<string,int>();

        public void Display(){
            foreach(var kvp in this.myHashTable)
                Console.WriteLine(kvp.Key+" : "+kvp.Value);
        }
        public int Key(string key){
            return myHashTable[key];
        }

        public int GetSize(){
            return this.myHashTable.Count;
        }

        public void Add(string key){
            if(this.myHashTable.ContainsKey(key))
                this.myHashTable[key]++;
            else
                this.myHashTable.Add(key,1);
        }

        public void Remove(string key){
            if(this.myHashTable.ContainsKey(key))
                this.myHashTable.Remove(key);
        }

        public bool IsEmpty(){
            if(this.myHashTable.Count == 0)
                return false;
            return true;
        }
    }
}