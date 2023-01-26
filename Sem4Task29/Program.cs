// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
string[] MultiInputs(string msg,string what)
{
    Console.Write(msg);
    string n = what;
    string[] arr = n.Split(' ',',');
    string[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != "")||(arr[i] != ","))
            vec = vec.Append(arr[i]).ToArray();
    }
    return vec;
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
showArray(createArray(len));

// Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал 
// Игорь, Антон, Сергей -> Антон Подсказка: Для разбора строки использовать метод string.split(). 
// Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).
string names="Игорь, Антон, Сергей, Савелий, Олег";
string[] arrNames=MultiInputs("d: ",names);
Console.WriteLine(arrNames[rnd.Next(1,arrNames.Length-1)]);
