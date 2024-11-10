using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public  string? Name { get; set; }
        public abstract void CalculateFood();
        public abstract int GetFoodAmount();
    }
    public class Carnivore : Animal
    { 
        public int DailyMeat { get; set; }
        public Carnivore(int id, string name, int dailyMeat)
        {
            Id = id;
            Name = name;
            DailyMeat = dailyMeat;
        }

        public override void CalculateFood()
        {
            Console.WriteLine($"{Name} - хищник. Ему необходимо {DailyMeat} гр мяса в день");
        }
        public override int GetFoodAmount()
        {
            return DailyMeat;
        }
    }
    public class Omnivore : Animal
    { 
        public int DailyFood { get; set; }

        public Omnivore(int id, string name, int dailyFood)
        {
            Id = id;
            Name = name;
            DailyFood = dailyFood;
        }

        public override void CalculateFood()
        {
            Console.WriteLine($"{Name} - всеядный. Ему необходимо {DailyFood} гр пищи в день");
        }
        public override int GetFoodAmount()
                 {
   return DailyFood;
        }
    }
    public class Herbivore : Animal 
    {
        public int DailyGrass { get; set; }

        public Herbivore(int id, string name, int dailyGrass)
        {
            Id = id;
            Name = name;
            DailyGrass = dailyGrass;
        }
        public override void CalculateFood()
        {
            Console.WriteLine($"{Name} - травоядный. Ему необходимо {DailyGrass} гр травы в день");
        }
        public override int GetFoodAmount()
        {
            return DailyGrass;
        }
    }
}
