Task <int>sumTask = Task.Run(() => Sum(5, 10));
int sumResult = sumTask.Result; 
Console.WriteLine($"Сумма: {sumResult}");
Task taskPrint = new Task(Print);
taskPrint.Start();
Task<long> taskFact = Task.Run(() => Fact(9));
long FactResult= taskFact.Result;
Console.WriteLine($"Факториал числа 9 равен {FactResult}");
var writeToFileTask = Task.Run(() => WriteToFile("“Каждый день на планете Гиперион был особенным" +
    " для блоглорпов. Они проводили свои утренние ритуалы, слушая мелодии, которые\n" +
    "цветы-композиторы создавали для них на дне океанов. Каждый аккорд и\n" +
    "нота наполняли воздух магией и вдохновением."));
writeToFileTask.Wait();
Console.WriteLine("Запись в файл произведена");
int Sum(int a, int b) => a + b;
void Print()
{
    Console.WriteLine("На далекой планете в галактике Гиперион, где небеса были\n" +
        "разукрашены яркими звездами и лазурными небесами, жили странные\nсущества,\n"+
        "известные как блоглорпы. Блоглорпы были маленькими,\n" +
        "пушистыми созданиями с шестиугольными глазами и тройными\n" +
        "хвостами. Их домами были деревья, выращенные из кристаллов, и они\n" +
        "питались музыкой, которую производили цветы, растущие на дне их\n" +
        "океанов. Вечными друзьями блоглорпов были музыкальные киты,\n" +
        "которые пели им мелодии о магии вселенной и тайнах времени.");
}
long Fact(int n)
{
    long f = 1;
    for (int i = 1; i <= n; i++) f *= i;
    return f;
}
static void WriteToFile(string text)
{
    File.WriteAllText("output.txt", text);
}