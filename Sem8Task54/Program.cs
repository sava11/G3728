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
// сортировка одномерного массива
void Bubble1DArraySort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
// сортировка двумерного массва
void LevelBubble2DArraySort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] lvlArr = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            lvlArr[j] = arr[i, j];
        }
        Bubble1DArraySort(lvlArr);
        for (int j = 0; j < lvlArr.Length; j++)
        {
            arr[i, j] = lvlArr[j];
        }
    }
}
// вывод двумерного массива
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
Console.WriteLine("Исходный массив:");
Show2DArray(arr);
Console.WriteLine("");
// сортировка двумерного массива
LevelBubble2DArraySort(arr);
// вывод двумерного массива
Console.WriteLine("отсортированный массив:");
Show2DArray(arr);