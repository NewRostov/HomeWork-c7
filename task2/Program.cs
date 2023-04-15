//Задача 50. Напишите программу, которая на вход принимает значение элемента 
//в двумерном массиве, и возвращает позицию этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//if (array[i,j] == num) 
    //{
   //     Console.WriteLine("Строка: " + i + ", " + "Столбец: " + j); 
   // }

Random rnd = new Random();
Random rand = new Random();
Console.Write("Введите размерность m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение элемента:  ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i,j] = rnd.Next(1,4);
    if (array[i,j] == num) Console.WriteLine("Элемент " + num + " найден, строка: " + i + ", " + "Столбец: " + j); 
    
    else if  (array[i,j] != num) Console.WriteLine("Элемента не найден"); 
 
    }
}


