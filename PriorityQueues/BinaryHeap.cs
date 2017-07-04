using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueues
{
    class BinaryHeap
    {
        int[] heap;
        int Count;
        public BinaryHeap(int size)
        {
            heap = new int[size + 1];
            Count = 0;
        }

        public int ReadMax()
        {
            return heap[1];
        }

        public bool IsEmpty()
        {
            if (Count == 0)
                return true;
            return false;
        }

        public void Insert(int d)
        {
            heap[++Count] = d;
            Swim(Count);
        }

        private void swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }

        private void Swim(int i)
        {
            while(i > 1 && heap[i] > heap[i / 2]) {
                swap(ref heap[i], ref heap[i / 2]);
                i = i / 2;
            }
        }

        public int DeleteMax()
        {
            if (IsEmpty())
                return 0;
            int max = heap[1];
            swap(ref heap[1], ref heap[Count]);
            Count--;
            Sink(1);
            return max;
        }

        private void Sink(int i)
        {
            while (2 * i < Count)
            {
                int j = 2 * i;
                if (heap[j] < heap[j + 1])
                    j++;
                if (heap[i] >= heap[j])
                    break;
                swap(ref heap[j], ref heap[i]);
                i = j;
            }
        }

   
    }
}
