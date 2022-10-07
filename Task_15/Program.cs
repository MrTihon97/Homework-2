// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введите день недели: ");
// string num = Console.ReadLine();

// if (num == "7")
// {
//  Console.WriteLine("Да, это выходной!");
// }
// else if (num == "6")
// {
//      Console.WriteLine("Да, это выходной!");
// }
// else if (num == "5")
// {
//      Console.WriteLine("Нет это не выходной");
// }
// else if (num == "4")
// {
//      Console.WriteLine("Нет это не выходной");
// }
// else if (num == "3")
// {
//      Console.WriteLine("Нет это не выходной");
// }
// else if (num == "2")
// {
//      Console.WriteLine("Нет это не выходной");
// }
// else if (num == "1")
// {
//      Console.WriteLine("Нет это не выходной");
// }
// else Console.WriteLine("Такого дня недели нет");

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("Нет это не выходной");
        break;
    case 2:
        Console.WriteLine("Нет это не выходной");
        break;
    case 3:
        Console.WriteLine("Нет это не выходной");
        break;
    case 4:
        Console.WriteLine("Нет это не выходной");
        break;
    case 5:
        Console.WriteLine("Нет это не выходной");
        break;
    case 6:
        Console.WriteLine("Да, это выходной!");
        break;
    case 7:
        Console.WriteLine("Да, это выходной!");
        break;

    default:
        Console.WriteLine("Такого дня недели нет");
        break;
}

