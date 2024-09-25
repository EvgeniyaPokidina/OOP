using Lesson_4;

StringArray stringArray = new StringArray(3);
stringArray[0] = "Abcbdn";
stringArray[1] = "dsdfsd";
stringArray[2] = "dfrew";
Console.WriteLine("Элементы массива");
stringArray.Print();
StringArray secondArray = new StringArray(3);
secondArray[0] = "abc";
secondArray[1] = "dsdfsd"; 
secondArray[2] = "xyz";
Console.WriteLine("Элементы нового массива:");
secondArray.Print();