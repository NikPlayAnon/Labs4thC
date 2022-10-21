using System;

namespace _6.a
{
    public class Shape
    {
        protected double area, perimeter;
        protected string name;
        public Shape()
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "без названия";
        }
        public (double,double,string) Show()
        {
            Console.WriteLine("area= " + this.area + "\nperimeter= " + this.perimeter + "\nname= " + this.name);
            return (this.area, this.perimeter, this.name);
        }
    }

    public class Rect : Shape
    {
        public double side1;
        public double side2;
        public Rect()
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Прямоугольник";
            this.side1 = 0;
            this.side2 = 0;
        }
        public Rect(double side1,double side2)
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Прямоугольник";
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Perimetor()
        {
            this.perimeter = (side2 * 2 + side1 * 2);
            return this.perimeter;
        }
        public double Area()
        {
            this.area = side1 * side2;
            return this.area;
        }
    }

    public class Circle : Shape
    {
        public double radius;
        public Circle()
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Круг";
            this.radius = 0;
        }
        public Circle(double radius)
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Круг";
            this.radius = radius;
        }
        public double Perimetor()
        {
            this.perimeter = 2 * Math.PI * this.radius; //2PiR
            return this.perimeter;
        }
        public double Area()
        {
            this.area = Math.PI * this.radius * this.radius;
            return this.area;
        }
    }
    public class Squeare : Rect
    {
        public double side;
        public Squeare()
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Квадрат";
            this.side1 = 0;
            this.side2 = 0;
        }
        public Squeare(double side)
        {
            this.area = 0;
            this.perimeter = 0;
            this.name = "Квадрат";
            this.side1 = side;
            this.side2 = side;
        }
    }
}
