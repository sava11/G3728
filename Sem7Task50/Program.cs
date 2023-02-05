// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
Random rnd = new Random();
// Ввод числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] GetFibonachi2DArray(int xLen, int yLen)
{
    /// <summary>
    /// Возвращает двумерный массив цыфр ряда Фибоначи
    /// </summary>
    int[] arr = new int[xLen * yLen];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    int[,] arr2D = new int[yLen, xLen];
    for (int i = 0; i < yLen; i++)
    {
        for (int j = 0; j < xLen; j++)
        {
            arr2D[i, j] = arr[i * xLen + j];
        }
    }
    return arr2D;
}
void Show2DArrayWithColoredValue(int[,] arr, int value)
{
    bool finded = false;
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            if (arr[i, j] == value)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                finded = true;
            }
            Console.Write(arr[i, j] + " \t");
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        Console.WriteLine("");
    }
    if (finded == false)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("Числа "+value+" не обноружено");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}

Show2DArrayWithColoredValue(
    GetFibonachi2DArray(
        InputNum("Введите число колонок: "),
        InputNum("Введите искомое строк: ")
        ), 
            InputNum("Введите искомое число: ")
            );