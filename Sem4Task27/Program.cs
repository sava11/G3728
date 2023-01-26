// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int SLen(int n){
    return Math.Abs(n).ToString().Length;
}
int LogLen(int n){
    return (int)Math.Log10(Math.Abs(n)) + 1;
}
int WhLen(int n){
    int number = Math.Abs(n);
    int len = 1;
    while ((number /= 10) >= 1)
        len++;
    return len;
}
int n=InputNum("Введите число: ");
DateTime d=DateTime.Now;// не знаю почему, но у меня на "машине" если удалить это действие время первого вычисления заметно возрастает
DateTime d2=DateTime.Now;
int loglen=LogLen(n);
Console.WriteLine(DateTime.Now-d2);
Console.WriteLine(loglen);
DateTime d3=DateTime.Now;
int whlen=WhLen(n);
Console.WriteLine(DateTime.Now-d3);
Console.WriteLine(whlen);
DateTime d1=DateTime.Now;
int slen=SLen(n);
Console.WriteLine(DateTime.Now-d1);
Console.WriteLine(slen);