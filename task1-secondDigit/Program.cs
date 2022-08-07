// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int userNumber = int.Parse(Console.ReadLine()!); 

// if ((a / 10 > 0) && (a / 100 == 0))
if ((userNumber / 100 > 0) && (userNumber / 1000 == 0))
{
    //userNumber = userNumber / 10;
    Console.WriteLine (userNumber);
}
else 
{
    Console.Write("Число не трехзначное!");
}