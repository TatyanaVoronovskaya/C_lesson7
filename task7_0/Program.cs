// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int number = Convert.ToInt32(inputedString);
    return number;
}


double[,] GetArrayDouble(int rows, int cols)
{
    double[,] array2D = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            int number = new Random().Next(-100, 100);
            array2D[i, j] = rand.NextDouble() * number;
        }
    }
    return array2D;
}


void ShowArray(double[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            System.Console.Write($"{arr2D[i, j]:f2} ");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк >");
int cols = ReadInt("Введите количество столбцов >");
double[,] array2D = GetArrayDouble(rows, cols);
ShowArray(array2D);

