using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class Queue<T>
    {
        T[] Data;

        int Capacity;
        public int Count;
        int HeadPointer;
        int TailPointer;

        public T Head
        {
            get
            {
                return Data[HeadPointer];
            }
        }
        public T Tail
        {
            get
            {
                return Data[TailPointer];
            }
        }
        public bool IsEmpty
        {
            get
            {
                return Count == 0 ? true : false;
            }
        }
        
        public void Enqueue(T item)
        {
            if(IsEmpty)
            {
                Data[++TailPointer] = item;
                HeadPointer++;
                Count++;
            }
            else
            {
                if (Count < Capacity && TailPointer == (Capacity - 1))
                {
                    Data[TailPointer = 0] = item;
                    Count++;
                }
                else
                {
                    Data[++TailPointer] = item;
                    Count++;
                }
            }
            Resize();
        }
        public void Dequeue()
        {
            if(!IsEmpty)
            {
                if (HeadPointer == TailPointer)
                {
                    HeadPointer = -1;
                    TailPointer = -1;
                }
                else
                {
                    HeadPointer++;
                }
                Count--;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Clear()
        {
            Data = new T[Capacity = 5];
            Count = 0;
            HeadPointer = -1;
            TailPointer = -1;
        }
        public void Print()
        {
            int head = HeadPointer;
            int tail = 0;

            for (int i = 0; i < Count; i++)
            {
                if (head < Capacity)
                    Console.WriteLine(Data[head++]);
                else if (tail <= TailPointer)
                    Console.WriteLine(Data[tail++]);
            }
        }
        public T Peek()
        {
            return Data[HeadPointer];
        }
        public void Resize()
        {
            if(Count == Capacity)
            {
                T[] tempArray = new T[Capacity *= 2];

                int head = HeadPointer;
                int tail = 0;

                for (int i = 0; i < Count; i++)
                {
                    if (head < Capacity)
                        tempArray[i] = Data[head++];
                    else if (tail <= TailPointer)
                        tempArray[i] = Data[tail++];
                }
                Data = tempArray;
                HeadPointer = 0;
                TailPointer = Count - 1;
            }
        }

        public Queue(int capacity = 5)
        {
            Capacity = capacity;
            Data = new T[Capacity];
            Count = 0;
            HeadPointer = -1;
            TailPointer = -1;
        }
    }
}
