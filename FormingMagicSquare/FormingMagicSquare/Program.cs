using System;
using System.Collections.Generic;

namespace FormingMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> s = new List<List<int>>();
            List<int> a = new List<int> { 4, 8, 2 };
            List<int> b = new List<int> { 4, 5, 7 };
            List<int> c = new List<int> { 6, 1, 6 };
            s.Add(a);
            s.Add(b);
            s.Add(c);
            int cost = FormingMagicSquare(s);
            Console.WriteLine(string.Format("Cost is {0}", cost));
        }

        static int FormingMagicSquare(List<List<int>> s)
        {
            int[,,] allMagics = new int[8, 3, 3]
            {
                { {8, 1, 6}, {3, 5, 7}, {4, 9, 2} },
                { {6, 1, 8}, {7, 5, 3}, {2, 9, 4} },
                { {4, 9, 2}, {3, 5, 7}, {8, 1, 6} },
                { {2, 9, 4}, {7, 5, 3}, {6, 1, 8} },
                { {8, 3, 4}, {1, 5, 9}, {6, 7, 2} },
                { {4, 3, 8}, {9, 5, 1}, {2, 7, 6} },
                { {6, 7, 2}, {1, 5, 9}, {8, 3, 4} },
                { {2, 7, 6}, {9, 5, 1}, {4, 3, 8} }
            };
            int minCost = 45;
            for (int k = 0; k < 8; k++)
            {
                int cost = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cost += Math.Abs(s[i][j] - allMagics[k, i, j]);
                    }
                }
                if (minCost > cost)
                    minCost = cost;
            }
            return minCost;
        }
    }
}