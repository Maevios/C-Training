using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {1,2,3 };
            jaggedArray[1] = new int[] {4,5,6,7 };
            jaggedArray[2] = new int[] {8,9};
            int[] sum = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int num1 = (i < jaggedArray[0].Length)? jaggedArray[0][i]: 0;
                int num2 = (i < jaggedArray[1].Length) ? jaggedArray[1][i] : 0;
                int num3 = (i < jaggedArray[2].Length) ? jaggedArray[2][i] : 0;
                int sumInt = num1 + num2 + num3;
                sum[i] = sumInt;

                Console.WriteLine(sum[i]);
            }
        }
    }
}
