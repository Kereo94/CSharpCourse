//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Напишите любое число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());
string threeNumberText = Convert.ToString(threeNumber);
if (threeNumberText.Length > 2)
{
    Console.WriteLine("третья цифра этого числа - " + threeNumberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}