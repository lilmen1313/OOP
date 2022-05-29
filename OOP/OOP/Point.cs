using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Point
{
    public int x;
    public int y;
    public char sym;
    public Point(int _x, int _y, char _sym) /*конструктор*/
    {
        x = _x;
        y = _y;
        sym = _sym;
    }

    public void Draw() // метод отображения точки
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(x, y);
        Console.WriteLine(sym);
    }
}