// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Input the three-digit number:");
int threeDigNumber = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(threeDigNumber);
Console.WriteLine("The second digit of this number is " + stringNum[1]);
