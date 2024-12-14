using Lesson_30._2;
using System.Xml.Serialization;

User user=new User()
{
    Name = "Ivan",
    Age = 40
};
User user1=new User()
{
    Name = "Petr",
    Age = 22
};
User user2=new User()
{
    Name = "Sam",
    Age = 34
};
//List<User> users = new List<User>();
//users.Add(user);
//users.Add(user1);
//users.Add(user2);
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
//FileStream stream = new FileStream("user.xml", FileMode.Create);
//xmlSerializer.Serialize(stream, users);
//stream.Close();
//using (FileStream stream = new FileStream("user.xml", FileMode.Create))
//{
//    xmlSerializer.Serialize(stream, users);
//}

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
using (FileStream stream = new FileStream("user.xml", FileMode.Open))
{
    List<User> users = (List<User>)xmlSerializer.Deserialize(stream)!;
    foreach (User userr in users)
    {
        Console.WriteLine(user);
    }
}
