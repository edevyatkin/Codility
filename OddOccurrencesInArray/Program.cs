using System;

// https://app.codility.com/demo/results/trainingKDMG7H-ZNP/

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            var s = new Solution();
            int result = s.solution(A);
            Console.WriteLine(result);
        }
    }

    class Solution {
        public int solution(int[] A)
        {
            int result = 0;
            foreach (int i in A)
            {
                result = result ^ i;
            }
            return result;
        }
    }
}
