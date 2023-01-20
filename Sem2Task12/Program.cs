//Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
// Заметки
// *=    "num"=48+num -> ASCII to int
// *=    NULL changed to zero ("0")

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num2%num1==0){
    Console.WriteLine("кратное");
}else{
    Console.WriteLine("не кратное "+num2%num1);
}