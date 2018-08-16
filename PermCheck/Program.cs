using System;

// https://app.codility.com/demo/results/training7SPU62-EZ9/

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4,1,3,2 };

            var s = new Solution();
            int result = s.solution(A);
            Console.WriteLine("result: " + result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 1 && A[0] == 1)
                return 1;

            var arr = new int[A.Length];
            foreach (var i in A)
            {
                if (i > A.Length)
                    return 0;
                arr[i - 1]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 1)
                    return 0;
            }

            return 1;
        }
    }
}
