using System;

namespace BubbleSort
{
    class BubbleSortTest
    {
        public static Random generator = new Random();
        public static int[] data = new int[10];

        static void Main(string[] args)
        {
            //var generator = new Random();
            //var data = new int[10];

            for (var i = 0; i < data.Length; ++i)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine("Unsorted array");
            Console.WriteLine(string.Join(" ", data) + "\n");

            BubbleSort(data);

            Console.WriteLine("Sorted array");
            Console.WriteLine(string.Join(" ", data) + "\n");
        }

        // Sort array
        public static void BubbleSort(int[] values)
        {
            for (var i = 0; i < data.Length - 1; i++)
            {
                for (var c = i + 1; c < data.Length; c++)
                {
                    if (data[c] < data[i])
                    {
                        var temp = data[i];
                        data[i] = data[c];
                        data[c] = temp;
                    }
                }
            }
        }


    }
}
