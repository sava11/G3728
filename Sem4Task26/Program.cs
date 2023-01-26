// *"Калькулятор"
double[] MultiInputs(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(" ");
    double[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != ""))
            vec = vec.Append(double.Parse(arr[i])).ToArray();
    }
    return vec;
}
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
double InputNumD(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}
void WriteInConsole(string[] what)
{
    foreach (string i in what)
    {
        Console.WriteLine(i + " " + (Array.IndexOf(what, i) + 1));
    }
}
void math(int i)
{
    if (i == 1)
    {
        double output = 0.0F;
        foreach (var j in MultiInputs("введите числа: "))
        {
            output += j;
        }
        Console.WriteLine(output);
    }
    if (i == 2)
    {
        double output = 0.0F;
        foreach (var j in MultiInputs("введите числа: "))
        {
            output -= j;
        }
        Console.WriteLine(output);
    }
    if (i == 3)
    {
        double output = 1.0F;
        foreach (var j in MultiInputs("введите числа: "))
        {
            output *= j;
        }
        Console.WriteLine(output);
    }
    if (i == 4)
    {
        double[] in_=MultiInputs("введите числа: ");
        double output = in_[0];
        foreach (var j in in_.Where(val => val != in_[0]).ToArray())
        {
            output = output/j;
        }
        Console.WriteLine(output);
    }
     if (i == 5)
    {
        double num=InputNumD("введите число: ");
        double p=InputNumD("введите степень числа: ");
        Console.WriteLine(Math.Pow(num,p));
    }

}

string[] arr = { "сложение", "вычитание", "умножение", "деление", "степень числа" };
WriteInConsole(arr);Console.WriteLine("");
int id = InputNum("Введите ваш выбор: ");Console.WriteLine("");
math(id);