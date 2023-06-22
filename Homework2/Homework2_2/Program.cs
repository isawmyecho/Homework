// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Input the number: ");
int someNumber = Convert.ToInt32(Console.ReadLine());
string someLength = Convert.ToString(someNumber);
if (someLength.Length > 2)
{
    Console.WriteLine("The third digit of this number is " + someLength[2]);
}
else
{
    Console.WriteLine("No third digit. ");
}