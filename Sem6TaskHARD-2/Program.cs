// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс. Вывести эту информацию на экран.
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
int xlen = InputNum("Ваше число X: ");
int ylen = InputNum("Ваше число Y: ");
Random rnd = new Random();
int[,] createArray(int xlen, int ylen)
{

        int[,] arr = new int[xlen, ylen];
        for (int i = 0; i < xlen; i++)
        {
            for (int j = 0; j < ylen; j++)
            {
                arr[i, j] = rnd.Next(-999, 999);
            }
        }
    return arr;
}
string border(int N)
{
    string str = "";
    for (int i = 0; i < N; i++)
    {
        str += "|";// горизонтальная граница ч.1
        // Исключение
        if (i == 0) { str += "-"; }
        // добавляет символ "-" в количестве 14 штук
        str += "--------------";
        str += "|";// горизонтальная граница ч.2 
    }

    return str;
}
void showArray(int[,] arr)
{
    
    for (int i = 0; i < ylen; i++)
    {
        Console.WriteLine(border(xlen));
        for (int j = 0; j < ylen; j++)
        {
        Console.Write("|\t"+arr[i,j].ToString()+"\t|");
        }Console.WriteLine("");
        Console.WriteLine(border(ylen));
    }
}
showArray(createArray(xlen, ylen));