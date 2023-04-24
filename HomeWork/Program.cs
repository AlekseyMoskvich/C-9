/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNambersBetween(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write($"{n} ");

    n--;

    PrintNambersBetween(n);
}

//PrintNambersBetween(5);


/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum = 0;

int GetSumOfNumbers(int m, int n)
{
    if (m > n)
    {
        return sum;
    }

    sum += m;
    m++;

    GetSumOfNumbers(m, n);

    return sum;
}

//int sum1 = GetSumOfNumbers(1, 15);

//Console.WriteLine(sum1);


/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число m: ");

int m = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");

int n = int.Parse(Console.ReadLine());

int result = A(m, n);

Console.WriteLine(result);

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }    
    if (m != 0 && n == 0)
    {
        return A(m - 1, 1);
    }    
    if (m > 0 && n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    return A(m, n);
}
