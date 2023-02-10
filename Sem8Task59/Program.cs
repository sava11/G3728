
Random rnd = new Random();
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
void Show2DArray(int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
            Console.Write(arr[i, j] + " \t");
        }
        Console.WriteLine("");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
(int x, int y) SearchMinElem(int[,] arr)
{
    int raw = 0;
    int col = 0;
    int mn = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (mn>arr[i,j]){
                raw=i;
                col=j;
                mn=arr[i,j];
            }
        }
    }
    return (raw,col);
}
int[,] UpDate2dArray(int[,] arr, int x, int y)
{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0; int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                res[k, m] = arr[i, j];
            }
            if (j != x) { m++; }
        }
        if (i != x) { k++; }
    }
    return res;
}
int[,] arr = Create2DArray(
        InputNum("Введите количество колонок: "),
        InputNum("Введите количество строк: "),
        InputNum("Введите минимальное челое число: "),
        InputNum("Введите максимальное челое число: ")
        );
Show2DArray(arr);
(int x, int y) mn=SearchMinElem(arr);
Console.WriteLine("");
Show2DArray(UpDate2dArray(arr,mn.x,mn.y));