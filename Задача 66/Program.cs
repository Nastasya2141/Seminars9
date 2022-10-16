/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m = GetNumberFromConsole("Введите число M");
int n = GetNumberFromConsole("Введите число N");
int result = 0;
SummNatural(n,m,result);

void SummNatural(int n, int m, int result)
{  
 
    if (m > n)
    {
        Console.WriteLine(result);
        return ;
    }

    result = result + (m++);
    SummNatural(n, m ,result );
}

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
