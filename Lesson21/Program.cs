//Задача 1
//class Program
//{
//    public delegate int Summ(int x, int y);
//    public static void Main()
//    {
//        Summ add = delegate (int x, int y)
//        {
//            return x + y;
//        };
//        int result = add(25, 18);
//        Console.WriteLine("Результат сложения:" + result);
//    }
//}

//Задача 2
//class MasString
//{
//    static void Main()
//    {
//        string[] words = { "Apple", "Banana", "Avocado", "Cherry", "Apricot" };
//        foreach (var word in words.Where(word => word.StartsWith("A")))
//        {
//            Console.WriteLine(word);
//        }
//    }
//}

//Задача 3
double Add(double x, double y) => x + y;
double Sub(double x, double y) => x - y;
double Mult(double x, double y) => x * y;
double Div(double x, double y) => x / y;
Operation[] delMas = new Operation[4];
delMas[0] = Add; delMas[1] = Sub; delMas[2] = Mult; delMas[3] = Div;
Console.Write("Введите 1 число:");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число:");
double y = double.Parse(Console.ReadLine()!);
Console.Write("Введите операцию:");
char op = char.Parse(Console.ReadLine()!);
switch (op)
{
    case '+': Console.WriteLine(delMas[0](x, y)); break;
    case '-': Console.WriteLine(delMas[1](x, y)); break;
    case '*': Console.WriteLine(delMas[2](x, y)); break;
    case '/': Console.WriteLine(delMas[3](x, y)); break;
}
delegate double Operation(double x, double y);

