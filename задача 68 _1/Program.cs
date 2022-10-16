/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = GetNumberFromConsole("Введите число M");
int n = GetNumberFromConsole("Введите число N");
Console.WriteLine($"А({m},{n})={AckermanFunction(m,n)}");



int AckermanFunction(int m, int n)
{
    if (m == 0)
       return n+ 1;
    if (m != 0 && n == 0)
       return AckermanFunction(m - 1, 1);
    if (m > 0 && n> 0) 
       return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m,n);
}


int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
