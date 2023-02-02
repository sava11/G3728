// Добавляет пробел, если последний символ не пробел
string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}

// Ввод целочисленного значения
int[] MultiInputs(string msg)
{
    Console.Write(editLine(msg));
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
int countPositiveELemInArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
// int InputAmout(string msg)
// {
//     Console.Write(msg);
//     string s = Console.ReadLine();
//     if (string.IsNullOrEmpty(s) != true)
//     {
//         return int.Parse(s);
//     }
//     else
//     {
//         return default;
//     }
// }
Console.WriteLine("в массиве элементов > 0 = "+
countPositiveELemInArr(MultiInputs("Введите целые числа (через пробел): ")));