using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

FileInfo fileInfo = new FileInfo("Календарь 2024.xlsx");
//if (!fileInfo.Exists) fileInfo.Create();
ExcelPackage.LicenseContext=OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage package = new ExcelPackage("Календарь 2024.xlsx");
package.Workbook.Worksheets.Add("Календарь 2024");
ExcelWorksheet worksheet= package.Workbook.Worksheets["Календарь 2024"];
worksheet.Cells["B1"].Value = "Январь";
worksheet.Cells["C1"].Value = "Февраль";
worksheet.Cells["D1"].Value = "Март";
worksheet.Cells["E1"].Value = "Апрель";
worksheet.Cells["F1"].Value = "Май";
worksheet.Cells["G1"].Value = "Июнь";
worksheet.Cells["H1"].Value = "Июль";
worksheet.Cells["I1"].Value = "Август";
worksheet.Cells["J1"].Value = "Сентябрь";
worksheet.Cells["K1"].Value = "Октябрь";
worksheet.Cells["L1"].Value = "Ноябрь";
worksheet.Cells["M1"].Value = "Декабрь";
DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
DateTime finish = new DateTime(DateTime.Now.Year, 12, 31);
int row = 0;
int column = 2;
int currentMonth, previousMonth = 1;
for(DateTime i =start;i<finish; i.AddDays(1))
{
    currentMonth = i.Month;
    if (currentMonth != previousMonth)
    {
        row = 0;
        column++;
    }
    worksheet.Cells[2 + row, column].Value = i.Day;

    worksheet.Cells[2 + row, column].AddComment(i.DayOfWeek.ToString());
    if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
    {
        worksheet.Cells[2 + row, column].Style.Fill.PatternType=ExcelFillStyle.Solid;
        worksheet.Cells[2 + row, column].Style.Fill.BackgroundColor.SetColor(Color.Violet);
    }
    row++;
    previousMonth = currentMonth;
    i = i.AddDays(1);
}
//package.Save();
package.SaveAs(fileInfo);
