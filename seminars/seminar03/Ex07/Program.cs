/*
Дополнительно
Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11
*/

bool IsPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Простые числа от 1 до {N}:");
List<int> primeNumList = new List<int>();

for (int i = 2; i <= N; i++)
{
    if (IsPrime(i))
    {
        primeNumList.Add(i);        
    }
}

string result = string.Join(", ", primeNumList);
Console.WriteLine(result);