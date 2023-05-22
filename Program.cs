namespace Day15Solutions{
    class Program{
        public static void Main(string [] args){
            BinarySearchTree Tree=new BinarySearchTree(56);
            Tree.Add(30);
            Tree.Add(70);
            Tree.Add(22);
            Tree.Add(40);
            Tree.Add(60);
            Tree.Add(95);
            Tree.Add(30);
            Tree.Add(11);
            Tree.Add(65);
            Tree.Add(3);
            Tree.Add(16);
            Tree.Add(63);
            Tree.Add(67);

            Tree.Search(63);
        }
    }
}