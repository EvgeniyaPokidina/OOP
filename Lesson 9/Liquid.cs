
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Liquid
    {
        public string Name { get; set; }
        private int density;
        public int Density 
        {  get { return density; }
           set { if (value > 0) density = value; }
        }
        public Liquid(string name)
        {
            Name = name;
            density = 1;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} c плотностью {Density}");
        }
    }
}
