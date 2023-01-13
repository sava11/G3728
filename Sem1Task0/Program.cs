//Задача №0
//Напишите программу, которая на вход принимает
//число и выдаёт его квадрат (число умноженное на само себя).

// вывод приказа
Console.Write("input yor num: ");
// Вводим данные с консоли
string? inputNum = Console.ReadLine();
// проверка на заполненность
if (inputNum!=null){
    // Парсим вверённое число
    //int num = int.Parse(inputNum);
    // Выводим данные
    Console.Write("output: ");
    Console.Write((int)Math.Pow(int.Parse(inputNum),2));
}