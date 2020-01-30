using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOneProblem
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };

            PrintArray(array);
            Console.WriteLine($"Länge: {array.Length}");
            Console.WriteLine();
            int[] newArray = AddOne(array);
            PrintArray(newArray);
            Console.WriteLine($"Länge: {newArray.Length}");
            Console.ReadKey();

        }

        private static void PrintArray(int[] array) => Console.WriteLine(string.Join(" ", array));


        private static int[] AddOne(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 9)
                {
                    array[i] = array[i] + 1;
                    break;
                }
                else
                {
                    array[i] = 0;
                    array[i - 1] = array[i - 1] + 1;
                    if (array[i - 1] > 9)
                    {
                        array[i - 1] = 0;
                        array[i - 2] = array[i - 2] + 1;
                    }
                    break;
                }
            }
            if (array[0] > 9)
            {
                Array.Resize(ref array, array.Length + 1);
                array[0] = 1;
            }
            return array;

        }
    }
}
