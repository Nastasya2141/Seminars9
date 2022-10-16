/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine ("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
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