using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp101219
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 5! = 5*4!
            ////int x = Factorial(10);
            ////Console.WriteLine(x);

            //int[] arr = new int[20];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i;
            //}

            //Console.WriteLine(arr);

            ////foreach (int item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////Array.Clear(arr, 0, arr.Length);

            //int[] arr2 = new int[40];

            ////Array.Copy(arr, arr2, 15);

            //arr.CopyTo(arr2, 5);

            ////foreach (int item in arr2)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //int[] arr3 = { 0, 7, 2, 6, 8, 3, 4, 7, 1, 3 };

            //Array.Sort(arr3);
            
            
            ////Console.WriteLine(Array.LastIndexOf(arr3,48));            
            //Console.WriteLine(Array.BinarySearch(arr3, 7));

            //Array.Resize(ref arr3, arr3.Length + 25);

            ////foreach (int item in arr3)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //int[,] arr2D = new int[5, 5];            

            //for (int i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2D.GetLength(1); j++)
            //    {
            //        arr2D[i, j] = i + j;
            //    }
            //}

            

            //foreach (int item in arr2D)
            //{
            //    Console.WriteLine(item);
            //}
            ////int sum = 0;
            ////for (int i = 0; i < length; i +=2)
            ////{
            ////    sum += 
            ////}

            Test6();

        }

        private static void Test6()
        {
            decimal[] input = new decimal[12];
            decimal[] output = new decimal[12];
            decimal[] delta = new decimal[12];
            decimal deltaSum = 0;
            int deltaPositive = 0;
            int maxDeltaMonthIndex = -1;
            int minDeltaMonthIndex = -1;

            Random r = new Random();

            for (int i = 0; i < 12; i++)
            {
                input[i] = (decimal)(r.NextDouble() * 1000 - 500);
                output[i] = (decimal)(r.NextDouble() * 1000 - 500);
                delta[i] = input[i] - output[i];
            }
            
            decimal minValue = Decimal.MaxValue;
            decimal maxValue = Decimal.MinValue;
            for (int i = 0; i < delta.Length; i++)
            {
                deltaSum += delta[i];

                if (delta[i] >= 0)
                {
                    deltaPositive++;
                }

                if (delta[i] < minValue)
                {
                    minValue = delta[i];
                    minDeltaMonthIndex = i;
                }

                if (delta[i] > maxValue)
                {
                    maxValue = delta[i];
                    maxDeltaMonthIndex = i;
                }              

            }
            maxDeltaMonthIndex++;
            minDeltaMonthIndex++;            

            Console.WriteLine(
                $"Max Delta Month {maxDeltaMonthIndex}\n" +
                $"Min Delta Month {minDeltaMonthIndex}\n" +
                $"Sum {deltaSum}\n" +
                $"Positive month {deltaPositive}");

        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new Exception("n must be not negative!");
            }

            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }


    }
}
