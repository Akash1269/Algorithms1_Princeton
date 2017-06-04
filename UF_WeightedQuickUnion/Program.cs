using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF_WeightedQuickUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Union Find 's Quick find version\n");
            Console.WriteLine("\nPlease enter the numbers in the space separated format\n");
            int n = int.Parse(Console.ReadLine());

            UnionFind uf = new UnionFind(n);
            bool isConnected;
            int[] command;

            do
            {
                Console.WriteLine("\nPlease enter the command in the following format\n \"Choice p q\"");
                command = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (command[0] == 1)
                {
                    uf.Union(command[1], command[2]);
                }
                else if (command[0] == 2)
                {
                    isConnected = uf.Find(command[1], command[2]);
                    if (isConnected)
                    {
                        Console.WriteLine("Connected");
                    }
                    else
                    {
                        Console.WriteLine("Not Connected");
                    }
                }
                uf.PrintSet();
            } while (command[0] != 0);
        }
    }
}
