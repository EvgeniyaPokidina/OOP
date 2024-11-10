using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Car
    {
        public string? Number { get; set; }
        public string? Model { get; set; }

        public override string? ToString()
        {
            return $"Автомобиль {Model} Номер {Number}";
        }
    }
}
