// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using AlgorithmsLibrary.LinkedLists;
using NUnit.Framework;

namespace AlgorithmsLibraryTests.LinkedLists
{
    public class LinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateStructure()
        {
            var array = new int[] { 1, 2, 2, 3, 3, 4 };
            Node<int> head = null;
            for (int i = 0; i < array.Length; i++)
            {
                head = Node<int>.Insert(head, array[i]);
            }

            Assert.AreEqual(head.Data, 1);
            var cnt = Node<int>.Count(head);
            Assert.AreEqual(cnt, 6);

            head = Node<int>.RemoveDuplicatesOfNonDecreasingList(head);
            Node<int>.Display(head);
            cnt = Node<int>.Count(head);
            Assert.AreEqual(cnt, 4);
            var str = Node<int>.ToString(head);
            Assert.AreEqual("1 2 3 4", str);
        }
    }
}
