// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * Вывести таблицу с границами и значениями друг над другом

// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// вывод нахождения степени чисел от 1 до N
string LineBuilder(int N, int p)
{
    string str = "";
    for (int i = 1; i <= N; i++)
    {
        str += "|\t" + Math.Pow(i, p).ToString() + "\t|";
    }
    return str;
}
// Создание горизонтальной границы
string border(int N)
{
    string str = "";
    for (int i = 0; i < N; i++)
    {
        str += "|";// горизонтальная граница ч.1
        // Исключение
        if (i == 0) { str += "-"; }
        // добавляет символ "-" в количестве 14 штук
        str += "--------------";
        str += "|";// горизонтальная граница ч.2 
    }

    return str;
}
//вывод в таблицу
void output(int num,int p)
{
    Console.WriteLine(border(num));
    Console.WriteLine(LineBuilder(num, p));
    Console.WriteLine(border(num));
}
int num = ReadData("Введите N: ");
// Вывод данных
output(num,1);
output(num,3);