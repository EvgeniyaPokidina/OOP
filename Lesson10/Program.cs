public class BaseClass
{
    // Открытое целочисленное поле
    public int Number { get; set; }

    // Виртуальный индексатор с одним индексом
    public virtual int this[int index]
    {
        get
        {
            // Считываем цифру на указанной позиции
            return GetDigitAtPosition(Number, index);
        }
    }

    // Метод для получения цифры на заданной позиции
    protected int GetDigitAtPosition(int number, int position)
    {
        // Преобразуем число в строку и получаем нужную цифру
        string numberStr = Math.Abs(number).ToString();
        if (position < 0 || position >= numberStr.Length)
        {
            throw new IndexOutOfRangeException("Недопустимая позиция.");
        }
        return (int)(numberStr[numberStr.Length - 1 - position] - '0');
    }
}

public class DerivedClass : BaseClass
{
    // Допольнительное открытое целочисленное поле
    public int AdditionalNumber { get; set; }

    // Переопределенный индексатор с двумя индексами
    public int this[int fieldIndex, int digitPosition]
    {
        get
        {
            // Определяем, какое поле использовать
            int value = fieldIndex == 0 ? Number : AdditionalNumber;
            return GetDigitAtPosition(value, digitPosition);
        }
    }

    // Переопределение индексатора с одним индексом
    public override int this[int index]
    {
        get
        {
            // Вычисляем сумму полей и получаем цифру
            int totalValue = Number + AdditionalNumber;
            return GetDigitAtPosition(totalValue, index);
        }
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass { Number = 12345 };
        Console.WriteLine("Цифра на позиции 0 в базовом классе: " + baseObj[0]); // Ближайшая справа цифра
        Console.WriteLine("Цифра на позиции 1 в базовом классе: " + baseObj[1]); // 4

        DerivedClass derivedObj = new DerivedClass { Number = 12345, AdditionalNumber = 67890 };
        Console.WriteLine("\nЦифра на позиции 0 в производном классе (сумма): " + derivedObj[0]); // Сумма = 12345 + 67890 = 80235 -> 5
        Console.WriteLine("Цифра на позиции 1 в производном классе (сумма): " + derivedObj[1]); // 3

        Console.WriteLine("\nЦифра в поле Number на позиции 0: " + derivedObj[0, 0]); // 5 (0 - это Number)
        Console.WriteLine("Цифра в поле AdditionalNumber на позиции 0: " + derivedObj[1, 0]); // 0 (1 - это AdditionalNumber)
    }
}

