﻿/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
string input = Console.ReadLine();

if(input[0] == input[4] && input[1] == input[3])
{
    Console.Write("Является палиндромом");
}
else
{
    Console.Write("Не является палиндромом");
}