using System;

public class Keyboard
{
    public delegate void KeyPressedEventHandler(object sender, char key);
    public event KeyPressedEventHandler? KeyPressed;

    protected virtual void OnKeyPress(char key)
    {
        KeyPressed?.Invoke(this, key);
    }
    public void PressKey(char key)
    { 
        OnKeyPress(key);
    }
    public void PressA() => PressKey('A');
    public void PressB() => PressKey('B');
    public void PressC() => PressKey('C');
    public void Press1() => PressKey('1');
    public void Press2() => PressKey('2');
}

class Program
{
    static void Main()
    {
        Keyboard keyboard = new Keyboard();
        keyboard.KeyPressed += KeyboardPress;
        keyboard.PressA();
        keyboard.PressB();
        keyboard.PressC();
        keyboard.Press1();
        keyboard.Press2();
    }    
        public static void KeyboardPress(object sender, char key)
    {
        Console.WriteLine($"Нажата {key}");
    }
}