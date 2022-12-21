/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if(DayNumber == 6 || DayNumber == 7)
{
    Console.Write("Является выходным - да");
} 
else if(DayNumber < 1 || DayNumber > 7)
{
    Console.Write("Введено некорректное значение");
}
else
{
    Console.Write("Не является выходным - нет");
}