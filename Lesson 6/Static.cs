using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson_6
{
    public class Static
    {
        public static double CalculateAvg(int[] array)
        {
          int sum=0;

        foreach (int number in array)
        {
            sum += number;
        }
        double average = (double)sum / array.Length;
        return average;
        }
    }
}

          
    
