Console.Clear();

string rec(int n)
{
    if (n == 1)
        return $"{n}";
    return $"{n}, " + rec(n-1);
}

Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(n));