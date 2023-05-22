namespace Day15Solutions{
    public class BinarySearchTree{
        int data;
        BinarySearchTree left,right;

        public BinarySearchTree(){}

        public BinarySearchTree(int data){
            this.data=data;
            this.left=this.right=null;
        }

        public void Add(int data){
            BinarySearchTree prev=null,root=this;
            while(root!=null){
                if(root.data==data)
                    return;
                prev=root;
                if(root.data>data)
                    root=root.left;
                else
                    root=root.right;
            }
            if(prev.data>data)
                prev.left=new BinarySearchTree(data);
            else
                prev.right=new BinarySearchTree(data);
        }

        public void Search(int data){
            BinarySearchTree root=this;
            while(root!=null){
                if(root.data==data){
                    Console.WriteLine("Found : " + root.data);
                    return;
                }
                if(root.data>data)
                    root=root.left;
                else
                    root=root.right;
            }
            Console.WriteLine("Not found!");
        }
    }
}