int InputNum(string msg = "")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void pscltr(int nRow)
{
    for (int i = 0; i <= nRow; i++)
    {
        for (int j = 0; j <= nRow - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <=i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine(" ");
    }
}
int countRow = InputNum("Введите количество строк треугольника Паскаля: ");
pscltr(countRow);