// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int m = InputInt("Input M:");
int n = InputInt("Input N:");
Console.WriteLine($"Sum of elements from {m} to {n} = {NaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int NaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalSum(m, n - 1);
}