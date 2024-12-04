using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(int userId, string username, string password, string role)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Role = role;
        }
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public void Logout()
        { 
            Console.WriteLine($"{Username} вышел.");
        }
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
public abstract class TaskBase : ITask
{
    public int TaskId { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; }

    protected TaskBase(int taskId, string title, string description, DateTime dueDate, string status)
    {
        TaskId = taskId;
        Title = title;
        Description = description;
        DueDate = dueDate;
        Status = "В процессе";
    }
}
