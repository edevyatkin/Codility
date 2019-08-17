using System;

namespace GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "CAGCCTA";
            int[] P = { 2, 5, 0 };
            int[] Q = { 4, 5, 6 };

            var sln = new Solution();
            int[] result = sln.solution(S, P, Q);
            Console.WriteLine("result: " + string.Join(' ', result));
        }
    }

    class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];

            return result;
        }
    }
}
