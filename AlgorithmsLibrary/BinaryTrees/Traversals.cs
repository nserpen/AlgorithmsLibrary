// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary.BinaryTrees
{
    public static class Traversals
    {
        public static void InOrderTraversal<T>(Node<T> tree, ref List<T> store) where T : IComparable<T>, IComparable
        {
            /*
            An inorder traversal of tree is a recursive algorithm that follows the left subtree;
            once there are no more left subtrees to process, we process the right subtree.
            The elements are processed in left-root-right order.

            inOrder(t) {
                if(t is not empty) {
                    inOrder( left subtree of t )
                    process t's root element
                    inOrder( right subtree of t )
                } 
            } 
            */

            if (tree != null)
            {
                InOrderTraversal(tree.Left, ref store);
                store.Add(tree.Data);
                InOrderTraversal(tree.Right, ref store);
            }
        }

        public static void PostOrderTraversal<T>(Node<T> tree, ref List<T> store) where T : IComparable<T>, IComparable
        {
            /*
            A postorder traversal of tree is a recursive algorithm that follows the left and right subtrees before processing the root element.
            The elements are processed in left-right-root order.

            postOrder(t) {
                if(t is not empty) {
                    inOrder( left subtree of t )
                    process t's root element
                    inOrder( right subtree of t )
                } 
            } 
            */

            if (tree != null)
            {
                PostOrderTraversal(tree.Left, ref store);
                store.Add(tree.Data);
                PostOrderTraversal(tree.Right, ref store);
            }
        }

        public static void PreOrderTraversal<T>(Node<T> tree, ref List<T> store) where T : IComparable<T>, IComparable
        {
            /*
            A preorder traversal of tree is a recursive algorithm that processes the root and then
            performs preorder traversals of the left and right subtrees.
            The elements are processed root-left-right order. 

            preOrder(t) {
                if(t is not empty) {
                    process t's root element
                    inOrder( left subtree of t )
                    inOrder( right subtree of t )
                } 
            } 
            */

            if (tree != null)
            {
                PreOrderTraversal(tree.Left, ref store);
                store.Add(tree.Data);
                PreOrderTraversal(tree.Right, ref store);
            }
        }

        public static void LevelOrderTraversal<T>(Node<T> tree, out List<T> store) where T : IComparable<T>, IComparable
        {
            /*
            A level-order traversal of tree is a recursive algorithm that processes the root,
            followed by the children of the root (from left to right),
            followed by the grandchildren of the root (from left to right), etc.

            levelOrder(t) {
                if(t is not empty) {
                    // enqueue current root
                    queue.enqueue(t)
        
                    // while there are nodes to process
                    while( queue is not empty ) {
                        // dequeue next node
                        BinaryTree tree = queue.dequeue();
            
                        process tree's root;
            
                        // enqueue child elements from next level in order
                        if( tree has non-empty left subtree ) {
                            queue.enqueue( left subtree of t )
                        }
                        if( tree has non-empty right subtree ) {
                            queue.enqueue( right subtree of t )
                        }
                    }
                } 
            } 
            */

            var queue = new Queue<Node<T>>();
            store = new List<T>();

            if (tree != null)
            {
                queue.Enqueue(tree);

                while (queue.Count > 0)
                {
                    var t = queue.Dequeue();
                    store.Add(t.Data);

                    if (t.Left != null)
                        queue.Enqueue(t.Left);

                    if (t.Right != null)
                        queue.Enqueue(t.Right);
                }
            }
        }

    }
}
