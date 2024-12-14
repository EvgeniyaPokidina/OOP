using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._3_4
{
    internal class Contacts
    {
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public void Print()
        {
            Console.WriteLine(Name + " " + Adress + " " + Phone + " " + Email);
        }
        //public override string? ToString()
        //{
        //    return $"Имя: {Name}, Адрес: {Adress}, Телефон: {Phone}, Email: {Email}";
        //}
    }
}
