using System;

namespace Lesson_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 8, 9, 7, 6 };
            int k = 3;
            Dump(arr);
            int[] result = new Solution().solution(arr, k);
            Dump(result);
        }

        private static void Dump(int[] result)
        {
            Console.WriteLine(string.Join(' ', result));
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
                return A;

            int shift = K % A.Length;
            int i = A.Length - shift;

            int[] result = new int[A.Length];

            Array.Copy(A, i, result, 0, shift);
            Array.Copy(A, 0, result, shift, i);

            return result;
        }
    }
}
