
Thread firstThread = new Thread(() => new Person().Print(new Person()));
firstThread.Start();
class Person
{

    public string? Name { get; set; }
    public int Age { get; set; }
    public void Print(object? message)
    {
        if (message is not Person)
        {
            throw new Exception("Передан не подходящий объект");
        }
        else
        {
            PrintPersonData((Person)message);
        }

    }
    public void PrintPersonData (Person person)
    {
        person.Name = "Виктор";
        person.Age = 22;
        Console.WriteLine($"Имя: {person.Name}  Возраст: {person.Age}");
    }

}





