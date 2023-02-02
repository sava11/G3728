// Добавляет пробел, если последний символ не пробел
string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
// Ввод целочисленного значения
int InputNum(string msg)
{
    Console.Write(editLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводит точку пересечения двух линий заданных по функции: k * x + b
void calc(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
            Console.WriteLine("точка пересечения в ("+x.ToString()+"; "+y.ToString()+")");
        }
    }
}

int k1 = InputNum("Введите k1:");
int b1 = InputNum("Введите b1:");
int k2 = InputNum("Введите k2:");
int b2 = InputNum("Введите b2:");
calc(Convert.ToDouble(k1),Convert.ToDouble(b1),Convert.ToDouble(k2),Convert.ToDouble(b2));