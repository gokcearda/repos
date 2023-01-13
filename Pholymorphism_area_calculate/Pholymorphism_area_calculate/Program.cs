using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pholymorphism_area_calculate
{

    public class Geo //Parent
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Geo
    {
        public double Radius { get; set; }
        public Circle()
        {
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }
        public override double Area()
        {
            //return base.Area();
            return (3.14) * Math.Pow(Radius, 2);//Circle Alan:pirekare
        }
    }

    public class Square : Geo
    {
        public double Length { get; set; }

        public Square()
        {
            Console.WriteLine("Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            //return base.Area();
            return Math.Pow(Length, 2);
        }
    }
    public class Rectangle : Geo
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Width: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            //return base.Area();
            return Height * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Geo sekil = new Circle();
            Console.WriteLine("Circle Area: " + sekil.Area());

            Geo sekil2 = new Square();
            Console.WriteLine("Square Area: " + sekil2.Area());

            Geo sekil3 = new Rectangle();
            Console.WriteLine("Rectangle Area: " + sekil3.Area());
            Console.ReadLine();
        }
    }
}
