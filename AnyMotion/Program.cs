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
            Ausgabe(array);

            int[] array1 = { 1, 2, 3, 9 };
            Ausgabe(array1);

            int[] array2 = { 9 };
            Ausgabe(array2);

            int[] array3 = { 9, 9 };
            Ausgabe(array3);

            int[] array4 = { 9, 9, 9 };
            Ausgabe(array4);

            int[] array5 = { 9, 9, 9, 9, 9 };
            Ausgabe(array5);

        }
        private static void Ausgabe(int[] array)
        {
            PrintArray(array);
            Console.WriteLine();
            AddOne(array);

            if (array[0] == 0)
            {
                Array.Resize<int>(ref array, array.Length + 1);
                array[0] = 1;
            }

            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }

        private static void PrintArray(int[] array) => Console.WriteLine(string.Join(" ", array));

        private static void AddOne(int[] array)
        {

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 9)
                {
                    array[i] = 0;
                }
                else
                {
                    array[i] += 1;
                    break;
                }
            }
        }
    }
}
