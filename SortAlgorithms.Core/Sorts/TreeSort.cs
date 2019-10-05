using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class TreeSort<T> : SortBase<T> where T : IComparable
    {
        private TreeNode<T> _root;
        private int _count;
        public TreeSort() { }
        public TreeSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            _count = 0;
            _root = null;
            for (int i = 0; i < _array.Length; i++) Add(new TreeNode<T>(_array[i], i));
            T[] ordered = Inorder();
            for (int i = 0; i < ordered.Length; i++) Set(i, ordered[i]);
        }
        private void Add(TreeNode<T> node)
        {
            if (_root == null)
            {
                _root = node;
                _count++;
                return;
            }
            AddNode(node);
            _count++;
        }
        private void AddNode(TreeNode<T> node)
        {
            TreeNode<T> currentNode = _root;
            while (currentNode != null)
            {
                if (Compare(node.Index, currentNode.Index) == -1)
                {
                    if (currentNode.Left != null) currentNode = currentNode.Left;
                    else
                    {
                        currentNode.Left = node;
                        currentNode = null;
                    }
                }
                else
                {
                    if (currentNode.Right != null) currentNode = currentNode.Right;
                    else
                    {
                        currentNode.Right = node;
                        currentNode = null;
                    }
                }
            }
        }
        private T[] Inorder()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            TreeNode<T> node = _root;
            T[] array = new T[_count];
            int index = 0;
            while (node != null || stack.Count > 0)
            {
                if (stack.Count > 0)
                {
                    node = stack.Pop();
                    array[index++] = node.Item;
                    if (node.Right != null) node = node.Right; else node = null;
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
            public X Item;
            public TreeNode<X> Left, Right;
            public int Index;
            public TreeNode(X item, int index)
            {
                Item = item;
                Index = index;
            }
        }
    }
}
