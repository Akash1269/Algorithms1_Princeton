using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF_WeightedQuickUnion
{
    class UnionFind
    {
        public int[] Set { get; set; }
        public int[] Size { get; set; }

        public UnionFind(int n)
        {
            Set = new int[n];
            Size = new int[n];
            for (int i = 0; i < n; i++)
            {
                Set[i] = i;
                Size[i] = 1;
            }
        }

        int Root(int i)
        {
            int j = i;
            while (Set[i] != i)
            {
                //To add Path compression with single pass which halves the route to node 
                Set[i] = Set[Set[i]];

                i = Set[i];
            }
            // To add repeated path compression which sets all the nodes along the path to root
            // this reduces down efficiency to almost constant = log* n
            while (Set[j] != i)
            {
                j = Set[j];
                Set[j] = i;
            }
            return i;
        }

        public void Union(int p, int q)
        {
            if (Find(p, q) == true)
                return;
            int pRoot = Root(p);
            int qRoot = Root(q);
            if(Size[pRoot] < Size[qRoot])
            {
                Set[pRoot] = qRoot;
                Size[qRoot] += Size[pRoot];
            }
            else
            {
                Set[qRoot] = pRoot;
                Size[pRoot] += Size[qRoot];
            }
        }

        public bool Find(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void PrintSet()
        {
            Console.WriteLine(string.Join(" ", Set));
        }
    }
}
