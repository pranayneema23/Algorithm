using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;

        public Node(T data)
        {
            this.data = data;
        }
    }

    public class TreeTraversalAlgo<T>
    {
        public static void preOrderTraverse(Node<T> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.data + " ");
            preOrderTraverse(node.left);
            preOrderTraverse(node.right);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // We create the nodes of our tree
            Node<String> A = new Node<String>("A");
            Node<String> B = new Node<String>("B");
            Node<String> C = new Node<String>("C");
            Node<String> D = new Node<String>("D");
            Node<String> E = new Node<String>("E");
            Node<String> F = new Node<String>("F");
            Node<String> G = new Node<String>("G");
            Node<String> H = new Node<String>("H");
            Node<String> I = new Node<String>("I");
            Node<String> J = new Node<String>("J");
            Node<String> K = new Node<String>("K");

            // Root and building of the tree
            Node<String> root = A;
            A.left = B;
            A.right = C;
            B.left = D;
            B.right = E;
            D.left = H;
            D.right = I;
            E.left = J;
            C.left = F;
            C.right = G;
            G.left = K;

            TreeTraversalAlgo<string>.preOrderTraverse(root);
            Console.Read();

        }
    }
}
