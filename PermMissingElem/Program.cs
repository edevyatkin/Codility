using System;

// https://app.codility.com/demo/results/trainingZSANGQ-ZE3/

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 3, 1, 5 };
            var s = new Solution();
            int result = s.solution(A);
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            int result = 0;

            for (int i = 1; i <= A.Length; i++)
            {
                result = result + i - A[i - 1];
            }

            return result + A.Length + 1;
        }
    }
}
