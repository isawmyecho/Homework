// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Enter first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
int min;
int max;
if (number1<number2)
    {
        min = number1;
        max=number2;
    }
else
    {
        min=number2;
        max=number1;
    }
    Console.WriteLine("Minimum number is:" + min);
    Console.WriteLine("Maximum number is:" + max);
