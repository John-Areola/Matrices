using System;

namespace multiply3DimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDeeArray1 = new int[2, 2, 2]
            {
                {
                    { 2223, 4},
                    { 1, 2}

                },
                {
                    { 3, 6},
                    { 41, 7006}

                }
            };

            int[,,] threeDeeArray2 = new int[2, 2, 2]
            {
                {
                    { 2, 5678},
                    { 13, 123}
                },
                {
                    { 9, 0},
                    { 4, 9}
                }
            };

            int[,,] resultArray = new int[2, 2, 2];


            for (int i = 0; i < threeDeeArray1.GetLength(0); i++)
            {
                for (int j = 0; j < threeDeeArray1.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDeeArray1.GetLength(2); k++)
                    {
                        resultArray[i, j, k] += threeDeeArray1[i, j, k] * threeDeeArray2[i, j, k];
                    }
                }
            }

            foreach (int item in resultArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
