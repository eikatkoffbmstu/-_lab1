using System;

 namespace Rec1
    {
    class Rectangle
    {
        private double side1;
        private double side2;
        public Rectangle(double sideA, double sideB)
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }
        private double CalculateArea()
        {
            return side1 * side2;
        }
        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
             get {  return CalculateArea(); }                 
        }
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    class Program
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());           
            double sideB = double.Parse(Console.ReadLine()); 
            Rectangle rectangle = new Rectangle(sideA, sideB);
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
