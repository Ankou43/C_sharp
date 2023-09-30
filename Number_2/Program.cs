// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 10;
int res = n % 10;

while ((n / i) > 0)
{
    res = res + ((n / i) % 10);
    i = i * 10;
}

Console.WriteLine(res);