using System;
using System.Collections.Generic;
using System.Text;

namespace myappAug10
{
    class Circle
    {   double radius;
        double PI = Math.PI;
        
        public void setradius(double radius)
        {
            this.radius = radius;
        }
        public double getradius()
        {
            return this.radius;
        }
        public double calcDiameter()
        {
            return 2 * this.radius;
        }
        public double calcArea()
        {
            return PI * this.radius * this.radius;
        }
    }
    class CircleTest
    {
        public static void Main()
        {
            Circle c1 = new Circle();
            c1.setradius(4.5);
            Console.WriteLine(c1.getradius());
            Console.WriteLine(c1.calcArea());
            Console.WriteLine(c1.calcDiameter());


        }
    }
}
