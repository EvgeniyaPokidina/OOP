//1.Массивы (Arrays): Создайте массив целых чисел и наполните его несколькими значениями от -10 до 10.
//int[] numbers = new int[21];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = i -10;
//}
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//2.Списки (List): Создайте список строк и добавьте в него несколько элементов произвольных имен.
List<string> strings = new List<string>() { "Tom", "Bob", "Sam" };
foreach (string name in strings)
{
    Console.WriteLine(name);
}
//3.  Стек (Stack): Инициализируйте стек целых чисел и добавьте несколько элементов.
//4. Продемонстрируйте операции добавления и извлечения элементов из стека.

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(15);
stack.Push(20);
int poppedItem = stack.Pop();
Console.WriteLine();
foreach (int num in stack)
{
    Console.WriteLine(num);
}
//5. Очередь (Queue): Создайте очередь строк и добавьте в нее элементы.
Queue<string> queue = new Queue<string>();
queue.Enqueue("hello");
queue.Enqueue("world");
Console.WriteLine();
foreach (string item in queue)
{
    Console.WriteLine(item);
}
//6. 
Dictionary<string, int> ageDictionary= new Dictionary<string, int>();
ageDictionary["Alice"] = 25;
int aliceAge = ageDictionary["Alice"];
Console.WriteLine(aliceAge);
//7
HashSet<int> numbers = new HashSet<int>();
numbers.Add(155);
numbers.Add(255);
numbers.Add(300);
Console.WriteLine();
foreach (int item in numbers)
{
    Console.WriteLine(item);
}
//8
Dictionary<int, string> dictionary = new Dictionary<int, string>
{
{ 27 , "Bob" },
{ 23 , "Tom" },
{ 31 , "Tomas" }
};
foreach (KeyValuePair<int, string> kvp in dictionary)
{
    int key = kvp.Key;
    string value = kvp.Value;
    Console.WriteLine($"Key: {key}, Value: {value}");
}