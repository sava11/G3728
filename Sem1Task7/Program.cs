// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
if ((inputNum != null) && (inputNum.Length()<4)){
    int num = int.Parse(inputNum)%10;
}else{
    Console.WriteLine("error");
}