using Lesson_11;

Cashier cashier = new Cashier()
{
    FIO = "Иванова Мария Петровна"
};
Driver driver = new Driver()
{
    FIO="Иванов Иван Иванович",
    Licence= "123 489"
};
Car car = new Car()
{
    Number = "A123BC",
    Model="Камаз"
};
Race race = new Race()
{
    Number=1,
    Destination="Черняховск",
    TimeDeparture= DateTime.Parse("10:40:00")
};
Order order = new Order(driver, race, car, cashier, DateTime.Parse("2024.07.16 13:25"));
Console.WriteLine(order);
driver.CompleteRace(order);
Console.WriteLine(order);
driver.Repair(car);
Console.WriteLine(car);