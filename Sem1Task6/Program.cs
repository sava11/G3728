//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка)

// Вводим данные с консоли
Console.Write("Введите ваше число: ");
string? inputNum = Console.ReadLine();
// Проверка на заполненность
if (inputNum != null)
{
    //Вычисление чётности путём нахождения остатка от деления на 2
    if (int.Parse(inputNum) % 2 == 0)
    {
        Console.WriteLine("число является чётным");//если остатка нет, то выведет "число является чётным"
    }
    else
    {
        Console.WriteLine("число не является чётным");//если остаток есть, то выведет "число не является чётным"
    }
}