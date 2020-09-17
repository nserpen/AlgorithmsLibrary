// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using AlgorithmsLibrary.BinaryTrees;
using NUnit.Framework;

namespace AlgorithmsLibraryTests.BinaryTrees
{
    public class BinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateBT()
        {
            var array = new int[] { 3, 2, 5, 1, 4, 7 };

            var tree = Node<int>.ConstuctBT(array);

            Assert.AreEqual(tree.Right.Right.Data, 7);
        }
    }
}
