// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

// Вводим данные с консоли
Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
// Проверка на заполненность
if (inputNum != null){
    int num = int.Parse(inputNum);
    for (int i = 0; i < num*2; i++){
        //Вывод (номера шага -1) минус введённое число, затем вывод запятой с пробелом
        Console.Write(i-num);
        Console.Write(", ");
    }
    //Вывод конечной цифры
    Console.Write(num);
}