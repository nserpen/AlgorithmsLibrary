// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
namespace AlgorithmsLibrary.BinaryTrees
{
    public class Node<T> where T: IComparable<T>, IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        // first item is root
        public static Node<T> ConstuctBT(T[] fromArray)
        {
            if (fromArray.Length < 1)
                throw new ArgumentOutOfRangeException(nameof(fromArray), "Length of the array must be greater than zero!");

            static Node<T> insert(Node<T> root, T data)
            {
                if (root == null)
                {
                    return new Node<T>(data);
                }
                else
                {
                    Node<T> cur;
                    if (data.CompareTo(root.Data) <= 0)
                    {
                        cur = insert(root.Left, data);
                        root.Left = cur;
                    }
                    else
                    {
                        cur = insert(root.Right, data);
                        root.Right = cur;
                    }
                    return root;
                }
            }

            Node<T> root = null;
            for (int i = 0; i < fromArray.Length; i++)
            {
                root = insert(root, fromArray[i]);
            }

            return root;
        }
    }
}
