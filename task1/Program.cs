
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Random rnd = new Random();
Console.Write("Введите размерность m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];


void randomArray(double[, ] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
    array[i,j] = rnd.NextDouble();
    Console.Write($"{array[i,j]:F2} "); 
    }
    Console.WriteLine(); 
}
}

Console.WriteLine(); 

randomArray(array);

