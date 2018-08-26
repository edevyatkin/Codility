using System;

// https://app.codility.com/demo/results/trainingFRHNXA-6TG/

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] A = { 3,4,4,6,1,4,4 };

            var s = new Solution();
            int[] result = s.solution(N, A);
            Console.WriteLine("result: " + string.Join(",", result));
        }
    }

    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            if (N == 1)
            {
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == 2) continue;
                    count++;
                }
                return new[] { count };
            }

            int[] counters = new int[N];
            int maxCounterValue = 0;
            int overflowDiff = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (1 <= A[i] && A[i] <= N)
                {
                    if (counters[A[i] - 1] < overflowDiff)
                        counters[A[i] - 1] = overflowDiff;
                    int counterValue = ++counters[A[i] - 1];
                    if (counterValue > maxCounterValue)
                    {
                        maxCounterValue = counterValue;
                    }
                }
                if (A[i] == N + 1)
                {
                    overflowDiff = maxCounterValue;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (counters[i] < overflowDiff)
                    counters[i] = overflowDiff;
            }

            return counters;
        }
    }
}
