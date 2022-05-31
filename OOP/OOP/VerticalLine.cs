using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yU, int yW, int x, char sym) // метод который вызывается при создании объекта HorizontalLine (конструктор)
        {
            pList = new List<Point>(); // пустой список
            for (int i = yU; i <= yW; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
            
            //Point p1 = new Point(4, 4, '+');
            //Point p2 = new Point(5, 4, '+');
            //Point p3 = new Point(6, 4, '+');
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
