using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklylineProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var watch = new System.Diagnostics.Stopwatch();
            Random rd = new Random();


            int[] A = new int[n];
            Console.Write("Given Array A :");

            for (int i = 0; i < n; i++)
            {
                A[i] = rd.Next(0, 8);

                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            watch.Start();
            Console.WriteLine("Total bush strokes for Array A: " + (solution(A, n)).ToString());
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadLine();

        }
        public static int solution(int[] A, int N)
        {
            int bushstrokes = 0;
            int a = A.Max();
            for (int i = 0; i < a; i++)
            {
                int iter = 0;
                while (iter < N)
                {
                    if (A[iter] < i + 1)
                        if (iter != 0 && A[iter - 1] >= i + 1)
                        {
                            bushstrokes++;
                            iter++;
                            continue;
                        }
                    iter++;
                }
                if (A[iter - 1] >= i + 1)
                    bushstrokes++;
            }
            return bushstrokes;
        }


    }
}
