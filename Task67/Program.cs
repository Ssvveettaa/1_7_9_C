// Задача 67:
// Напишите программу, которая
// будет принимать на вход число
// и возвращать сумму его цифр.
// 453 –> 12
//  45 –> 9

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(number));

int SumOfDigits(int num) // Параметр: 453, 45, 4, 0
{
    if (num == 0) return 0; // Условие окончания рекурсии: все разряды перебрали.
    return num % 10 + SumOfDigits(num / 10); // Стек: 453, 45, 4
} // return: 0 + 4 % 10 + 45 % 10 + 453 % 10
