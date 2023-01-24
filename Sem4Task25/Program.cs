// Задача №26
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int A = InputNum("Выше число: ");

int withString(int A)
{
    return A.ToString().Length;
}
DateTime d = DateTime.Now;
Console.WriteLine(withString(A));
Console.WriteLine(DateTime.Now - d);



int withWhile(int A)
{
    int r = 0;
    while (A > 0)
    {
        A = A / 10;
        r++;
    }
    return r;
}
DateTime d1 = DateTime.Now;
Console.WriteLine(withWhile(A));
Console.WriteLine(DateTime.Now - d1);
