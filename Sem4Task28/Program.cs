// Задача №28
// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.

using System.Numerics;

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int N = InputNum("Выше число: ");
BigInteger getFactorial(int N){
    BigInteger res=1;
    for (BigInteger i=2;i<N;i++){
        res*=i;
    }
    return res;
}
DateTime d1 = DateTime.Now;
Console.WriteLine(getFactorial(N));
Console.WriteLine(DateTime.Now - d1);