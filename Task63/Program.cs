// Задача 63:
// Задайте значение N.
// Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.
// N = 5 –> 1, 2, 3, 4, 5
// N = 6 –> 1, 2, 3, 4, 5, 6

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Число не натуральное.");
    return;
}

Console.Write("Вариант 1 (FIFO): ");
NaturalNumbersAscending1(number);
Console.WriteLine();
Console.Write("Вариант 2 (LIFO): ");
NaturalNumbersAscending2(number);
Console.WriteLine();

void NaturalNumbersAscending1(int num, int i = 1) // FIFO
{
    if (i <= num) // Условие окончания рекурсии: не явное – когда i станет > num следующего вызова метода просто не будет.
    {
        Console.Write($"{i++} ");
        NaturalNumbersAscending1(num, i); // Хвостовая рекурсия (рекурсивный вызов – последний в методе):
    } // Простая – работает по принципу обычного цикла (стек создаётся, но не используется в алгоритме).
}

void NaturalNumbersAscending2(int num) // LIFO
{
    if(num == 0) return; // Условие окончания рекурсии: num уменьшился до 0.
    NaturalNumbersAscending2(num - 1); // Классическая рекурсия (работа со стеком – есть действия после вызова рекурсии):
    Console.Write($"{num} "); // Возвращает данные в порядке обратном получению.
}
