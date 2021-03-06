﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF_QuickFound
{
    class Program
    {
        static void Union(int[] set, int p, int q)
        {
            int pRoot = set[p];
            int qRoot = set[q];
            for (int i = 0; i < set.Length; i++)
            {
                if(set[i] == pRoot)
                {
                    set[i] = qRoot;
                }
            }
        }

        static bool Find(int[] set, int p, int q)
        {
            return set[p] == set[q];
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Union Find 's Quick find version\n");
            Console.WriteLine("\nPlease enter the numbers in the space separated format\n");
            int n = int.Parse(Console.ReadLine());
            int[] set = new int[n];

            for (int i = 0; i < n; i++)
            {
                set[i] = i;
            }
            bool isConnected = false;
            int[] command;

            do
            {
                Console.WriteLine("\nPlease enter the command in the following format\n \"Choice p q\"");
                command = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (command[0] == 1)
                {
                    Union(set, command[1], command[2]);
                }
                else if (command[0] == 2)
                {
                    isConnected = Find(set, command[1], command[2]);
                    if (isConnected)
                    {
                        Console.WriteLine("Connected");
                    }else
                    {
                        Console.WriteLine("Not Connected");
                    }
                }
                PrintArray(set);
                
            } while (command[0] != 0);
        }
    }
}
