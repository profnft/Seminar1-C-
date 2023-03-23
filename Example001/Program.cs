// Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int squere = number * number;
Console.WriteLine($"Квадрат числа {number} = {squere}");