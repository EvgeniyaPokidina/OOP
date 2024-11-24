using Lesson_26;

Counter counter = new Counter(0);
Thread incrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        counter.Increment();
        Thread.Sleep(1000);
    }
});
Thread decrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        counter.Decrement();
        Thread.Sleep(1000); 
    }
});
incrementThread.Start();
decrementThread.Start();
incrementThread.Join();
decrementThread.Join();
Console.WriteLine($"Текущее значение счетчика: {counter.GetValue()}");
    