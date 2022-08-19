//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Введите первое число: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите втрое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Певрое число больше!");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше!");
}
else
{
    Console.WriteLine("Они равны");
}

