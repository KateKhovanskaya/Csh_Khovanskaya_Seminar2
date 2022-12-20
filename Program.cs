// Задача 1.
Console.WriteLine("Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Введите трехзначное число");
int num11=int.Parse(Console.ReadLine()!);
while(num11<100 || num11>999)
{
   Console.WriteLine("Число не является трехзначным, введите трехзначное число");
   num11=int.Parse(Console.ReadLine()!); 
}
Console.WriteLine($"Вторая цифра числа - {num11%100/10}");

//Задача 2.
Console.WriteLine("Задача 2.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число от 0 до 100 000");
int num21=int.Parse(Console.ReadLine()!);
while(num21>=100000 || num21<0)
{
   Console.WriteLine("Число больше 100 000 или меньше 0, введите положительное число меньше 100 000");
   num21=int.Parse(Console.ReadLine()!); 
}

if(num21>=0 && num21<100){Console.WriteLine("Третьей цифры нет");}
if(num21>=100 && num21<1000){Console.WriteLine($"Третья цифра числа {num21%10}");}
if(num21>=1000 && num21<10000){Console.WriteLine($"Третья цифра числа {num21%100/10}");}
if(num21>=10000 && num21<100000){Console.WriteLine($"Третья цифра числа {num21%1000/100}");}