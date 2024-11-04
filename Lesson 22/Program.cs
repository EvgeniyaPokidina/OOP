internal interface IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
public class User : IUser
{
    private static List<string> existLogin = new List<string>();
    private static int userCounter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public User(string name, string login, string password)
    {
        if (existLogin.Contains(login))
        {
            Console.WriteLine($"Пользователь с логином '{login}' уже существует.");
            throw new Exception("Пользователь с таким логином уже существует.");
        }
        Id = ++userCounter; 
        Name = name;
        Login = login;
        Password = password;
        existLogin.Add(login); 
        SaveData(); 
    }
    public void SaveData()
    {
        string userData = $"{Id} {Name} {Login} {Password}";

    }
}
public delegate string IsDataExists(string data);

class Program
{
    static void Main()
    { 
        try
        {
            User user1 = new User("Alice", "alice01", "password123");
            User user2 = new User("Bob", "bob02", "password456");
            User user3 = new User("Charlie", "alice01", "password789");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Данные пользователей из файла:");
        if (File.Exists("userData.txt"))
        {
            string[] lines = File.ReadAllLines("userData.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}