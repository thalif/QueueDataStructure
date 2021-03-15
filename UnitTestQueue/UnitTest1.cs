using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomQueue;

namespace UnitTestQueue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Count_After_DeQ()
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            myQ.Enqueue(40);
            myQ.Enqueue(50);
            myQ.Dequeue();
            myQ.Dequeue();
            myQ.Dequeue();
            myQ.Dequeue();
            myQ.Dequeue();
            Assert.AreEqual(0, myQ.Count);
        }

        [TestMethod]
        public void HeadAndTail()
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(10);
            Assert.AreEqual(10, myQ.Head);
            Assert.AreEqual(10,myQ.Tail);
        }
        [TestMethod]
        public void EmptyDeQ()
        {
            Queue<int> myQ = new Queue<int>();
            Assert.ThrowsException<InvalidOperationException>(() => myQ.Dequeue());
        }

        [TestMethod]
        public void ClearQueue()
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            myQ.Clear();
            Assert.AreEqual(0, myQ.Count);
        }

        [TestMethod]
        public void Peek()
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            Assert.AreEqual(10, myQ.Peek());
        }

        [TestMethod]
        public void IsEmptyFalse()
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(10);
            Assert.AreEqual(false, myQ.IsEmpty);
        }
        [TestMethod]
        public void IsEmptyTrue()
        {
            Queue<int> myQ = new Queue<int>();
            Assert.AreEqual(true, myQ.IsEmpty);
        }
    }
}
