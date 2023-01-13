//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите ваше число: ");
string? inputNum = Console.ReadLine();// Ввод первого числа
if (inputNum != null)
{
    if(int.Parse(inputNum)%2==0){Console.WriteLine("число является чётным");}
    else{Console.WriteLine("число не является чётным");}
}