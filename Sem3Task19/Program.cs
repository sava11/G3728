// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Проверка на полидромность
bool checkPoli(int num)
{
    char[] number = num.ToString().ToCharArray();// преобразование из челого в char[]
    for (int i = 0; i < number.Length; i++)
    {
        // Если разность i-элемента и i-размер_char[] не равна нулю, то
        // число не является полиндромом
        if (number[i] - number[number.Length - 1 - i] != 0)
        {
            return false;
        }
    }
    return true;
}

// Считываемые данные от пользователя
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int num = InputNum("Введите число: ");

// Проверка на пятизначность 
if (num.ToString().Length == 5)
{
    // Проверка на ?полиндромность?
    if (checkPoli(num))
    {
        Console.WriteLine("Это пятизначное число является полиндромом!");// вывод согласия
    }
    else
    {
        Console.WriteLine("Это пятизначное число не является полиндромом!");// вывод не согласия
    }
}
else
{
    if (num.ToString().Length == 4)
    {
        // Задача 19 (*) -> Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

        var polis = new Dictionary<int, string>() { };

        for (int i = 1000; i <= 9999; i++)
        {
            // если полиндром, то добавить <<значение : согласие>>, иначе <<значение : не_согласие>>
            if (checkPoli(i))
            {
                polis.Add(i, "Это четырёхзначное число - полиндром");
            }
            else
            {
                polis.Add(i, "Это четырёхзначное число - не полиндром");
            }
        }
        Console.WriteLine(polis[num]);
    }
    else
    {
        Console.WriteLine("Число не является пятизначным или четырёхзначным!");
    }// вывод ошибки
}




