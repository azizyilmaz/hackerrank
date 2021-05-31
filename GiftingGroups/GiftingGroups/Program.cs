using System;
using System.Collections.Generic;

namespace GiftingGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> related = new List<string>();
            countGroups(related);
        }

        private static void countGroups(List<string> related)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (related[i][j] == 1)
                    {
                        
                    }
                }
            }
        }
    }
}
