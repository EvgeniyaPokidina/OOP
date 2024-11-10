using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Order
    {
        public Driver? Driver {  get; set; }
        public Race? Race { get; set; }
        public Car? Car { get; set; }
        public Cashier? Cashier { get; set; }
        public DateTime? Created { get; set; }

        public Order(Driver? driver, Race? race, Car? car, Cashier? cashier, DateTime? created)
        {
            Driver = driver;
            Race = race;
            Car = car;
            Cashier = cashier;
            Created = created;
        }
        public override string? ToString()
        {
            return Driver!.FIO + "\n" +
                Race!.Number + "\n" +
                Race.Destination + "\n" +
                Race.TimeDeparture + "\n" +
                Cashier!.FIO;
        }
    }
}
