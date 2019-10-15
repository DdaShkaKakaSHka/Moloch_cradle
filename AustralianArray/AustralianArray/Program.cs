using System;

namespace Australian_Array
{
        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Please put any number");
                    string param = Console.ReadLine();
                    int.TryParse(param, out int t);
                    int[] arr = new int[t];
                    Console.WriteLine("Original Array");
                    for (int i = 0; i < t; i++)
                    {
                        arr[i] = i + 1;
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Reversed Array");
                    GetReverse(arr);
                    Console.WriteLine();
                }
            }

            static void GetReverse(int[] arr)
            {
                for (int x = 0, y = arr.Length - 1; arr.Length % 2 == 1 ? x < arr.Length / 2 && y > arr.Length / 2 : x < arr.Length / 2 && y >= arr.Length / 2; x++, y--)
                {

                    int temp = arr[x];
                    arr[x] = arr[y];
                    arr[y] = temp;
                }
                foreach (int a in arr)
                {
                    Console.Write(a + " ");
                }
            }
        }
}
