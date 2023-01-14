// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// Вводим данные с консоли
Console.Write("input your day num: ");
string? inputNum = Console.ReadLine();
//Вар. 1
if (inputNum != null)
{
    //Создание и заполнение массива
    string[] dayNames = new string[7];
    dayNames[0] = "понедельник";
    dayNames[1] = "вторник";
    dayNames[2] = "среда";
    dayNames[3] = "четверг";
    dayNames[4] = "пятница";
    dayNames[5] = "суббта";
    dayNames[6] = "воскресенье";
    //Нахождение остатка от деления модуля преобразованной строки в число
    int day = (Math.Abs(int.Parse(inputNum))-1) % 7;
    Console.WriteLine(dayNames[day]);//Вывод
}