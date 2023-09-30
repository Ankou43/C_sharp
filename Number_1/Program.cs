Console.Write("Введи число A: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи степень числа B: ");
int s = Convert.ToInt32(Console.ReadLine());
// int sum = Convert.ToInt32(Math.Pow(n, s));
// Console.WriteLine("Результат: " + sum);

int i = 0;
int res = 1;

while (i < s)
{
    res = res * n;
    i++;
}

Console.WriteLine("Результат A ^ B: " + res);