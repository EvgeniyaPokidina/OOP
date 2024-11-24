using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_26
{
    public class Counter
    {
        private int count;
        public Counter(int Count)
        {
            count = Count;
        }
        public void Increment()
        {
            lock (this)
            {
                count++;
                Console.WriteLine($"Увеличение счетчика: {count}");
            }
        }
        public void Decrement()
        {
            lock (this)
            {
                count--;
                Console.WriteLine($"Уменьшение счетчика: {count}");
            }
        }
        public int GetValue()
        {
            lock (this)
            {
                return count;
            }
        }
    }
}
