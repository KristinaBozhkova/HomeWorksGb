﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число :");
int num1 = int.Parse (Console.ReadLine()??"0");

Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()??"0");

if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " "+"большe " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("Число " + num2 + " " + "больше " + num1);
}
else 
{
    Console.WriteLine("Числа равны");
}
