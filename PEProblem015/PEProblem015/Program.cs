using System;
/*
 * Starting in the top left corner of a 2×2 grid, 
 * and only being able to move to the right and down, 
 * there are exactly 6 routes to the bottom right corner.
 * 
 * How many such routes are there through a 20×20 grid?
*/
namespace PEProblem015
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;
            
            ulong[][] result = new ulong[21][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new ulong[21];
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[20][i] = 1ul;
                result[i][20] = 1ul;
            }

            for (int i = result.Length - 2; i > -1; i--)
            {
                for (int j = result.Length - 2; j > -1; j--)
                {
                    result[i][j] = result[i][j + 1] + result[i + 1][j];
                }
            }
            
            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result[0][0].ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
