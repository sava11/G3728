
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
int InputNum(string msg)
{
    Console.Write(editLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
//  метод печати массива
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
int N=InputNum("Введите количесво цисел ряда Фибоначи");
int[] arr=new int[N];
arr[0]=0;
arr[1]=1;
for(int i=2;i<N;i++){
    arr[i]=arr[i-1]+arr[i-2];
}
show1DArray(arr);