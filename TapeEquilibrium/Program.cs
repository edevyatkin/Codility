using System;
using System.Linq;

// https://app.codility.com/demo/results/training58WVXF-8A8/

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10,6,12,37,29 };
          
            var s = new Solution();
            int result = s.solution(A);
            Console.WriteLine("result: " + result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 2)
                return Math.Abs(A[0] - A[1]);

            var part1 = A[0];
            var part2 = A.Skip(1).Sum();
            int diff = Math.Abs(part1 - part2); ;
            int mindiff = diff;

            for (int i = 1; i < A.Length-1; i++)
            {
                part1 += A[i];
                part2 -= A[i];
                diff = Math.Abs(part1 - part2); ;
                if (diff < mindiff)
                    mindiff = diff;
            }

            return mindiff;
        }
    }
}
