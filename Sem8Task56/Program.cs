Random rnd = new Random();
// создание массва и его заполнение
int[,] Create2DArray(int xlen, int ylen, int mn, int mx)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = rnd.Next(Math.Min(mn, mx), Math.Max(mn, mx));
        }
    }
    return arr;
}
// вывод строки двумерного массива
void ShowRawIn2DArray(int[,] arr, int Raw)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        Console.Write(arr[Raw, i] + " \t");
    }
    Console.WriteLine("");
}

// вывод двумерного массива
void Show2DArray(int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        ShowRawIn2DArray(arr, i);
    }
}
// вернуть id строки с минимальной суммой элементов
int GetMinSumInRawId(int[,] arr)
{
    int minSum = int.MaxValue;
    int minId = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rawSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rawSum += arr[i, j];
        }
        if (minSum > rawSum)
        {
            minSum = rawSum;
            minId = i;
        }
    }
    return minId;
}
// ввод числа
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// создание двумерного массива
int[,] arr = Create2DArray(
        InputNum("Введите количество колонок: "),
        InputNum("Введите количество строк: "),
        InputNum("Введите минимальное челое число: "),
        InputNum("Введите максимальное челое число: ")
        );
// вывод двумерного массива
Show2DArray(arr);
Console.Write("строка, с наименьшей суммой элементов: "+(GetMinSumInRawId(arr)+1).ToString());

