using Lesson_6;

int[] numbers = { 1, 2, 3, 4, 5, 68, 403, 50 }; 
double average=Static.CalculateAvg(numbers);
Console.WriteLine($"Среднее значение элементов массива: {average}");


char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
Elements.SwapElements(charArray);
Console.WriteLine($"Измененный массив: "+ string.Join(", ", charArray));

