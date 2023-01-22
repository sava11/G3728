﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()??"0");
//"Если значение находится в промежутке (99;999], то продолжаем, 
// иначе выводим сообщение об ошибке"
if (number <= 999 && number>99)
{
    //Уничтожаем хвостик после второй цифры
    while (number > 99)
    {
        //Уничтожение последней цифры
        number = number / 10;
    }
    Console.WriteLine("второе число: ");
    //Выводим остаток от деления на 10 (возвращаем последнюю цыфру)
    Console.WriteLine(number % 10);
}
else
{
    //Вывод ошибки
    Console.WriteLine("число не двузначное!");
}

