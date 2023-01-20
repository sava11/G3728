// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// считываемые данные от пользователя
int cord(string s)
{
    Console.Write("Введите значение "+s+": ");
    return int.Parse(Console.ReadLine() ?? "0");
}
int x = cord("X");
int y = cord("Y");
// Метод определения четверти по координатам точки
void PrintQuterTest(){
    if (x>0&&y>0)Console.WriteLine("Точка в первой четверти");
    if (x>0&&y<0)Console.WriteLine("Точка в второй четверти");
    if (x<0&&y>0)Console.WriteLine("Точка в третей четверти");
    if (x<0&&y>0)Console.WriteLine("Точка в четвёртой четверти");
}
PrintQuterTest();