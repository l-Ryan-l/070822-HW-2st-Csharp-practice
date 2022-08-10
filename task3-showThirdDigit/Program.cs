// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!); 

if((userNumber / 100 > 0) && (userNumber / 1000 == 0))
{
    int thirdDigit = userNumber % 10;
    Console.Write($"3я цифра - {thirdDigit}");
}
else if (userNumber > 999)
 {
    while(userNumber > 999)
    userNumber = userNumber / 10;
    Console.WriteLine($"Третье число - {userNumber % 10}");
 }
else 
{
    Console.Write("Число не трехзначное! Второго числа нет. Попробуйте снова...");
}
