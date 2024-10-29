public interface IListAnimal
{
    int Id { get; }
}
public class Animal : IListAnimal
{
    private static int idCounter = 1;
    public Animal(string nickName, string breed, DateTime acceptanceDate, int age)
    {
        Id = idCounter++;
        NickName = nickName;
        Breed = breed;
        AcceptanceDate = acceptanceDate;
        Age = age;
    }
    public int Id { get; }
    public string NickName { get; }
    public string Breed { get; }
    public DateTime AcceptanceDate { get; }
    public int Age { get; }
}
public class Animals<T> where T : IListAnimal
{
    private List<T> animalList = new List<T>();
    public void AddAnimal(T animal) => animalList.Add(animal);
    public IEnumerable<T> GetAnimals() => animalList;
}
class Program
{
    static void Main()
    {
        Animals<Animal> animals = new Animals<Animal>();
        animals.AddAnimal(new Animal("Charlie", "Labrador", DateTime.Parse("2024-10-25"), 2));
        animals.AddAnimal(new Animal("Max", "Bulldog", DateTime.Parse("2024-09-15"), 3));
        animals.AddAnimal(new Animal("Bella", "Beagle", DateTime.Parse("2024-06-27"), 1));
        Console.WriteLine("Список животных в приюте:");
        foreach (var animal in animals.GetAnimals())
        {
            Console.WriteLine($"ID: {animal.Id}, Кличка: {animal.NickName}, " +
                $"Порода: {animal.Breed}, Дата поступления: {animal.AcceptanceDate.ToShortDateString()}, " +
                $"Возраст: {animal.Age} лет");
        }
    }   
}