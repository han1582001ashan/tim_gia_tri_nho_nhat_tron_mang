using System;
namespace MinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input array size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Input your array: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            int index = minValue(array);
            Console.WriteLine("MIN is: "+ array[index]);

        }
        public static int minValue(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }


    }
}

