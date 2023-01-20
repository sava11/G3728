// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// // считываемые данные от пользователя
// int cord(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int x = cord("Введите значение координаты X1: ");
// int y = cord("Введите значение координаты Y1: ");
// int x1 = cord("Введите значение координаты X2: ");
// int y1 = cord("Введите значение координаты Y2: ");
// void PrintLen(int x, int y,int x1, int y1){
//     Console.WriteLine(Math.Sqrt(Math.Pow(x-x1,2)+Math.Pow(y-y1,2)));
// }
// PrintLen(x, y, x1, y1);


// считываемые данные от пользователя
int cord(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим данные
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
// Расстояние между точками в 2d пространстве
double CalcLen(int x, int y, int x1, int y1)
{
    double res=Math.Sqrt(Math.Pow(x-x1,2)+Math.Pow(y-y1,2));
    return res;
}
// Вводим данные
int x = cord("Введите значение координаты X1: ");
int y = cord("Введите значение координаты Y1: ");
int x1 = cord("Введите значение координаты X2: ");
int y1 = cord("Введите значение координаты Y2: ");
PrintData("Расстояние: ",CalcLen(x, y, x1, y1));