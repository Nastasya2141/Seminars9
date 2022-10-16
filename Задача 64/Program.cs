/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int n = GetNumberFromConsole("Введите число N");
FindNatural(n);


void FindNatural(int n)
{   
    Console.Write($"{n} ");
    
    if (n == 1)
    {
        return ;
    }
    FindNatural (n-1);
    
}

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
