// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter weekday number:");
int a = Convert.ToInt32(Console.ReadLine());
if (a==6 || a==7)
{
    Console.Write("Eeee, it's weekend :-)");
}
else
{
    Console.Write("Sorry, it's working day :-(");
}