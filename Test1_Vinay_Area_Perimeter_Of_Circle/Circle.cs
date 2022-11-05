using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_Area_Perimeter_Of_Circle
{
    public class Circle
    {
        double pi = 3.14;
        double AreaOfCircle;
        double Perimeter;
        public int Radius { get; set; }       
        public void GetCircleAndPerimeter()
        {
            AreaOfCircle=pi * Radius * Radius;
            Console.WriteLine("Area Of the Circle  : "+AreaOfCircle);
            Perimeter=2*pi*Radius;
            Console.WriteLine("Perimeter of the Circle  : "+Perimeter);

        }
    }
}
