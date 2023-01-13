//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Write("input your first num: ");
string? inputNum1 = Console.ReadLine();
Console.Write("input your second num: ");
string? inputNum2 = Console.ReadLine();
Console.Write("input your third num: ");
string? inputNum3 = Console.ReadLine();
if ((inputNum1 != null) && (inputNum2 != null) && (inputNum3 != null))
{
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int num3 = int.Parse(inputNum3);
    if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine("Max is " + num1 + " (first num)");
    }
    else
    {
        if (num2 > num3)
        {
            Console.WriteLine("Max is " + num2 + " (second num)");
        }
        else
        {
            Console.WriteLine("Max is " + num3 + " (third num)");
        }
    }
}
//     if (num1 < num2 && num1 < num3)
//         Console.WriteLine("Min is "  + num1+" (first num)");
//     else if (num2 < num3)
//         Console.WriteLine("Min is "  + num2+" (second num)");
//     else
//         Console.WriteLine("Min is " + num3+" (third num)");
// }
