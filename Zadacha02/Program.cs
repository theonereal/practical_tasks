﻿Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3> max)
{
    max = num3;
}

Console.WriteLine("Наибольшее из введенных чисел -> " + max);

Console.WriteLine();