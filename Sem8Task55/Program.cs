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
bool chck(int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}
void tr(int[,] arr)
{
    int k=0;
    if (chck(arr))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                //(arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
                k=arr[i,j];
                arr[i,j]=arr[j,i];
                arr[j,i]=k;
            }
        }
        Console.WriteLine("матрица транспонирована");
    }
    else
        Console.WriteLine("матрица не транспонирована");
}

int[,] arr = Create2DArray(
        InputNum("Введите количество колонок: "),
        InputNum("Введите количество строк: "),
        InputNum("Введите минимальное челое число: "),
        InputNum("Введите максимальное челое число: ")
        );
Show2DArray(arr);
tr(arr);
Show2DArray(arr);