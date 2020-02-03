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
            Ausgabe(new int[] { 1, 2, 3, 4 });
            Ausgabe(new int[] { 1, 2, 3, 9 });
            Ausgabe(new int[] { 9 });
            Ausgabe(new int[] { 9, 9 });
            Ausgabe(new int[] { 9, 9, 9 });
            Ausgabe(new int[] { 9, 9, 9, 9, 9 });
        }
        private static void Ausgabe(int[] array)
        {
            PrintArray(array);
            Console.WriteLine();
            AddOne(ref array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }

        private static void PrintArray(int[] array) => Console.WriteLine(string.Join(" ", array));

        private static void AddOne(ref int[] array)
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
            if (array[0] == 0)
            {
                Array.Resize<int>(ref array, array.Length + 1);
                array[0] = 1;
            }
        }
    }
}
