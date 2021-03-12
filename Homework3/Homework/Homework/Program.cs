using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public interface Shape
    {
        double Area();
        bool IsLegal();
    }

    class Rentagle :Shape{

        //private double length;
        //private double width;

        public double Length { get; }
        public double Width { get; }

        public Rentagle(double length,double width)
        {
            Length = length;
            Width = width;
        }
        public double Area()
        {
            return Width * Length;
        }
        public bool IsLegal()
        {
            if (Width > 0 && Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + "Length:" + Length + "\tWidth:" + Width + "\tArea:" + this.Area();
        }

    }

    class Square:Shape
    {
        //private double length;
        public double Length { get; }
        public Square(double length)
        {

            Length = length;
        }

        public double Area()
        {
            return Length * Length;
        }
        public bool IsLegal()
        {
            if (Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + "Length:"+Length+ "\tArea:" + this.Area();
        }

    }

    class Triangle : Shape {
        //private double side1;
        //private double side2;
        //private double side3;
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1,double side2,double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double Area()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
        public bool IsLegal()
        {
            if (Side1>0&&Side2>0&&Side3>0&&(Side1 + Side2) > Side3 && (Side2 + Side3) > Side1 && (Side1 + Side3) > Side2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + "Side1:" + Side1 + "\tSide2:" + Side2 + "\tSide3:" + Side3+ "\tArea:" + this.Area();
        }
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(int i)
        {
            Random r = new Random();
            if (i == 1)
            {
                double a = 10 * r.NextDouble();
                double b = 10 * r.NextDouble();
                return new Rentagle(a,b);
            }
            if(i==2)
            {
                double s = 10 * r.NextDouble();
                return new Square(s);
            }
            if (i == 3)
            {
                double a = 10 * r.NextDouble();
                double b = 10 * r.NextDouble();
                double c = 10 * r.NextDouble();
                return new Triangle(a, b, c);
            }
            else
            {
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double sumArea = 0;
            for(int i = 0; i < 10; i++)
            {
                int s = r.Next(1, 4);
                Shape shape= ShapeFactory.CreateShape(s);
                while (!shape.IsLegal())
                {
                    shape = ShapeFactory.CreateShape(s);
                }
                Console.WriteLine(shape.ToString());
                sumArea += shape.Area();
            }
            Console.WriteLine($"总的面积为{sumArea}");
        }
    }
}
