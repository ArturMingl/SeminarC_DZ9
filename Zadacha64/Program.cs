//Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

void NumberCounter(int number)
{
    if (number < 0)
        Console.WriteLine($"{number} не натуральное число");
    if (number == 0)
        return;
    Console.Write($"{number}, ");
    NumberCounter(number - 1);
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

NumberCounter(number);