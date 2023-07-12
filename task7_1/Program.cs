// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Create2DArray(int rows, int cols)
{
    int[,] array2D = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 10);
        }
    }
    return array2D;
}

void ShowArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            System.Console.Write($"{arr2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int number = Convert.ToInt32(inputedString);
    return number;
}

// bool VerificatePositiv(int n, int m)
// {
// if( n > 0 && m > 0) return true;
// System.Console.WriteLine("Вы ввели отрицательные числа или 0");
// return false;
// }

int[,] array2D = Create2DArray(4, 4);
ShowArray(array2D);
int n = ReadInt("Введите номер строки >");
int m = ReadInt("Введите номер столбца >");
//VerificatePositiv(n, m);
Fn(array2D, n, m);

void Fn(int[,] array2D, int n, int m)
{
if(n <= array2D.GetLength(0) && n > 0 || m <= array2D.GetLength(1) && m > 0)
{
    System.Console.WriteLine($"элемент в строке {n} столбце {m} = {array2D[n-1,m-1]}");
}
else 
{
    System.Console.WriteLine("В массиве нет такого элемента");
}
}

