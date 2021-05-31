using System;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ar = new long[5] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long result = aVeryBigSum(ar);
            System.Console.WriteLine(result);

        }

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long total = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                total += ar[i];
            }
            return total;

        }
    }
}
