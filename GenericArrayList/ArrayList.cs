using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericArrayList
{
    class ArrayList<T> : IEnumerable<T>
    {
        private T[] Items { get; set; }
        public int Count { get; set; }
        public int MAX_SIZE;
        public ArrayList()
        {
            Items = new T[2];
            MAX_SIZE = 2;
            Count = 0;
        }
        public ArrayList(int size)
        {
            Items = new T[size];
            MAX_SIZE = size;
            Count = 0;
        }



        private void ResizeArray(int newSize)
        {
            MAX_SIZE = newSize;
            T[] newItems = new T[MAX_SIZE];

            for (int i = 0; i < Count; i++)
            {
                newItems[i] = Items[i];
            }
            Items = newItems;
        }

        public void Add(T data)
        {
            if (Count == MAX_SIZE)
                ResizeArray(MAX_SIZE * 2);
            Items[Count++] = data;
        }

        public T Get(int i)
        {
            if (i < Count)
                return Items[i];
            else
                return default(T);
        }

        public bool Remove(T data)
        {
            bool status = false;
            int i;
            for (i = 0; i < Count; i++)
            {
                if(data.Equals(Items[i]))
                {
                    status = true;
                    while (i < Count - 1)
                    {
                        Items[i] = Items[i + 1];
                        i++;
                    }
                    Count--;
                    break;
                }
            }
            if (Count >= 2 && Count <= (MAX_SIZE / 4))
            {
                ResizeArray(MAX_SIZE / 2);
            }
            return status;
        }

        public void PrintAll()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(Items[i] + " ");
            }
            Console.WriteLine("\nMax Length is = " + MAX_SIZE);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
               yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
