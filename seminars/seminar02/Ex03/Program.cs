//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру, обозначающию день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDay(int dayNumber)
{
    if(dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день выходной - да");
    }
    else if(dayNumber < 1 || dayNumber > 7) 
    {
        Console.WriteLine("не соответствует требованиям");
    }
    else Console.WriteLine("Этот день не выходной - нет");
}
CheckingDay(dayNumber);