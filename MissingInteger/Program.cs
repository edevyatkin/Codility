using System;

// https://app.codility.com/demo/results/trainingDS3T5X-V9B/

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 4, 4, 6, 1, 4, 4 };

            var s = new Solution();
            int result = s.solution(A);
            Console.WriteLine("result: " +  result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int[] intCounts = new int[100000];

            for (int i = 0; i < A.Length; i++)
                if (A[i] >= 1 && A[i] <= 100000)
                    intCounts[A[i] - 1]++;

            for (int j = 0; j < intCounts.Length; j++)
                if (intCounts[j] == 0)
                    return j + 1;

            return 100001;
        }
    }
}
