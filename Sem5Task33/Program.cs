// Задача №33
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
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

int len = InputNum("Введите длинну массива: ");
int num1 = InputNum("Введите минимум для значений в массиве: ");
int num2 = InputNum("Введите максимум для значений в массиве: ");
int x = InputNum("Введите искомое значение: ");
int[]arr=create1DArray(len,num1,num2);
int[] searchAllXIn1DArray(int x, int[] arr){
    int[] indexs={};
    for(int i=0; i<arr.Length;i++){
        if(arr[i]==x){
            indexs=indexs.Append(i).ToArray();
        }
    }
    if (indexs.Length>0){return indexs;}else{return new int[1]{-1};}
}
int[] searchXIn1DArray(int x, int[] arr){
    int index=-1;
    for(int i=0; i<arr.Length;i++){
        if(arr[i]==x){
            index=i;break;
        }
    }
    return index;
}
show1DArray(searchAllXIn1DArray(x,arr));
show1DArray(searchXIn1DArray(x,arr));