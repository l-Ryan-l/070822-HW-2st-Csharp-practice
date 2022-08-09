// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот 
// день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);

if((dayNumber > 5 ) && (dayNumber < 8))
    Console.WriteLine("Это выходной.");

else if ((dayNumber < 1) || (dayNumber > 7))
    Console.WriteLine("Такого дня недели нет.");

else 
    Console.WriteLine("Это рабочий день.");

