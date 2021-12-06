using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _2021aoc6
{
    static class Metóduskiterjesztések
    {
        public static long[] Szaporít(this long[] t, int nap)
        {
            for (int n = 0; n < nap; n++)
            {
                long temp = t[0];
                for (int i = 1; i <= 8; i++)
                    t[i - 1] = t[i];
                t[8] = temp;
                t[6] += temp;
            }
            return t;
        }

        public static long[] Beszótáraz(this IEnumerable<int> collection)
        {
            long[] groupbycount = new long[9];
            foreach (int item in collection)
                groupbycount[item]++;
            return groupbycount;
        }
    }
    class Program
    {
        static void Main(string[] args) => Console.WriteLine(File.ReadAllText("input.txt").Split(',').Select(int.Parse).Beszótáraz().Szaporít(256).Sum());
    }
}
