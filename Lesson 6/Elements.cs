using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Elements
    {
        public static void SwapElements(char[] array)
        { 
            int n=array.Length;
            for (int i = 0; i < n/2; i++)
            {
                char temp = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = temp;
            }
        }
    }
}
