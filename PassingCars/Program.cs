using System;

// https://app.codility.com/demo/results/trainingDXJPHW-NKF/

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] A = { 0, 1, 0, 1, 1 };

            var s = new Solution();
            int result = s.solution(A, N);
            Console.WriteLine("result: " +  result);
        }
    }

    class Solution
    {
        public int solution(int[] A, int N)
        {
            int zeroes = 0;
            int ones = 0;
            int count = 0;
            bool inPairs = false;
            const int MAX = 1000000000;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    if (inPairs == true)
                    {
                        count += zeroes * ones;
                        if (count > MAX || count < 0) return -1;
                        ones = 0;
                    }
                    zeroes++;
                    inPairs = false;
                }
                else
                {
                    ones++;
                    inPairs = true;
                }
            }
            count += zeroes * ones;
            if (count > MAX || count < 0) return -1;
            return count;
        }
    }
}
