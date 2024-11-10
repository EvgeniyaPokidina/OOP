using Microsoft.VisualBasic;

class Employee
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value;
    }
    private int id;
    public int Id
    {
        get => id;
        set => id = value;
    }
    private List<Task> tasks = new List<Task>();
    public List<Task> Tasks
    {
        get => tasks;
        set => tasks = value;
    }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

}
enum Priority
{
    Low, Medium, High
}
interface ITask
{
    string Title { get; set; }
    DateTime DueDate { get; set; }
    Priority Priority { get; set; }
    void Display();
}
class Task : ITask
{
public string Title { get; set; }
public DateTime DueDate { get; set; }
public Priority Priority { get; set; }
public void Display()
{
    Console.WriteLine(Title + " " + DueDate + " " + Priority);
}
    

}


//////////
///enum Priority
//{
//    Low,
//    Medium,
//    High
//}

//interface ITask
//{
//    string Title { get; set; }
//    DateTime DueDate { get; set; }
//    Priority Priority { get; set; }
//    void Display();
//}

//class Task : ITask, ICloneable
//{
//    public string Title { get; set; }
//    public DateTime DueDate { get; set; }
//    public Priority Priority { get; set; }

//    public void Display()
//    {
//        Console.WriteLine($"Задача: {Title}, Дата окончания: {DueDate.ToShortDateString()}, Приоритет: {Priority}");
//    }

//    public object Clone()
//    {
//        return new Task
//        {
//            Title = this.Title,
//            DueDate = this.DueDate,
//            Priority = this.Priority
//        };
//    }
//}

//class Employee : IComparable<Employee>, IEnumerable<Task>
//{
//    private string name;
//    public string Name
//    {
//        get => name;
//        set => name = value;
//    }

//    private int id;
//    public int Id
//    {
//        get => id;
//        set => id = value;
//    }

//    
//    public void AddTask(Task task)
//    {
//        Tasks.Add(task);
//    }

//    public void DisplayTasks()
//    {
//        Console.WriteLine($"Задачи сотрудника {Name} (ID: {Id}):");
//        foreach (var task in Tasks)
//        {
//            task.Display();
//        }
//    }

//    public int CompareTo(Employee other)
//    {
//        // Сравнение по количеству задач, затем по имени и приоритету первой задачи
//        if (this.Tasks.Count != other.Tasks.Count)
//            return this.Tasks.Count.CompareTo(other.Tasks.Count);

//        if (this.Tasks.Count > 0 && other.Tasks.Count > 0)
//        {
//            int priorityComparison = this.Tasks[0].Priority.CompareTo(other.Tasks[0].Priority);
//            if (priorityComparison != 0)
//                return priorityComparison;
//        }

//        return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
//    }

//    public IEnumerator<Task> GetEnumerator()
//    {
//        return Tasks.GetEnumerator();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>();

//        // Добавление сотрудников и задач
//        var employee1 = new Employee("Иван Иванов", 1);
//        employee1.AddTask(new Task { Title = "Подготовить отчет", DueDate = DateTime.Now.AddDays(3), Priority = Priority.High });
//        employee1.AddTask(new Task { Title = "Собеседование", DueDate = DateTime.Now.AddDays(7), Priority = Priority.Medium });

//        var employee2 = new Employee("Петр Петров", 2);
//        employee2.AddTask(new Task { Title = "Исследование рынка", DueDate = DateTime.Now.AddDays(5), Priority = Priority.Low });

//        employees.Add(employee1);
//        employees.Add(employee2);

//        // Отображение сотрудников и их задач
//        Console.WriteLine("Список сотрудников и их задач:");
//        foreach (var employee in employees)
//        {
//            employee.DisplayTasks();
//        }

//        // Сортировка сотрудников
//        employees.Sort();
//        Console.WriteLine("\nОтсортированный список сотрудников:");
//        foreach (var employee in employees)
//        {
//            Console.WriteLine($"Сотрудник: {employee.Name}, ID: {employee.Id}, Количество задач: {employee.Tasks.Count}");
//        }

//        // Демонстрация глубокого клонирования задач
//        var clonedTask = (Task)employee1.Tasks[0].Clone();
//        Console.WriteLine("\nКлонированная задача:");
//        clonedTask.Display();

//        // Изменение оригинальной задачи
//        employee1.Tasks[0].Title = "Обновить отчет";
//        Console.WriteLine("\nПосле изменения оригинальной задачи:");
//        employee1.DisplayTasks();
//        Console.WriteLine("Клонированная задача осталась прежней:");
//        clonedTask.Display();
//    }
//}