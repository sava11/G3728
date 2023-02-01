// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
int InputNum(string msg)
{
    Console.Write(editLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
int value = InputNum("Введите натуральное число:");
string bin = Convert.ToString(value, 2);
Console.WriteLine(bin);