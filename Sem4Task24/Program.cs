// Задача №24
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int A=InputNum("Выше число: ");
int getSum_1ToA(int A){
    int sum=1;
    for(int i=2; i<=A; i++){
        sum+=i;
    }
    return sum;
    }
DateTime d=DateTime.Now;
Console.WriteLine("Сумма от 1 до вашего числа: "+getSum_1ToA(A));
Console.WriteLine(DateTime.Now-d);
d=DateTime.Now;
Console.WriteLine("Сумма от 1 до вашего числа по Гаусу: "+(A*(A+1))/2);
Console.WriteLine(DateTime.Now-d);