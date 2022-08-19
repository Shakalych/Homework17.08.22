//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Определю является ли введеное тобой число четным!");
Console.WriteLine("Введи число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Не четное");
}



