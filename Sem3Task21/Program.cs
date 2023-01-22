
// транформация из строки в массив целых чисел
int[] InputNums(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(" ");
    int[] vec = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        vec[i]=int.Parse(arr[i]);
    }
    return vec;
}
// вывод информации
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
// расчёт расстояния
double CalcLen(int[] dot1,int[] dot2){
    return Math.Sqrt(Math.Pow(dot1[0]-dot2[0],2)+Math.Pow(dot1[1]-dot2[1],2));
}

int[] dot1=InputNums("Введите координаты точки 1: ");
int[] dot2=InputNums("Введите координаты точки 2: ");
PrintData("Расстояние от точки 1, до дочки 2: ",CalcLen(dot1,dot2));