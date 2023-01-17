// Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*Console.WriteLine("Введите числа A и B");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0)
Console.WriteLine("Введите число В больше нуля");
else
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($" Число А в степени В:{result}");
}
*/

//  Задача 27: Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Cумма цифр введенного числа: {sum}");
}
GetSumNums(n);
*/

//  Задача 29: Напишите программу, которая задаёт массив из 8 
//  элементов и выводит их на экран.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int[] array = GetBinaryArray(n);

Console.WriteLine($" [ {String.Join(",", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0,n);
    }

    return result;
}

