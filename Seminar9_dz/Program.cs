// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("-> ");
Number(number);

void Number(int number)
{
    if (number > 0)
    {
        Console.Write($"{number} ");
        Number(number - 1);
    }
}
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 
/*Console.Write("Введи число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел: {SumNumberFromM2N(m, n)}");

int SumNumberFromM2N(int start, int end)
{
    while (start <= end)
        return start + SumNumberFromM2N(start + 1, end);
        return 0;
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {FunAkkerman(m, n)}");

int FunAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
    return FunAkkerman(m, n);
}