// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// ввод чисел
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// шенерация строки с числами по возвростанию с использованием рекусии
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return LineGenRec(num - 1) + " " +num;
    }
}
Console.WriteLine(LineGenRec(InputNum("Введите число N: ")));