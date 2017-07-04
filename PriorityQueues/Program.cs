using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Heap based priority Queue\n");
            Console.WriteLine("Please enter the size of PQ\n");
            int size = readInt();
            BinaryHeap pq = new BinaryHeap(size);
            int[] command;
            do
            {
                Console.WriteLine("\nPlease enter the command in the following format Choice parameters\n");
                command = readIntArray();

                if (command[0] == 1)
                {
                    pq.Insert(command[1]);
                }
                else if (command[0] == 2)
                {
                    int max = pq.DeleteMax();
                    Console.WriteLine("Max is :" + max);
                }
            } while (command[0] != 0);
        }

        static string read() { return Console.ReadLine().Trim(); }
        static int readInt() { return int.Parse(read()); }
        static int[] readIntArray() { return Array.ConvertAll(readArray(), int.Parse); }
        static string[] readArray() { return read().Split(' '); }
    }
}
