// Задача №30
// Напишите программу, которая выводит массив из N элементов, 
// заполненный нулями и единицами в случайном порядке.\
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int xlen = InputNum("Ваше число X: ");
int ylen = InputNum("Ваше число Y: ");
Random rnd = new Random();
int[,] createArray(int xlen, int ylen)
{
    int[,] arr = new int[xlen, ylen];
    for (int i = 0; i < xlen; i++)
    {
        for (int j = 0; j < ylen; j++)
        {
            arr[i, j] = rnd.Next(-999, 999);
        }
    }
    return arr;
}
void showArray(int[,] arr)
{
    for (int i = 0; i < xlen; i++)
    {
        for (int j = 0; j < ylen; j++)
        {
            
        Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine("");
    }
}
showArray(createArray(xlen, ylen));