//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void weekendCheck (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("This day is a holiday. ");
    }  
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("This number is not included in the range of days of the week. ");
    }  
    else
    Console.WriteLine("This day in not holiday. ");
}
weekendCheck(dayNumber);
