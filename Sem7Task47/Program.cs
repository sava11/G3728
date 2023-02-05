// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
Random rnd = new Random();
// void Show2DArrayRndCol(double[,] arr)
// {
//     for (int i = 0; i <= arr.GetUpperBound(0); i++)
//     {
//         for (int j = 0; j <= arr.GetUpperBound(1); j++)
//         {
//             foreach (char t in arr[i, j].ToString())
//             {
//                 if (t != ',')
//                 {
//                     var consoleColors = Enum.GetValues(typeof(ConsoleColor));
//                     Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
//                 }
//                 else
//                 {
//                     Console.ForegroundColor=ConsoleColor.White;
//                 }
//                 Console.Write(t);
//             }
//             Console.Write("\t");
//         }
//         Console.WriteLine("");
//     }
//     Console.ForegroundColor = System.ConsoleColor.White;
// }
double[,] Create2DArray(int xlen, int ylen,int mn,int mx)
{
    double[,] arr = new double[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = (double)rnd.Next(Math.Min(mn, mx), Math.Max(mn, mx))+rnd.NextDouble();
        }
    }
    return arr;
}
void Show2DArray(double[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor=(ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
            Console.Write(arr[i, j] + " \t");
        }
        Console.WriteLine("");
    }
    Console.ForegroundColor=System.ConsoleColor.White;
}

Show2DArray(Create2DArray(5,7,1,6));