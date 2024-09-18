using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class DynamicArray
    {
        public List<int> list { get; set; } = new();

        public DynamicArray()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(100); i++)
                list.Add(random.Next(10, 100));
        }
        public void Print()
        {
            foreach (int i in list) Console.Write(i + " ");
            Console.WriteLine();
        }
        public void Arrange()
        {
            Random random = new Random();
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1); 
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        public int this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
    }
}

