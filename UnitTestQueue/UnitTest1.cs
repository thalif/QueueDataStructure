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
            Queue myQ = new Queue();
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
            Queue myQ = new Queue();
            myQ.Enqueue(10);
            Assert.AreEqual(10, myQ.Head);
            Assert.AreEqual(10,myQ.Tail);
        }
        [TestMethod]
        public void EmptyDeQ()
        {
            Queue myQ = new Queue();
            Assert.ThrowsException<InvalidOperationException>(() => myQ.Dequeue());
        }

        [TestMethod]
        public void ClearQueue()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            myQ.Clear();
            Assert.AreEqual(0, myQ.Count);
        }

        [TestMethod]
        public void Peek()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            Assert.AreEqual(10, myQ.Peek());
        }

        [TestMethod]
        public void IsEmptyFalse()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(10);
            Assert.AreEqual(false, myQ.IsEmpty);
        }
        [TestMethod]
        public void IsEmptyTrue()
        {
            Queue myQ = new Queue();
            Assert.AreEqual(true, myQ.IsEmpty);
        }
    }
}
