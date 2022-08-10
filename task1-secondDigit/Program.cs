// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int userNumber = int.Parse(Console.ReadLine()!); 

if ((userNumber / 100 > 0) && (userNumber / 1000 == 0))
{
    userNumber = userNumber / 10;
    int secondDigit = userNumber % 10;
    Console.WriteLine (secondDigit);
}
else 
{
    Console.Write("Число не трехзначное! Попробуйте снова...");
}