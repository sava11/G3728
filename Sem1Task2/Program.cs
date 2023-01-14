// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
string? inputNum1 = Console.ReadLine();// Ввод первого числа
string? inputNum2 = Console.ReadLine();// Ввод второго числа
if ((inputNum1!=null) && (inputNum2!=null)){
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    //Сравнение чисел
    if (num1>num2){
        //Вывод чисел 1
        Console.Write("min: ");Console.WriteLine(num2);
        Console.Write("max: ");Console.WriteLine(num1);
    }else{
        //Вывод чисел 2
        Console.Write("min: ");Console.WriteLine(num1);
        Console.Write("max: ");Console.WriteLine(num2);
        }
    }

