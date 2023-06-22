// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
string number = Console.ReadLine()!;
int num1 = int.Parse(number);
Console.Write("Введите второе число: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
if (num1 > num2)
{
    Console.WriteLine($"Максимальное число: {num1}");
}
else
{
    Console.WriteLine($"Максимальное число: {num2}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
string number = Console.ReadLine()!;
int num1 = int.Parse(number);
Console.Write("Введите второе число: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
Console.Write("Введите третье число: ");
number = Console.ReadLine()!;
int num3 = int.Parse(number);
if (num1 > num2)
{
    if (num3 > num1)
    {
        Console.WriteLine($"Максимальное число: {num3}");
    }
    else Console.WriteLine($"Максимальное число: {num1}");
}
else if (num2 > num3)
{
    Console.WriteLine($"Максимальное число: {num2}");
}
else
{
    Console.WriteLine($"Максимальное число: {num3}");
}
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите целое число: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);
Console.WriteLine(num%2 == 0);
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;
while (i <= N)
{
   Console.Write(i+",");
    i = i + 2;
    
}
