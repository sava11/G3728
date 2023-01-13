// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
if (inputNum != null){
    int num = int.Parse(inputNum);
    for (int i = 0; i < num*2; i++){
        Console.Write(i-num);
        Console.Write(", ");
    }
    Console.Write(num);
}