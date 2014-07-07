using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Struct
{
    public class BinaryTree<T>
    {
        
    }

    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }

        public BinaryTreeNode<T> Parent { get; set; }

        public BinaryTreeNode<T> LeftChild { get; set; }

        public BinaryTreeNode<T> RightChild { get; set; }

        public bool IsRoot { get; set; }

        public bool IsLeaf { get; set; }

        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> parent)
        {
            this.Value = value;
            this.Parent = parent;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> parent, BinaryTreeNode<T> leftChild, BinaryTreeNode<T> rightChild)
        {
            this.Value = value;
            this.Parent = parent;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
