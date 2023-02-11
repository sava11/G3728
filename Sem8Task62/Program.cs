
int[,] Create2DArray(int N, int M)
{
    return new int[N, M];
}
//
void FillSpiral2DAerray(int[,] arr)
{
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = k;
        if (i == Ibeg && j < arr.GetLength(1) - Jfin - 1)
            ++j;
        else if (j == arr.GetLength(1) - Jfin - 1 && i < arr.GetLength(0) - Ifin - 1)
            ++i;
        else if (i == arr.GetLength(0) - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != arr.GetLength(1) - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
}
void Show2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
            Console.Write(arr[i, j] + " \t");
        Console.WriteLine("");
    }
}
int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,]arr=Create2DArray(
                InputNum("Введите количество строк: "),
                InputNum("Введите количество колонок: ")
                );
FillSpiral2DAerray(arr);
Show2DArray(arr);