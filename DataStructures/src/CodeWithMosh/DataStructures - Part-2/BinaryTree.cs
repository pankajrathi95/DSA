class BinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.value = value;
        }
    }
    Node root;
    public void Insert(int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return;
        }
        Node current = root;
        while (true)
        {
            if (value > current.value)
            {
                if (current.right == null)
                {
                    current.right = new Node(value);
                    break;
                }

                current = current.right;
            }
            else
            {
                if (current.left == null)
                {
                    current.left = new Node(value);
                    break;
                }

                current = current.left;
            }
        }

        current = new Node(value);
    }
}