//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Enter the number: ");
string? number = Console.ReadLine();
void CheckingNumber(string number) {
    if (number[0]==number[4] || number[1]==number[3]) {
        Console.WriteLine($"Your number {number} is a palindrome.");
    }
    else Console.WriteLine($"Your number {number} is not palindrome.");
}
if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Enter a five-digit number.");