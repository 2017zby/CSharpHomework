using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public abstract class Shape
    {
        private string kindOfShape;
        public Shape(string s)
        {
            kindOfShape = s;
        }
        public string Name
        {
            get
            {
                return kindOfShape;
            }
            set
            {
                Name = value;
            }
        }
        public abstract double Area
        {
            get;
        }
    }

    public class Square:Shape
    {
        private int Side;
        public Square (int side,string name):base(name)
        {
            Side = side;
        }
        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }


    }

    public class Cirecle:Shape
    {
        private int radius;
        public Cirecle(int radius,string name):base(name)
        {
            this.radius = radius;
        }
        public override double Area
        {
            get
            {
                return radius * radius*System.Math.PI;
            }
        }
    }

    public class Rectangle:Shape
    {
        private int width;
        private int height;
        public Rectangle(int width,int height,string name):base(name)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area
        {
            get
            {
                return width * height;
            }
        }
    }
    public class Triangle:Shape
    {
        private int height;
        private int length;
        public  Triangle(int height,int length,string name):base(name)
        {
            this.height = height;
            this.length = length;
        }
        public override double Area
        {
            get
            {
                return 0.5 * height * length;
            }
        }
    }

    class ShapeText
    {
        static void Main(string[] args)
        {

            Shape[] shapes =
            {
                new Square(5,"Square"),
                new Cirecle(3,"Cirelce"),
                new Rectangle(4,5,"Rectangle"),
                new Triangle(2,1,"Triangle")
            };
            System.Console.WriteLine("Shapes Collection ");
            foreach(Shape s in shapes)
            {
                System.Console.WriteLine(s);
                System.Console.WriteLine(s.Area);
            }
        }
    } 

       
}
