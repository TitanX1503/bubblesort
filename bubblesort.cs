using System;

namespace Programacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
        public static int[] testNumbers = new int[]{13, 65, 2, 78, 45};

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];

            arr[i] = arr[j];

            arr[j] = temp;
        }

        static void BubbleSort(int[] numbers)
        {
            //Código del Bubble Sort
            //[13, 65, 2, 78, 45]
            //13 vs 65
            //[0] vs [1]
            //[1] vs [2]
            //[2] vs [3]
            //[3] vs [4]

            //4 => tamaño del arreglo - 1
            //4 => i < tamaño del arreglo

            //Pasadas de Bubble Sort
            //0 -> 4
            //0 -> 3
            //0 -> 2
            //0 -> 1

            

            //For de las "pasadas"
            //for va del 4 al 1
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                //i es el número hasta donde vamos a revisar en
                // la "pasada" actual

                //for va del 0 al 3 (* aplica para la primer pasada)
                //For de la comparativa entre pares
                for (int j = 0; j < i; j++)
                {
                    //j es el índice de la izquierda (abajo en el
                    // dibujo del pizarrón)
                    //j + 1 es el índice de la derecha

                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(numbers, j, j + 1);
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);    
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Antes de ordenar:");
            PrintArray(testNumbers);
            BubbleSort(testNumbers);
            System.Console.WriteLine("Después de ordenar:");
            PrintArray(testNumbers);


        }
    }
}

