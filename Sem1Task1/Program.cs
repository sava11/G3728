// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
string? inputNum1 = Console.ReadLine();// Ввод первого числа
string? inputNum2 = Console.ReadLine();// Ввод второго числа
// проверка на заполненность
if ((inputNum1 != null) && (inputNum2 != null))
{
    //сравнение возведённого в квадрат числа с другим числом
    if ((int)Math.Pow(int.Parse(inputNum2), 2) == int.Parse(inputNum1))
    {
        Console.Write("yes");//вывод согласия
    }
    else
    {
        Console.Write("no");//вывод не согласия
    }
}