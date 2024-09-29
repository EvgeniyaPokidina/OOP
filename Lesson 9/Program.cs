using Lesson_9;

Liquid liquid = new Liquid("Вода");
liquid.Density = 1000;
liquid.Print();
Alcohol alcohol = new Alcohol("Спирт");
alcohol.Density = 790; 
alcohol.Strength = 96; 
alcohol.Print();

Pair pair=new Pair() { First=7.3, Second=3.5};
Console.WriteLine($"Произведение чисел:" + pair.Multyply());
double a = 3;
double b = 4;
Rectangle rectangle = new Rectangle(a, b);
rectangle.Print();