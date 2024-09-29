using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Alcohol:Liquid
    {
        public int Strength { get; set; }
        public Alcohol(string name) : base(name)
        { 
        
        }
        public new void Print ()
        { 
            base.Print();
            Console.WriteLine($"Крепость: {Strength}%");
        }
    }
}
