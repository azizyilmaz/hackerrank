using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>() {
                new List<int>{11, 2, 4},
                new List<int>{4, 5, 6},
                new List<int>{10, 8, -12}
            };

            int result = diagonalDifference(arr);
            System.Console.WriteLine(result);
        }

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int firstTotal = 0;
            int secondTotal = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                firstTotal += arr[i][i];
            }
            int k = 0;
            for (int j = arr.Count - 1; j >= 0; j--)
            {
                secondTotal += arr[k][j];
                k++;
            }
            int result = firstTotal - secondTotal;
            return result < 0 ? result * -1 : result;

        }
    }
}
