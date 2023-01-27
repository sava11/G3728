// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] create1DArray(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
bool tst(int x,int mn,int mx){
    if (x>mn&&x<mx){
        return true;
    }
    return false;
}
int countElem(int[] arr,int mn,int mx){
    int res=0;
    for(int i = 0; i<arr.Length;i++){
        if (tst(arr[i],10,99)){
            res+=1;
        }
    }
    return res;
}
int len = InputNum("Введите длинну массива: ");
int num1 = InputNum("Введите минимум для значений в массиве: ");
int num2 = InputNum("Введите максимум для значений в массиве: ");

int num3 = InputNum("Введите минимум для промежутка поиска: ");
int num4 = InputNum("Введите максимум для промежутка поиска: ");
int[]arr=create1DArray(len,num1,num2);
show1DArray(arr);
Console.WriteLine("количество значений в промежутке от "+num3+" до "+num4+": "+countElem(arr,num3,num4));