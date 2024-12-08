using OfficeOpenXml;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
Client[] mas =
{
    new Client("Иван", "Иванов", "ivan@example.com"),
    new Client("Петр", "Петров", "peter@example.com"),
    new Client("Мария", "Сидорова", "maria@example.com"),
    new Client("Анна", "Кузнецова", "anna@example.com"), 
    new Client("Алексей", "Смирнов", "alex@example.com"), 
    new Client("Наталья", "Васильева", "natalia@example.com"), 
    new Client("Сергей", "Морозов", "sergey@example.com"),
    new Client("Ольга", "Павлова", "olga@example.com"),
    new Client("Денис", "Жуков", "denis@example.com"),
    new Client("Екатерина", "Макарова", "ekaterina@example.com")
};
FileInfo fileInfo = new FileInfo("СписокКлиентов.xlsx");
ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage newBook=new ExcelPackage("СписокКлиентов.xlsx");
newBook.Workbook.Worksheets.Add("Клиенты");
ExcelWorksheet worksheet = newBook.Workbook.Worksheets["Клиенты"];
worksheet.Cells["A1"].Value = "Имя";
worksheet.Cells["B1"].Value = "Фамилия";
worksheet.Cells["C1"].Value = "Email";
for (int i = 0; i < mas.Length; i++)
{
    worksheet.Cells[2 + i, 1].Value= mas[i].Name;
    worksheet.Cells[2 + i, 2].Value = mas[i].LastName;
    worksheet.Cells[2 + i, 3].Value = mas[i].Email;
}
newBook.SaveAs(fileInfo);
class Client
{ 
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public Client(string? name, string? lastName, string? email)
    {
        Name = name;
        LastName = lastName;
        Email = email;
    }
}