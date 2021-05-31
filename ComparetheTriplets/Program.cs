using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparetheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(5);
            a.Add(6);
            a.Add(7);

            List<int> b = new List<int>();
            b.Add(3);
            b.Add(6);
            b.Add(10);

            List<int> result = compareTripletsX(a, b);

            Console.Write("{0}-{1}", result[0], result[1]);

        }

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int scoreA = 0;
            int scoreB = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    scoreA++;
                }
                else if (a[i] < b[i])
                {
                    scoreB++;
                }
            }
            return new List<int> { scoreA, scoreB };

        }

        static List<int> compareTripletsX(List<int> a, List<int> b)
        {
            var scoreA = 0;
            var scoreB = 0;
            var i = 0;
            a.ForEach(aliceScore =>
            {
                if (aliceScore > b.ElementAt(i))
                {
                    scoreA++;
                }
                else if (aliceScore < b.ElementAt(i))
                {
                    scoreB++;
                }
                i++;
            });
            return new List<int> { scoreA, scoreB };

        }
    }
}