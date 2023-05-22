namespace Day15Solutions{
    public class BinarySearchTree{
        int data;
        BinarySearchTree left,right;

        public BinarySearchTree(){}

        public BinarySearchTree(int data){
            this.data=data;
            left=right=null;
        }

        public void Add(int data){
            BinarySearchTree root=this;
            while(root!=null){
                if(root.data>data)
                    root=root.left;
                else
                    root=root.right;
            }
            root=new BinarySearchTree(data);
        }
    }
}