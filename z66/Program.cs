Console.Clear();

int sum(int m, int n)
{
    if (m == n)
        return n;
    return sum(m + 1, n) + m;
}

Console.WriteLine("Введите первое число: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(m, n));