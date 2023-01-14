// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

// Вводим данные с консоли
Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
// Проверка на заполненность
if ((inputNum != null) && (inputNum.Length ==3))
{
    //Нахождение остатка путём деления числа на 10
    int num = int.Parse(inputNum) % 10;
    //Вывод остатка
    Console.WriteLine(num);
}
else
{
    //Вывод предупреждения об ошибки
    Console.WriteLine("error: string is null or string length is not equal to three");
}