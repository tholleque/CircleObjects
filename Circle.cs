using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{

    internal class Circle
    {
        //Properity(s)
        private double Radius { get; set; }
        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //Methods 
        public double CalculateDiameter()
        {
            return Radius * 2;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void Grow()
        {
            Radius *= 2;
        }
        public double GetRadius() 
        { 
            return Radius;
        }






    }
}
