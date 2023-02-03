Random rnd = new Random();
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
int[] A = create1DArray(10,-99,99); // массив-источник
int[] B = new int[10]; // массив-назначение
int i; // дополнительная переменная
// цикл копирования элементов массива A в массив B
for (i=0; i<A.Length; i++)
    B[i] = A[i];
show1DArray(B);