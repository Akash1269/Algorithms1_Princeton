using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> myList = new ArrayList<int>();
            int[] command;

            Console.WriteLine("\nWelcome to Resizable Generic Array List\n");
            Console.WriteLine("\nPlease enter the numbers in the space separated format\n");
            int[] arr = readIntArray();

            bool status = false;

            foreach (int item in arr)
            {
                myList.Add(item);
            }
            do
            {
                Console.WriteLine("\nPlease enter the command in the following format Choice parameters\n");
                command = readIntArray();

                if (command[0] == 1)
                {
                    myList.Add(command[1]);
                }
                else if (command[0] == 2)
                {
                    status = myList.Remove(command[1]);
                    if (status)
                    {
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }
                }
                foreach (int item in myList)
                {
                    Console.Write(item + " ");
                }
            } while (command[0] != 0);

        }

        static string read() { return Console.ReadLine().Trim(); }
        static int readInt() { return int.Parse(read()); }
        static int[] readIntArray() { return Array.ConvertAll(readArray(), int.Parse); }
        static string[] readArray() { return read().Split(' '); }
    }
}
