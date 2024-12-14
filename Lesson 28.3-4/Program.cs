
using Lesson_28._3_4;
using OfficeOpenXml;

int currentRow = 2;
string? filePath = "contacts.xlsx";
ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage package = new ExcelPackage(filePath);
ExcelWorksheet worksheet = package.Workbook.Worksheets["Лист1"];
bool exit = false;
do
{
    Console.Clear();
    currentRow = 2;
    while (worksheet.Cells[currentRow, 1].Value != null)
    {
        Contacts contact = new Contacts()
        {
            Name = worksheet.Cells[currentRow, 1].Value.ToString(),
            Adress = worksheet.Cells[currentRow, 2].Value.ToString(),
            Phone = int.Parse(worksheet.Cells[currentRow, 3].Value.ToString()!),
            Email = worksheet.Cells[currentRow, 4].Value.ToString()
        };
        contact.Print();
        Console.WriteLine();
        currentRow++;
    }
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Добавление контакта");
    Console.WriteLine("2. Удаление контакта по имени");
    Console.WriteLine("3. Перезапись");
    Console.WriteLine("4. Выход");
    Console.Write("Выберите пункт меню:");
    int n = int.Parse(Console.ReadLine()!);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите имя контакта:");
                string name = Console.ReadLine()!;
                Console.Write("Введите адрес:");
                string adress = Console.ReadLine()!;
                Console.Write("Введите телефон:");
                int phone = int.Parse(Console.ReadLine()!);
                Console.Write("Введите email:");
                string email = Console.ReadLine()!;
             
                Contacts contact = new Contacts
                {
                    Name = name,
                    Adress = adress,
                    Phone = phone,
                    Email = email 
                };
                worksheet.Cells[currentRow, 1].Value = contact.Name;
                worksheet.Cells[currentRow, 2].Value = contact.Adress;
                worksheet.Cells[currentRow, 3].Value = contact.Phone;
                worksheet.Cells[currentRow, 4].Value = contact.Email;
                
                package.Save();
                currentRow++;
            }
            break;
        case 2:
            {
                Console.Write("Введите имя:");
                string name = Console.ReadLine()!;
                //Console.Write("Введите количество:");
                //int count = int.Parse(Console.ReadLine()!);
                for (int row = 2; row < currentRow; row++)
                {
                    //    if (worksheet.Cells[row, 1].Value.ToString() == name)
                    //    {
                    //        if (count < int.Parse(worksheet.Cells[row, 2].
                    //            Value.ToString()!))
                    //        {
                    //            int nCount = int.Parse(worksheet.Cells[row, 2].
                    //            Value.ToString()!) - count;
                    //            worksheet.Cells[row, 2].Value = nCount;
                    //            package.Save();
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Такого количества на складе нет!");
                    //            Console.ReadKey();
                    //        }
                    //    }
                    worksheet.Cells[row, 1].Value = worksheet.Cells[row + 1, 1].Value;
                    worksheet.Cells[row, 2].Value = worksheet.Cells[row + 1, 2].Value;
                    worksheet.Cells[row, 3].Value = worksheet.Cells[row + 1, 3].Value;
                    worksheet.Cells[row, 4].Value = worksheet.Cells[row + 1, 4].Value;
                }
            }
            break;
        case 3:
            {

            }
            break;
        case 4:
            {
                exit = true;
            }
            break;
    }
}
while (!exit);