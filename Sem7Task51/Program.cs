// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] Create2DArray(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j + i + 1;
        }
    }
    return arr;
}
void Show2DArray(int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
int GetMainGiagIn2DArray(int[,] arr)
{
    int res = 0;
    int mn = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    for (int i = 0; i < mn; i++)
    {
        res += arr[i, i];
    }
    return res;
}
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] arr = Create2DArray(xlen, ylen);
Show2DArray(arr);
Console.WriteLine("Сумма элементов на главной диагонали " + GetMainGiagIn2DArray(arr).ToString());