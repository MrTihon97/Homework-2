﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");

int num = Convert.ToInt32(Console.ReadLine());
int res = (int)Math.Log10(num)-2;
Console.WriteLine(res < 0 ? "третьей цифры нет" : (num % (int)Math.Pow(10, res + 1) / (int)Math.Pow(10, res)).ToString());