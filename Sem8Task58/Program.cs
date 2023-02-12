// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
// ввод числа
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// умножение матрицы на матрицу
int[,] DivMatrix(int[,] a, int[,] b)
{
    int aRows = a.GetLength(0); int aCols = a.GetLength(1);
    int bRows = b.GetLength(0); int bCols = b.GetLength(1);  
    int[,] result = new int[aRows, bCols];
    for (int i = 0; i < aRows; i++) 
        for (int j = 0; j < bCols; j++) 
        for (int k = 0; k < aCols; k++)
        result[i,j] += a[i,k] * b[k,j];
    return result;
}

// создание двумерного массива
int[,] arr = Create2DArray(
        InputNum("Введите количество колонок для Первой матрицы: "),
        InputNum("Введите количество строкдля Первой матрицы: "),
        InputNum("Введите минимальное челое число для Первой матрицы: "),
        InputNum("Введите максимальное челое число для Первой матрицы: ")
        );
Console.WriteLine("");
// создание двумерного массива1
int[,] arr1 = Create2DArray(
        InputNum("Введите количество колонок для Второй матрицы: "),
        InputNum("Введите количество строк для Второй матрицы: "),
        InputNum("Введите минимальное челое число для Второй матрицы: "),
        InputNum("Введите максимальное челое число для Второй матрицы: ")
        );
// вывод двумерного массива
Show2DArray(arr);
Console.WriteLine("");
Show2DArray(arr1);
Console.WriteLine("");
if (arr.GetLength(0) == arr1.GetLength(0) && arr.GetLength(1) == arr1.GetLength(1))
{
    Show2DArray(DivMatrix(arr, arr1));
}
else
{
Console.WriteLine("Нарушено условие перемножения матриц");
}
//Console.Write("строка, с наименьшей суммой элементов: ");

