// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int num = ReadData("Введите N: ");

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int N, int p)
{
    string str = "";
    for (int i = 1; i <= N; i++)
    {
        str += Math.Pow(i, p).ToString() + "\t";
    }
    return str;
}

// Вывод данных
Console.WriteLine(LineBuilder(num, 1));
Console.WriteLine(LineBuilder(num, 2));