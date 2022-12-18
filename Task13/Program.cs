// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter your number:");
int a = int.Parse(Console.ReadLine()!);
if (a > 99)
{
    string str = a.ToString();
    Console.Write(str[2]);
}
else
{
    Console.Write("Sorry, there is no third figure here");
}