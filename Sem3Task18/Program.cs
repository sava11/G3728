// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// считываемые данные от пользователя
int cord(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int qnum = cord("Введите номер четверти: ");
// Метод определения четверти по координатам точки
void PrintQuterAnswer(int num)
{
    if (num > 0 && num < 4)
    {
        if (num == 1) Console.WriteLine("X > 0; Y > 0");
        if (num == 2) Console.WriteLine("X > 0; Y < 0");
        if (num == 3) Console.WriteLine("X < 0; Y > 0");
        if (num == 4) Console.WriteLine("X < 0; Y < 0");
    }
}
PrintQuterAnswer(qnum);