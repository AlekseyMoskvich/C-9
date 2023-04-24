/*Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

/*
int i = 1;

void PrintNambersBetween1AndN(int n)
{
    if(i > n)
    {
        return;
    }

    Console.Write($"{i} ");

    i++;

    PrintNambersBetween1AndN(n);
}

PrintNambersBetween(5);

*/
/*Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/

void PrintNambersBetween(int m, int n)
{
    if (m > n)
    {
        return;
    }

    Console.Write($"{m} ");

    m++;

    PrintNambersBetween(m, n);
}

//PrintNambersBetween(4, 8);


/*Задача 67: Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/

/*
Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

int sum = 0;

int sum1 = GetSumOfNumbers(num);

Console.WriteLine(sum1);

int GetSumOfNumbers(int num)
{
    if (num == 0)
    {
        return sum;
    }

    sum += num % 10;
    num = num / 10;

    GetSumOfNumbers(num);

    return sum;
}


*/
/*Задача 69: Напишите программу, которая на вход принимает два числа 
A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/


int a = DataInput();
int b = DataInput();
int sum = DegreeNumber(a, b);
Console.WriteLine($"{a}, {b} -> {sum}");

int DegreeNumber(int a, int b)
{
    if (b > 0)
    {
        int degree = a;
        b = b - 1;
        return DegreeNumber(a, b) * degree;
    }
    return 1;
}

int DataInput()
{
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}