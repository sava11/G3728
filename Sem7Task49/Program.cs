// Задача №49
// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
            arr[i, j] = j + i;
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
void Update2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetUpperBound(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetUpperBound(1); j = j + 2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
}
int xlen = InputNum("Ваше число столбцов:");
int ylen = InputNum("Ваше число строк:");
int[,] arr = Create2DArray(xlen, ylen);
Update2DArray(arr);
Show2DArray(arr);
