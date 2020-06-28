using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class TreeSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var count = 0;
            TreeNode<T> root = null;

            for (var i = 0; i < items.Length; i++)
            {
                var node = new TreeNode<T>(items[i], i);

                Add(items, sortOperator, node, ref count, ref root);
            }

            T[] ordered = Inorder(ref count, ref root);

            for (var i = 0; i < ordered.Length; i++)
            {
                sortOperator.Set(items, ordered[i], i);
            }
        }

        private static void Add(T[] items, ISortOperator<T> sortOperator, TreeNode<T> node, ref int count, ref TreeNode<T> root)
        {
            if (root == null)
            {
                root = node;
                count++;
                return;
            }

            AddNode(items, sortOperator, node, ref root);

            count++;
        }

        private static void AddNode(T[] items, ISortOperator<T> sortOperator, TreeNode<T> node, ref TreeNode<T> root)
        {
            var currentNode = root;

            while (currentNode != null)
            {
                if (sortOperator.Compare(items, node.Index, currentNode.Index) == -1)
                {
                    if (currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        currentNode.Left = node;
                        currentNode = null;
                    }
                }
                else
                {
                    if (currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                    }
                    else
                    {
                        currentNode.Right = node;
                        currentNode = null;
                    }
                }
            }
        }

        private static T[] Inorder(ref int count, ref TreeNode<T> root)
        {
            var stack = new Stack<TreeNode<T>>();
            var node = root;
            var array = new T[count];
            var index = 0;

            while (node != null || stack.Count > 0)
            {
                if (stack.Count > 0)
                {
                    node = stack.Pop();
                    array[index++] = node.Item;
                    node = node.Right;
                }

                while (node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }
            }

            return array;
        }

        private class TreeNode<X> where X : IComparable
        {
            public TreeNode(X item, int index)
            {
                Item = item;
                Index = index;
            }

            public X Item { get; }
            public int Index { get; }
            public TreeNode<X> Left { get; set; }
            public TreeNode<X> Right { get; set; }
        }
    }
}