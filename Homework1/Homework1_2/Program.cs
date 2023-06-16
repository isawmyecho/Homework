// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Enter the first number:");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number:");
int numb3 = Convert.ToInt32(Console.ReadLine());
int max;
if (numb1 > numb2 && numb1>numb3)
    {
        max = numb1;
        Console.WriteLine("Maximum number is:" + max);
    }
    else
        {
            if (numb2 > numb3)
             {max = numb2;
            Console.WriteLine("Maximum number is:" + max);
             }
        
           else
           {
            max = numb3;
            Console.WriteLine("Maximum number is:" + max);
           }
        }