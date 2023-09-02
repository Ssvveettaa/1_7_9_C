// Задача 69:
// Напишите программу, которая
// на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 –> 243 (3^5)
// A = 2; B = 3 –> 8

Console.Write("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 1)
{
    Console.WriteLine("Число B не натуральное.");
    return;
}

Console.WriteLine(PowNum(numberA, numberB));

int PowNum(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * PowNum(numA, numB - 1);
}
