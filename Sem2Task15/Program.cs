﻿//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

var Working_Or_Not = new Dictionary<int, string>()
{
    { 1, "Это рабочий день недели"},
    { 2, "Это рабочий день недели"},
    { 3, "Это рабочий день недели"},
    { 4, "Это рабочий день недели"},
    { 5, "Это рабочий день недели"},
    { 6, "Это не рабочий день недели"},
    { 7, "Это не рабочий день недели"},
};
Console.WriteLine("Введите цифру обозначающую день недели");
int day = int.Parse(Console.ReadLine() ?? "0");
if ((day > 0) && (day < 8))
{
    Console.WriteLine(Working_Or_Not[day]);
}
else
{
    Console.WriteLine("ОГО! у на есть " + day + " дней?");
}
