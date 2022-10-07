// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трёхзначное число");


int number = Convert.ToInt32(Console.ReadLine());
int FirstDigit = number / 100;
int SeondDigit = number % 10;
int delenie = FirstDigit * 100 + SeondDigit;
int secondnum = number - delenie;
int res = secondnum / 10;


if (number >= 100 && number <= 999)
{
    Console.Write($"Вторая цифра числа {number} => {res}");
}
else Console.Write("Число не трёхзначное");