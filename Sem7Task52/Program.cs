// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям 
// и диагональ выделить разным цветом.
Random rnd = new Random();
int[,] Create2DArray(int xLen, int yLen, int mn, int mx)
{
    int[,] arr = new int[yLen, xLen];
    for (int i = 0; i < yLen; i++)
    {
        for (int j = 0; j < xLen; j++)
        {
            arr[i, j] = rnd.Next(Math.Min(mn, mx), Math.Max(mn, mx));
        }
    }
    return arr;
}
void Show2DArrayWithRowAVG(int[,] arr)
{
    int mn = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((mn - 1 - i) == j)
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
            }
            if (j == i)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            if ((j == (mn - 1) - j) && (i == (mn - 1) - i))
            {
                Console.ForegroundColor = System.ConsoleColor.Magenta;
            }
            Console.Write(arr[i, j] + " \t");
            Console.ForegroundColor = System.ConsoleColor.White;
            sum += arr[i, j];
        }
        Console.WriteLine("Ср. арефм. в этой строке: " + (double)sum / arr.GetLength(1));
    }
}
double GetDioganalAVGIn2DArray(int[,] arr, bool mainOrNot)
{
    int res = 0;
    int mn = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    for (int i = 0; i < mn; i++)
    {
        res += arr[i, (mn - 1 - i) * Convert.ToInt32(!mainOrNot) + i * Convert.ToInt32(mainOrNot)];
    }
    return (double)res / mn;
}
int[,] arr = Create2DArray(5, 7, 1, 6);
Show2DArrayWithRowAVG(arr);
Console.WriteLine("Ср. арефм из главной диагонали " + GetDioganalAVGIn2DArray(arr, true));
Console.WriteLine("Ср. арефм из побочной диагонали " + GetDioganalAVGIn2DArray(arr, false));