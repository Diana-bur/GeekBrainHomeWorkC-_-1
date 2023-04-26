﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int num = 2; // Так как отсчёт от 1, а выводим только чётные числа

if (max >= 2)
{
    while (num <= max)
    {
        if (num%2==0)
        {
            Console.Write(num + ", ");
        }
        num++;
    }
}
else
Console.WriteLine("Здесь нет чётных положительных чисел");
