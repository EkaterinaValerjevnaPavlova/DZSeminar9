/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int start = ReadInt("Введите M: ");
int end = ReadInt("Введите N: ");

SumFromMToN(start, end);

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

int ReadInt(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine());
}