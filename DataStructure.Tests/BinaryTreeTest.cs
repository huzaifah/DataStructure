using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Tests
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void GenerateBinaryTree()
        {
            var btree = new BinaryTree<int>();
            btree.Root = new Node<int>(1);
            btree.Root.Left = new Node<int>(2);
            btree.Root.Right = new Node<int>(3);

            btree.Root.Left.Left = new Node<int>(4);
            btree.Root.Right.Right = new Node<int>(5);

            btree.Root.Left.Left.Right = new Node<int>(6);
            btree.Root.Right.Right.Right = new Node<int>(7);

            btree.Root.Right.Right.Right.Right = new Node<int>(8);
        }
    }
}
