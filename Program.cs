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
/*
Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;
while (i <= N)
{
    Console.Write(i);
    if (i < N-1)
    {
        Console.Write(",");
    }
    else Console.Write(".");
    i = i + 2;
}
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int FindSecondDigit(int number)
{
    int second = (number/10)%10;
    return second;
}
int num = InputNum("Введите трехзначное число");
int result = FindSecondDigit(num);
Console.WriteLine($"Вторая цифра числа {num} - {result}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int num = InputNum ("Введите целое число");
int FindThirdDigit(int number)
{
     while (number>999)
     {
        number = number/10;
        
     }
     return number%10;
}

bool CheckNumber (int numb)
{
if (numb < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;

} 
CheckNumber(num); 
Console.WriteLine($"Третья цифра - {FindThirdDigit(num)}");
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
string Weekend (int number)
{
    string res = "Это не выходной день";
    if (number == 6 || number == 7)
    res = "Выходной день";
    return res;
}
int num = InputNum("Введите число от 1 до 7");
string result = Weekend (num);
Console.WriteLine(result);
