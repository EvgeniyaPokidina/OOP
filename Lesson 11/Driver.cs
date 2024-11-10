using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Driver
    {
        public string? FIO {  get; set; }
        public string? Licence { get; set; }
        public string CompleteRace(Order order1)
        {
            return $"Рейс выполнен";
        }
        public string Repair(Car car1)
        {
            return $"Необходима заявка на ремонт автомобиля";
        }
    }

}
