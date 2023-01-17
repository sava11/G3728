//Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
povNums(num1,num2);
povNums(num2,num1);
void povNums(int i,int j){
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число "+j+" является степенью числа "+i);//вывод согласия
    }
}