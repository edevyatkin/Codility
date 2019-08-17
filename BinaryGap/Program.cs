using System;
using System.Linq;

// https://app.codility.com/demo/results/trainingDP3K3Z-J2D/

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] examples = { 1041, 15, 32, 1162, 561892, 1376796946 };
            Solution s = new Solution();
            Func<int, int> func = x => s.solution(x);
            foreach (int i in examples)
            {
                Console.WriteLine($"{i}, max gap:{func(i)}");
            }
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            if (N < 5)
                return 0;

            int maxGap = 0;
            int gap = 0;
            int rem = 0;
            bool edgeGap = false;

            while (N != 1)
            {
                rem = N % 2;
                N = N / 2;

                if (rem == 1)
                {
                    edgeGap = true;
                }
                if (edgeGap == true)
                {
                    if (rem == 1)
                    {
                        if (gap > maxGap)
                            maxGap = gap;
                        gap = 0;
                    }
                    else
                    {
                        gap++;
                    }
                }
            }

            return (gap > maxGap) ? gap : maxGap;
        }
    }
}
