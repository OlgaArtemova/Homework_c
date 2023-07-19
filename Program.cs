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
/*
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
*/

// Задача 19 : Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void CheckArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
            Console.Write("Число является палиндромом");
        else
            Console.Write("Число не является палиндромом");
    }
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int temp = num;
int count = 0;
while (temp != 0)
{
    temp = temp / 10;
    count++;
}

int[] array = new int[count];
for (int i = 0; i < array.Length; i++)
{
    array[i] = num % 10;
    num /= 10;
}
CheckArray(array);
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double Distance (int x1, int y1, int z1, int x2, int y2,  int z2 )
{
   double result = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
   return result;
}
int x1 = InputNum("Введите координату x1: ");
int y1 = InputNum("Введите координату y1: ");
int z1 = InputNum("Введите координату z1: ");
int x2 = InputNum("Введите координату x2: ");
int y2 = InputNum("Введите координату y2: ");
int z2 = InputNum("Введите координату z2: ");


double res = Distance (x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(Math.Round(res, 2));
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)}");
    {
        if (i < n)
        {
            System.Console.Write(", ");
        }
    else
    {
            System.Console.Write(" ");
        }
    }
}
*/
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int AToDegreeB(int num, int deg)
{
    int result = 1;
    for (int i = 0; i <= deg; i++)
    {
        result = result * num;
    }
    return result;
}
int A = InputNum("Введите число A");
int B = InputNum("Введите число B");
int res = AToDegreeB(A, B);
System.Console.WriteLine(res);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumOfDigits(int number)
{
    int sum = 0;
    int digit = 0;

    while ( number != 0)
    {
        digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

int num = InputNum("Введите число");
int sumOfDig = SumOfDigits(num);
System.Console.WriteLine($"Сумма цифр числа {num} равна {sumOfDig}");
*/
/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int InputNum (string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine()!);
}

int [] ArrayRandom( int size, int startNum, int finishNum)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(startNum, finishNum);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         System.Console.Write(array[i] + " ");
    }
}
int quantity = InputNum("Сколько чисел будет в массиве?");
int start = InputNum("Введите начальное значение диапазона: ");
int finish = InputNum("Введите конечное значение диапазона: ");
int [] res = ArrayRandom(quantity, start, finish);
PrintArray(res);
*/
/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

int FindQuantityNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}
int size = InputNum("Введите размер массива: ");

int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int quantity = FindQuantityNum(myArray);
Console.WriteLine($"Количество четных элементов равно: {quantity}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

int SumNumOddPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
System.Console.WriteLine(txt);
int summa = SumNumOddPos(myArray);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {summa}");
*/
/*
// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()+rnd.Next(min, max), 2);
    }
}

string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < min)
       min = array[i]; 
    }
    return min;
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > max)
       max = array[i]; 
    }
    return max;
}

double Differece(double[] array, double	maxOfAr, double	minOfAr)
{
    double diff = maxOfAr - minOfAr;
    return diff;
}
int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

double[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue );
string txt = PrintArray(myArray);
System.Console.WriteLine(txt);

double minimum = FindMin(myArray);
double maximum = FindMax(myArray);
System.Console.WriteLine(minimum);
System.Console.WriteLine(maximum);
double find = Differece(myArray, minimum, maximum);
System.Console.WriteLine($"Разность между максимальным и минимальным значением массива равно:{find}");
*/

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNum($"Введите {i + 1} число: "); ;
    }
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

int FindPosNums(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

int size = InputNum("Введите количество чисел: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
System.Console.WriteLine(txt);
int quantity = FindPosNums(myArray);
System.Console.WriteLine($"Количество чисел больше 0 равно {quantity}");
*/
/*
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

string CrossPoint(double a1, double c1, double a2, double c2)
{
    if (a1 == a2 && c1 == c2) return "Прямые совпадают";
    else
    if (a1 == a2) return "Прямые параллельны";
    double x = Math.Round((a2 - a1) / (c1 - c2), 1);
    double y = Math.Round((c1 * a2 - c2 * a1) / (c1 - c2), 1);
    return $"({x}; {y})";
}

int b1 = InputNum("Введите значение b1: ");
int k1 = InputNum("Введите значение k1: ");
int b2 = InputNum("Введите значение b2: ");
int k2 = InputNum("Введите значение k2: ");

string result = CrossPoint(b1, k1, b2, k2);
System.Console.WriteLine(result);
*/
/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int rows, int cols)
{
    return new double[rows, cols];
}
void Fill2DArray(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 1);
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

double[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//1 вариант
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void FindNumCoord(int[,] array, int coordI, int coordJ)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == coordI - 1 && j == coordJ - 1)
            {
                Console.Write($"Значение элемента с координатами ({coordI}, {coordJ}) равно {array[i, j]}");
            }
            else Console.Write($"Такого элемента не существует");
        }
        Console.WriteLine();
    }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");
int findI = InputNum("Введите номер строки: ");
int findJ = InputNum("Введите номер столбца: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
FindNumCoord(myArray, findI, findJ);
*/
/*
//2 вариант

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void FindSerialNum(int[,] array, int find)
{
    int check = 0;
    if (find > array.Length)
    {
        Console.WriteLine($"Такого элемента не существует");
    }
    else
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                check++;
                if (check == find)
                {
                    Console.WriteLine($"Значение элемента с порядковым номером {find} равно {array[i, j]}");
                }
            }
        }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");
int serial = InputNum("Введите порядковый номер числа: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
FindSerialNum(myArray, serial);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void ArithmeticMeanColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double average = Math.Round(sum / array.GetLength(0), 1);
        Console.Write($"{average}\t");
    }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
ArithmeticMeanColumns(myArray);
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int col = 0; col < array.GetLength(1) - 1 - j; col++)
            {
                if (array[i, col] > array[i, col + 1])
                {
                    int temp = array[i, col];
                    array[i, col] = array[i, col + 1];
                    array[i, col + 1] = temp;
                }
            }
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
SelectionSort(myArray);
Print2DArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[] FindSumOfRow(int[,] array)
{
    int[] summa = new int[array.GetLength(1)];
    int s = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        summa[s] = sum;
        //System.Console.Write(summa[s] + " ");
    }
    return summa;
}

int FindMinSum(int[] arraySum)
{
    int minIndex = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        int min = arraySum[0];
        if (arraySum[i] < min) min = arraySum[i];
        minIndex = i;
    }
    return minIndex;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов, не равное количеству строк: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int[] sumArray = FindSumOfRow(myArray);
int result = FindMinSum(sumArray);
Console.WriteLine($"Наименьшая сумма элементов в строке номер {result}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void MultiplicationOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.Write($"Операция невозможна");
    }
    else
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    newMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        Print2DArray(newMatrix);
    }
}

int rowsFirst = InputNum("Введите количество строк первой матрицы: ");
int columnsFirst = InputNum("Введите количество столбцов первой матрицы: ");
int rowsSecond = InputNum("Введите количество строк второй матрицы: ");
int columnsSecond = InputNum("Введите количество столбцов второй матрицы: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArrayFirst = Create2DArray(rowsFirst, columnsFirst);
Fill2DArray(myArrayFirst, minValue, maxValue);
Print2DArray(myArrayFirst);

Console.WriteLine();

int[,] myArraySecond = Create2DArray(rowsSecond, columnsSecond);
Fill2DArray(myArraySecond, minValue, maxValue);
Print2DArray(myArraySecond);
Console.WriteLine();
MultiplicationOfMatrix(myArrayFirst, myArraySecond);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int cols, int layer)
{
    return new int[rows, cols, layer];
}
int[] CreateArray(int rows, int cols, int layer)
{
    return new int[rows * cols * layer];
}

void Fill3DArray(int[,,] array3D, int[] array)
{
    if (array3D.Length <= 90)
    {
        Random rnd = new Random();
        array[0] = rnd.Next(10, 100);
        for (int i = 1; i < array.Length; i++)
        {
            int number = rnd.Next(10, 100);
            for (int j = 0; j < i; j++)
            {
                if (number == array[j])
                {
                    number = rnd.Next(10, 100);
                    j = 0;
                }
            }
            array[i] = number;
        }
        int num = 0;
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    array3D[i, j, k] = array[num];
                    Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k})\t");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначными числами");
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int layers = InputNum("Введите количество слоев: ");

int[,,] my3DArray = Create3DArray(rows, columns, layers);
int[] myArray = CreateArray(rows, columns, layers);
Fill3DArray(my3DArray, myArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int[,] matrix = new int[4, 4];

void FillArrey(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.Length)
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArrey(matrix);
PrintArray(matrix);
*/

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNum(int n)
{
    if (n == 1) return n.ToString();
    return (n + " " + PrintNum(--n));
}

int num = InputNum("Введите целое число: ");
System.Console.Write(PrintNum(num));
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SumNumbers(int start, int end)
{
    if (start == end) return end;
    return (start + SumNumbers(++start, end));
}

int M = InputNum("Введите целое число M: ");
int N = InputNum("Введите целое число N: ");
System.Console.Write(SumNumbers(M, N));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Ackerman(int M, int N)
{
    if (M == 0) return N + 1;
    else
    if (M > 0 && N == 0) return Ackerman(M - 1, 1);
    else
    if (M > 0 && N > 0) return Ackerman(M - 1, Ackerman(M, N - 1));
    return Ackerman(M, N);
}
int m = InputNum("Введите целое число m: ");
int n = InputNum("Введите целое число n: ");
System.Console.Write(Ackerman(m, n));