using System.Drawing;

Person<Gender, string, Color> p1 = new Person<Gender, string, Color>("Bill", 20,
    "Town Mamba", "+7900453423", 170, 80, Gender.men, "негроидная", Color.Black);
Person<string, string, Color> p2 = new Person<string, string, Color>("Bill", 20,
    "Town Mamba", "+7900453423", 170, 80, "мужской", "негроидная", Color.Black);
Teacher<Gender, string, Color> teacher = new Teacher<Gender, string, Color>("Bob", 30,
        "Street Avenue", "+79003334455", 180, 70, Gender.men, "asian", Color.Brown,
        1234, "Teacher", 5000, new DateTime(2010, 5, 15), "Math", 10);

Student<Gender, string, Color> student = new Student<Gender, string, Color>("Charlie", 20,
    "Park Lane", "+79007778899", 175, 60, Gender.men, "asian", Color.Black,
    5678, "Student", 0, new DateTime(2020, 9, 1), 2, "Computer Science", 4.5);

Manager<Gender, string, Color> manager = new Manager<Gender, string, Color>("Diana", 35,
    "Garden Street", "+79005550707", 170, 65, Gender.women, "caucasian", Color.Green,
    9876, "Manager", 8000, new DateTime(2000, 3, 10), "Sales", 20, 15);

abstract class People<T, K, V>
{ 
    public double Rost { get; set; }
    public double Weight { get; set; }  
    public T Pol { get; set; }
    public K Rassa { get; set; }
    public V ColorEyes { get; set; }
    public People(double rost, double weight, T pol, K rassa, V colorEyes)
    {
        Rost = rost;
        Weight = weight;
        Pol = pol;
        Rassa = rassa;
        ColorEyes = colorEyes;
    }
}
class Person<T, K, V> : People<T, K, V>
{ 
    public string? Name { get; set; }
    public int Age {  get; set; }
    public string? Adress { get; set; }
    public string? Phone { get; set; }
    public Person(string? _name, int _age, string? _adress, string? _phone,
        double _rost, double _weight, T _pol, K _rassa, V _colorEyes): base(_rost, _weight, _pol, _rassa, _colorEyes)
    {
        Name = _name;
        Age = _age;
        Adress = _adress;
        Phone = _phone;
    }
}
class Employee<T, K, V> : Person<T, K, V>
{
    public Employee(string? _name, int _age, string _adress, string? _phone, double _rost,
        double _weight, T _pol, K _rassa, V _colorEyes, int _id, string _position, decimal _salary,
        DateTime _dateStart) :
        base(_name, _age, _adress, _phone, _rost, _weight, _pol, _rassa, _colorEyes)
    {
        Id = _id;
        Position = _position;
        Salary = _salary;
        DateStart=_dateStart;
    }
    public int Id { get; set; }
    public string? Position { get; set; }
    public decimal? Salary { get; set; }
    public DateTime DateStart { get; set; }
}
class Teacher<T, K, V> : Employee<T, K, V>
{
    public Teacher(string? _name, int _age, string _adress, 
        string? _phone, double _rost, double _weight, T _pol, K _rassa, V _colorEyes, 
        int _id, string _position, decimal _salary, DateTime _dateStart, 
        string _subject, int _experience) : base(_name, _age, _adress, _phone, _rost, _weight,
            _pol, _rassa, _colorEyes, _id, _position, _salary, _dateStart)
    {
        Subject = _subject;
        Experience = _experience;
    }

    public string Subject { get; set; }
    public int Experience { get; set; }
}
class Student<T, K, V> : Employee<T, K, V>
{
    public Student(string? _name, int _age, string _adress, string? _phone, double _rost, double _weight,
        T _pol, K _rassa, V _colorEyes, int _id, string _position, decimal _salary,
        DateTime _dateStart, int _course, string _speciality, double _avgMark) : base(_name, _age,
            _adress, _phone, _rost, _weight, _pol, _rassa, _colorEyes, _id, _position, _salary, _dateStart)
    {
        Course = _course;
        Speciality = _speciality;
        AvgMark = _avgMark;
    }

    public int Course { get; set; }
    public string? Speciality { get; set; }
    public double AvgMark { get; set; }
}
class Manager<T, K, V> : Employee<T, K, V>
{
    public Manager(string? _name, int _age, string _adress, string? _phone, double _rost, double _weight,
        T _pol, K _rassa, V _colorEyes, int _id, string _position, decimal _salary, DateTime _dateStart,
        string? _managmentArea, int _staffCount, int _managementExperience) : base(_name, _age, _adress,
            _phone, _rost, _weight, _pol, _rassa, _colorEyes, _id, _position, _salary, _dateStart)
    {
        ManagmentArea = _managmentArea;
        StaffCount = _staffCount;
        ManagementExperience = _managementExperience;
    }

    public string? ManagmentArea { get; set; }
    public int StaffCount { get; set; }
    public int ManagementExperience { get; set; }
}
class Programmer<T,K,V>:Employee<T,K,V>
{
    public Programmer(string? _name, int _age, string _adress, string? _phone, 
        double _rost, double _weight, T _pol, K _rassa, V _colorEyes, int _id, string _position,
        decimal _salary, DateTime _dateStart, string? _language, List<string> _projects,
        string? _specialization) : base(_name, _age, _adress, _phone, _rost, _weight,
            _pol, _rassa, _colorEyes, _id, _position, _salary, _dateStart)
    {
        Langeuage = _language;
        Projects = _projects;
        Specialization = _specialization;
    }

    public string? Langeuage { get; set; }
    public List<string> Projects { get; set; }
    public string Specialization { get; set; }
}
enum Gender { men, women}

