//  Задача 47: Задайте двумерный массив размером m×n,
//   заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


/*Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-(min+1));
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f3} ");
        }
        Console.WriteLine();
    }
}
*/

//  Задача 50: Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

Console.WriteLine("Введите значение позиций элементов в массиве: ");
Console.Write("Индекс строки: ");
int indexrow = int.Parse(Console.ReadLine());
Console.Write("Индекс столбца: ");
int indexcolumn = int.Parse(Console.ReadLine());

if (indexrow < 0 || indexrow > array.GetLength(0) - 1 && indexcolumn < 0 || indexcolumn > array.GetLength(1) - 1)
{
    Console.WriteLine($"Элемент отсуствует в массиве ->: {indexrow}{indexcolumn} ");
}
else
{
    Console.WriteLine($"{array[indexrow, indexcolumn]}");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min,max+1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)     
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] averageColumns=GetResultArray(array);
Console.WriteLine($"Среднее ариметическое каждого столбца = {String.Join("; ",averageColumns)}");

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sum+=array[rows,columns];
        }
        result[columns]=Math.Round(sum/array.GetLength(0),1);
    }
    return result;
}

