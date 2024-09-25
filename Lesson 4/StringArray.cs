using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class StringArray
    {
        private string[] array;
        public StringArray(int length)
        { 
        array = new string[length]; 
        }
        public string this[int index]
        {
            get 
            {
                if (index < 0 || index >= array?.Length) throw new IndexOutOfRangeException("Выход за пределы диапозона");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array?.Length) throw new IndexOutOfRangeException("Выход за пределы диапозона");
                array[index] = value;
            }
        }
        public void Print()
        { 
            foreach(var i in array) 
            {
                Console.WriteLine(i);
            }
        }
        public static StringArray Concatenate(StringArray array1, StringArray array2)
        {
            int newLength = array1.array.Length + array2.array.Length;
            StringArray resultArray = new StringArray(newLength);
            int index = 0;
            for (int i = 0; i < array1.array.Length; i++)
            {
                resultArray[index++] = array1[i];
            }
            for (int j = 0; j < array2.array.Length; j++)
            {
                resultArray[index++] = array2[j];
            }

            return resultArray;
        }

    }
}
