using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWelcome to Resizable Generic Array List\n");
            Console.WriteLine("\nPlease enter the numbers in the space separated format\n");
            int[] myList = readIntArray();

            /*
            Console.WriteLine("Please enter the value of k for kth largest element\n");
            int k = readInt();
            Console.WriteLine("Kth Largest Element is" + AdvancedSort.QuickSelect(myList, k));

            Console.WriteLine("\nQuick Select\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }
            */

            AdvancedSort.HeapSort(myList);

            Console.WriteLine("\nHeap Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            AdvancedSort.ThreeWayQuickSort(myList);

            Console.WriteLine("\nThree Way Quick Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }


            AdvancedSort.QuickSort(myList);

            Console.WriteLine("\nQuick Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            AdvancedSort.BUMergeSort(myList);

            Console.WriteLine("\nBottom Up Merge Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            AdvancedSort.MergeSort(myList);

            Console.WriteLine("\nMerge Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            Sort.ShellSort(myList);

            Console.WriteLine("\nShell Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }
            
            Sort.InsertionSort(myList);

            Console.WriteLine("\nInsertion Sort\n");

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nSelection Sort\n");

            Sort.SelectionSort(myList);

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nBubble Sort\n");

            Sort.BubbleSort(myList);

            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

        }

        static string read() { return Console.ReadLine().Trim(); }
        static int readInt() { return int.Parse(read()); }
        static int[] readIntArray() { return Array.ConvertAll(readArray(), int.Parse); }
        static string[] readArray() { return read().Split(' '); }
    }
}
