//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.WriteLine("Enter the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("This is an array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int index = 0; index < numbers.Length; index++)
{
    if (numbers[index] > max)
        {
            max = numbers[index];
        }
    if (numbers[index] < min)
        {
            min = numbers[index];
        }
}

Console.WriteLine($"There are {numbers.Length} numbers. Maximum value = {max}, minimum value = {min}");
Console.WriteLine($"Difference between maximum and minimum array elements = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}