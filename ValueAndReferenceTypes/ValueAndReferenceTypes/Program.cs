using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public void Increment()
            {
                X++; Y++;
            }
            public void Decrement()
            {
                X--; Y--;
            }
            public void Display()
            {
                Console.WriteLine("x = {0}, y = {1}", X, Y);
            }
        }
        class PointRef
        {
            public int X;
            public int Y;
            public PointRef(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public void Increment()
            {
                X++; Y++;
            }
            public void Decrement()
            {
                X--; Y--;
            }
            public void Display()
            {
                Console.WriteLine("x = {0}, y = {1}", X, Y);
            }
        }
        class ShapeInfo
        {
            public string infoString;
            public ShapeInfo(string info)
            {
                infoString = info;
            }
        }
        struct Rectangle
        {
            public ShapeInfo rectInfo;
            public int rectTop, rectLeft, rectRight, rectBottom;
            public Rectangle(string info, int top, int left, int right, int bottom)
            {
                rectInfo = new ShapeInfo(info);
                rectTop = top;
                rectBottom = bottom;
                rectLeft = left;
                rectRight = right;
            }
            public void Display()
            {
                Console.WriteLine("string = {0}, Top = {1}, Bottom = {2}, Left = {3}, Right = {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
            }
        }

        static void Main(string[] args)
        {
            ValueTypesAssignment();
            ReferenceTypesAssignment();
            ValueTypeContainingRefType();
            Console.ReadLine();
        }
        static void ValueTypesAssignment()
        {
            Console.WriteLine("assigning value types \n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n change p1.X\n");
            p1.Display();
            p2.Display();
        }
        static void ReferenceTypesAssignment()
        {
            Console.WriteLine("assigning value types \n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n change p1.X\n");
            p1.Display();
            p2.Display();
        }
        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            Console.WriteLine("assigning r2 to r1");
            Rectangle r2 = r1;
            Console.WriteLine("changing r2");
            r2.rectInfo.infoString = "this is new string";
            r2.rectBottom = 4444;
            r1.Display();
            r2.Display();
        }
    }
}