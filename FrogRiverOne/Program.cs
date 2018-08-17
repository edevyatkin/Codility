using System;

// https://app.codility.com/demo/results/training8KKNVD-GAV/

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] A = { 1,3,1,4,2,3,5,4 };

            var s = new Solution();
            int result = s.solution(X, A);
            Console.WriteLine("result: " + result);
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            if (A.Length < X)
                return -1;
            if (X == 1 && A.Length == X)
                return 0;

            var arr = new int[X];
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (arr[A[i]-1] == 0)
                {
                    count++;
                    if (count == X)
                        return i;
                }
                arr[A[i] - 1]++;
            }

            return -1;
        }
    }
}
