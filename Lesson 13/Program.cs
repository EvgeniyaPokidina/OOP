using Lesson_13;
string filePath = "animals.txt";
List<Animal> animals = new List<Animal>
{
new Carnivore(1, "Лев", 500),
new Omnivore(2, "Медведь", 2500),
new Herbivore(3, "Слон", 15000),
new Carnivore(4, "Тигр", 700),
new Omnivore(5, "Волк", 1000),
new Herbivore(6, "Овца", 3000)
};
SaveAnimalsToFile(filePath, animals);
static void SaveAnimalsToFile(string filePath, List<Animal> animals)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (var animal in animals)
        {
            writer.WriteLine($"{animal.Id},{animal.Name},{animal.GetType().Name},{animal.GetFoodAmount()}");
        }
    }
    Console.WriteLine("Список животных по количеству пищи:");
    foreach (var animal in animals)
    {
        animal.CalculateFood();
        Console.WriteLine($"ID: {animal.Id}, Имя: {animal.Name}, Тип: {animal.GetType().Name}");
    }
}