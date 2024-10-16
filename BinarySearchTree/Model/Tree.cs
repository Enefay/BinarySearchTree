namespace BinarySearchTree.Model
{
    public class Tree
    {
        public Node Root { get; set; } = null!;

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Root.Add(value);
            }
        }

    }

}
