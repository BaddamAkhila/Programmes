using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                /* //array declaration
                int[] arr = new int[6] ;
                Console.WriteLine("enter array elements");
                for (int i= 0;i< arr.Length;i++)
                {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                 }

                //linq methods
                //Console.WriteLine( arr.Max());

                //array methods
                //Array.Sort(arr);
                foreach (int i in arr)
                {
                Console.WriteLine(i);
                }
                }*/

                //two dimensional array

                int[,] arr2d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                for (int i = 0; i < arr2d.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                    {
                        Console.Write("\t{0}", arr2d[i, j]);
                    }
                    Console.WriteLine("\n");
                }

            }
        }
    }
}

   