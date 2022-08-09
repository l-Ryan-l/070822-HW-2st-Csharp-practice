// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!); 

if((userNumber / 100 > 0) && (userNumber / 1000 == 0))
{
    int thirdDigit = userNumber % 10;
    Console.WriteLine (thirdDigit);
}
else 
{
    while(userNumber.Lenght > 3) // тут неправильно! как сделать? 
        userNumber = userNumber / 10;

    Console.Write("Число не трехзначное! Попробуйте снова...");
}

// Как составить цикл с проверкой до трехзначного?