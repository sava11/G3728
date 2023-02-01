
int[] multiInputs(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(" ");
    int[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != ""))
            vec = vec.Append(int.Parse(arr[i])).ToArray();
    }
    return vec;
}
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
int[] sort1DArrayInt(int[] array)
{   int temp=0;
    int[]copyArray = new int[array.Length];
    array.CopyTo(copyArray, 0);
    for (int i = 0; i < copyArray.Length; i++)
    {
        for (int j = i + 1; j < copyArray.Length; j++)
        {
            if (copyArray[i] > copyArray[j])
            {
                temp=copyArray[i];
                copyArray[i] = copyArray[j];
                copyArray[j] = temp;
            }
        }
    }
    return copyArray;
}
int get_even_even_count(int[]arr){
    int res=0;
    foreach(int i in arr){
        if (i%2==0){
            res+=1;
        }
    }
    return res;
}
int[] arr=sort1DArrayInt(multiInputs("введите значения для массива в строку: "));
show1DArray(arr);
Console.WriteLine(get_even_even_count(arr));
