namespace BinarySearchTree
{
    public class BinarySearchHelper
    {
        public Node maxNode;

        public Node secondMaxNode;
        public Node GetMaxNode(Node node)
        {
            if (node == null)
            {
                return secondMaxNode;
            }

            if (node.value > maxNode.value)
            {
                secondMaxNode = maxNode;
                maxNode = new Node();
                maxNode.value = node.value;
                maxNode.Right = node.Right;
                maxNode.Left = node.Left;
            }

            //if (node.Right != null && node.Right.Right == null)
            //{
            //    return node.Right;
            //}

            var maxLeftNode = GetMaxNode(node.Left);
            var maxRightNode = GetMaxNode(node.Right);

            return maxLeftNode.value > maxRightNode.value ? maxRightNode : maxLeftNode;
        }

        // both max and second max on right 
        // max on right , second max on left
        // root is the second max
        // right subtree of root is null, then we have root as max and second max would be the left node of root       
    }
}
