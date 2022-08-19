//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Я программа и сравниваю три целых числа числа и выдаю самое большое");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите втрое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max=");
Console.Write(max);

