﻿// Нахождение максимума при n колличестве значений
int [] array = {1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length;
int find = 4;
int index = 0;
while(index < n);
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}