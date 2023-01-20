// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

//V1
System.Random randNum=new System.Random();
// int num=randNum.Next(10,99);
// int num1=num%10;
// int num2=num/10;
// Console.WriteLine(num);
// if (var1>var2){
//     Console.WriteLine("первое больше");
// }else{
//     Console.WriteLine("второе больше");
// }

//V2
char[] nums=randNum.Next(10,99).ToString().ToCharArray();
int n1=(int)nums[0]-48;
int n2=(int)nums[1]-48;
int res=n1>n2?n1:n2;
Console.WriteLine(nums);
if ((int)nums[0]-48>(int)nums[1]-48){
    Console.WriteLine("первое больше "+res);
}else{
    Console.WriteLine("второе больше "+res);
}

//V3
