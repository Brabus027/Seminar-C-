//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Проверка на пятизначность обязательна
//14212 -> нет
//12821 -> да
//23432 -> да

/*string GetNumberAndShowPalidrome(int numberFunction)
{
    string str = Convert.ToString(numberFunction);
    string result;
    if (str.Length == 5)
    {
        if ((str[0] == str[4]) & (str[1] == str[3]))
        {
            result = "Число " + numberFunction + " является палиндоном";
        }
        else
        {
            result = "Число " + numberFunction + " не является палиндоном";
        }
    }
    else
    {
        result = "Число " + numberFunction + " не пятизначное";
    }
    return result;
} 

Console.WriteLine("Введите 5-ти значное число, наприме 12345");
int number = Convert.ToInt32(Console.ReadLine());
string result = GetNumberAndShowPalidrome(number);
Console.WriteLine(result); */

//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double GetCoodinateDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2)));
    return distance;
}
Console.WriteLine("Введите координату X1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = GetCoodinateDistance(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"Расстояние между точками=" + result); */

//Задача 3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
} 