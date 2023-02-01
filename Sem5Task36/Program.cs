// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.

string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
// Метод вывода данных
void PrintData(string msg = " ", int res = 0)
{
    Console.Write(editLine(msg));
    Console.WriteLine(res);
}
Random rnd = new Random();
// метод генерации массива случайными числами
int[] create1DArray(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        // заполним массив минимальными и максимальными значениями
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
//  метод печати массива
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
void show1DArrayWithMessage(string msg, int[] arr)
{
    Console.WriteLine(editLine(msg));
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
// поиск нечётных элементов и дальнеёшее их суммирование
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0) { res += arr[i]; }
    }

    return res;

}
//Ввод данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Поиск всех элементов равных "x" и возврат их индексов
int[] searchAllXIn1DArray(int x, int[] arr)
{
    int[] indexs = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            indexs = indexs.Append(i).ToArray();
        }
    }
    if (indexs.Length > 0) { return indexs; } else { return new int[1] { -1 }; }
}
int searchXIn1DArray(int x, int[] arr)
{
    int index = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            index = i; break;
        }
    }
    return index;
}
//Выыод
void output(int[] arr)
{
    int[] ex = { };
    for (int i = 0; i < arr.Length; i++)
    {
        int[] arr1 = searchAllXIn1DArray(arr[i], arr);
        if (searchXIn1DArray(arr[i], ex) == -1 && arr1.Length > 1)
        {
            show1DArrayWithMessage("пары числа " + arr[i].ToString() + " находятся на позициях:", arr1);
            ex = ex.Append(arr[i]).ToArray();
        }
        else
        {
            if (searchXIn1DArray(arr[i], ex) == -1)
            {
                Console.WriteLine("пар числа " + arr[i].ToString() + " нет");
            }
        }
    }
}
// Создание массива
int[] arr = create1DArray(
    InputNum("Введите длинну массива: "),
    InputNum("Введите минимум для значений в массиве: "),
    InputNum("Введите максимум для значений в массиве: ")
    );
// напечатаем
show1DArray(arr);

// Вывод значений на консоль
PrintData("Сумма элементов массива,стоящих на нечётных позициях равна:", SumPos(arr));
output(arr);


