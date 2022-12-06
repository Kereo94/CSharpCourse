//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ

Console.Write("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int n = Number;
int revers = 0;
while (Convert.ToBoolean(Number))
{
    int r = Number % 10;
    revers = revers * 10 + r;
    Number = Number / 10;
}
if(n == revers)
{
    Console.Write("Это палиндром!");
}
else
{
    Console.Write("Это не палиндром!");
}