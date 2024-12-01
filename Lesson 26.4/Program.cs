await Task.Run(() => PrintSeconds());
Console.Write("Введите число для расчета факториала:");
int number=int.Parse(Console.ReadLine()!);
long factorialResult = await FactorialAsync(number);
Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
static void PrintSeconds()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"Секунда: {i}");
        Task.Delay(1000).Wait();
    }
}
static async Task<long> FactorialAsync(int n)
{
    long f = 1;
    for (int i = 1; i <= n; i++) f *= i;
    await Task.Delay(250);
    return f;
}
