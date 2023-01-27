// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int len = InputNum("Введите длинну массива: ");
int num1 = InputNum("Введите минимум для значений в массиве: ");
int num2 = InputNum("Введите максимум для значений в массиве: ");
Random rnd = new Random();
int[] createArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
void showArray(int[] arr)
{
    for (int i = 0; i < len; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
int[]arr=createArray(len);
showArray(arr);
int Sum(int[] arr, bool MinOrMax){
    int sum=0;
    foreach(var i in arr){
        if ((MinOrMax==false)&&(i<0)){
            sum+=i;
        }
        if ((MinOrMax==true)&&(i>0)){
            sum+=i;
        }
    }
    return sum;
}

Console.WriteLine("Позитивные "+Sum(arr,true));
Console.WriteLine("Негативные "+Sum(arr,false));