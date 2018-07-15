using System;

// https://app.codility.com/demo/results/trainingWNATN7-Z8H/

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 85;
            int D = 30;

            var s = new Solution();
            int result = s.solution(X,Y,D);
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D) =>
            (int) Math.Ceiling((double)(Y - X) / D);
    }
}
