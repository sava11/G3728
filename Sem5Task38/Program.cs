Random rnd = new Random();
// Функция которая добавляет пробел в конец строки, если его нет
string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
// Ввод целочисленных значений
int InputNum(string msg)
{
    Console.Write(editLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
// ввод вещественных значений
double InputNumD(string msg)
{
    Console.Write(editLine(msg));
    return double.Parse(Console.ReadLine() ?? "0");
}
// метод генерации массива случайными числами
double[] create1DArrayD(int len, double num1, double num2)
{
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        // заполним массив минимальными и максимальными значениями
        arr[i] = rnd.NextDouble() * (Math.Max(num1, num2) - Math.Min(num1, num2)) + Math.Min(num1, num2);
    }
    return arr;
}
int[] create1DArrayI(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        // заполним массив минимальными и максимальными значениями
        arr[i] = rnd.Next(Math.Min(num1, num2),Math.Max(num1, num2));
    }
    return arr;
}
//  метод печати массива
void show1DArrayD(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + new string(' ',arr[i].ToString().Length/2));
    }
    Console.WriteLine(" ");
}
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
//Создание массива с вещественными числами
int MaxMinusMin(int[] arr)
{
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}
int len=InputNum("Введите длинну массива: ");
double min=InputNumD("Введите минимум для значений в массиве: ");
double max=InputNumD("Введите максимум для значений в массиве: ");
double[] arrD = create1DArrayD(len,min,max);
show1DArrayD(arrD);
int[] arrI = create1DArrayI(len,Convert.ToInt32(min),Convert.ToInt32(max));
show1DArray(arrI);
//функция Нахождения разницы между максимальным и минимальным значениями массива
Console.WriteLine("Разница между минимум и максимум: "+MaxMinusMin(arrI).ToString());