// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру данного числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int userNumber = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число: {userNumber}");

int digit1 = userNumber / 100;
int digit3 = userNumber % 10;

Console.Write($"Преобразованное число: {digit1}{digit3}");
