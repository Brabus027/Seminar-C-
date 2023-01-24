// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/* int[] Massive(int size, int min, int max)
{
    int[] array = new int[size];
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Размер массива = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальный элемент массива: трехзначное число = ");
int min = Convert.ToInt32(Console.ReadLine());
if (min < 100 || min > 999)
{
    Console.Write("Число должно быть трехзначным");
}
else
{
    Console.Write("Максимальный элемет массива: трехзначное число = ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (max < 100 || max > 999)
    {
        Console.Write("Число должно быть трехзначным");
    }
    else
    {
        int[] array = Massive(size, min, max);
        Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
        int count = EvenNumber(array);
        Console.WriteLine($"Количество четных чисел = {count}");
    }
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/* int[] Massive(int size, int min, int max)
{
    int[] array = new int[size];
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int OddNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Размер массива = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальный элемент массива:  = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальный элемет массива:  = ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = Massive(size, min, max);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
int sum = OddNumber(array);
Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях = {sum}");
*/

// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(5, 1, 11);
ShowArray(myArray);

for (int i = 0; i < myArray.Length/2; i++)
{
    Console.Write(myArray[i]*myArray[myArray.Length-i-1]+" ");
}
if (myArray.Length%2!=0)
{
Console.Write(myArray[myArray.Length/2]+" ");
}
