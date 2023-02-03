string EditLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
int InputNum(string msg)
{
    Console.Write(EditLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] Create2DArray(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
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
int xlen = InputNum("Ваше число столбцов:");
int ylen = InputNum("Ваше число строк:");
Show2DArray(Create2DArray(xlen, ylen));