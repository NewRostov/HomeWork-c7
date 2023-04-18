//Задача 50. Напишите программу, которая на вход принимает значение элемента 
//в двумерном массиве, и возвращает позицию этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        Console.Write("Введите размерность m:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размерность n:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение элемента:  ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[,] arr1 = new int[m, n];

        void fillAray(int[,] arrayToFill)
        {
            for (int i = 0; i < arrayToFill.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFill.GetLength(1); j++)
                {
                    {
                        arr1[i, j] = new Random().Next(1, 9);
                        Console.Write($"{arr1[i, j]} ");
                    }



                    // if (array[i,j] == num) Console.WriteLine("Элемент " + num + " найден, строка: " + i + ", " + "Столбец: " + j); 

                    // else if  (array[i,j] != num) Console.WriteLine("Элемента не найден"); 

                }

                Console.WriteLine();
            }
        }


        // вычесляем элемент

        void elementArr(int[,] arr, int num)
        {
            bool find = false;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] == num) Console.WriteLine("Элемент " + num + " найден: строка: " + (i + 1) + ", " + "Столбец: " + (j + 1));
                    find = true;

                }
            }
            if (!find) Console.WriteLine("Элемента не найден");
        }

        fillAray(arr1);

        elementArr(arr1, num);
    }
}