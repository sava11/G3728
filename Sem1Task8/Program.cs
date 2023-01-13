//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите ваше число: ");
string? inputNum = Console.ReadLine();// Ввод первого числа
if (inputNum != null)
{
    int num = int.Parse(inputNum);
    // Как я хочу:
    // for (int i = 2; i < num+1; i=i+2)
    // {
    //     Console.WriteLine(i);
    // }
    // Как нужно:
    for (int i = 1; i < num+1; i++)
    {
        if(i%2==0){
        Console.WriteLine(i);}
    }
}