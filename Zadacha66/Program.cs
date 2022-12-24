//Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N


int SumNumber(int numberM, int numberN)
{
    if (numberM == numberN) return 0;
    if (numberM < numberN) return numberN + SumNumber(numberM, numberN - 1);
    else return numberN + SumNumber(numberM, numberN + 1);
}

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Сумма чисел от {numberM} до {numberN} равна {SumNumber(numberM, numberN)}");