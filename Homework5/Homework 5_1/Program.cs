// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("This is an array: ");
PrintArray(numbers);
int count = 0;
for (int index = 0; index < numbers.Length; index++)
if (numbers[index] % 2 == 0)
count++;

Console.WriteLine($"There are {numbers.Length} numbers, {count} of them are even.");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int index2 = 0; index2 < numbers.Length; index2++)
    {
        numbers[index2] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}