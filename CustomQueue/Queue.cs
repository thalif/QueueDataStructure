using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class Queue
    {
        int Capacity;
        int[] Data;
        int Count;
        int HeadPointer;
        int TailPointer;

        public int Head
        {
            get
            {
                return Data[HeadPointer];
            }
        }
        public int Tail
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
        
        public void Enqueue(int item)
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
                if(HeadPointer == TailPointer)
                {
                    Data[HeadPointer] = 0;
                    HeadPointer = -1;
                    TailPointer = -1;
                }
                else
                {
                    Data[HeadPointer] = 0;
                    HeadPointer++;
                }
                Count--;
            }
        }

        public void Clear()
        {
            Data = new int[Capacity = 5];
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
        public int Peek()
        {
            return Data[TailPointer];
        }
        public void Resize()
        {
            if(Count == Capacity)
            {
                int[] tempArray = new int[Capacity *= 2];

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
            Data = new int[Capacity];
            Count = 0;
            HeadPointer = -1;
            TailPointer = -1;
        }
    }
}
