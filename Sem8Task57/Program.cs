
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
int[] Fill(int[,]arr,int alf){
    int[] farr=new int[alf];
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++){
            ++farr[arr[i,j]];
        }
    }
    return farr;
}
void Print1DArray (int[] meanArr)
{
    for (int i = 0; i < meanArr.Length; i++)
    {
        Console.Write(meanArr[i] + "\t");
    }
}
int n=InputNum("Введите количество колонок: ");
int m=InputNum("Введите количество строк: ");
int[,] arr = Create2DArray(n,m,0,100);

Show2DArray(arr);
Print1DArray(Fill(arr,101));