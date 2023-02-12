// Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// ввод чисел
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// шенерация строки с числами по убыванию с использованием рекусии
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return num + " "  + LineGenRec(num - 1);
    }
}
Console.WriteLine(LineGenRec(InputNum("Введите число N: ")));