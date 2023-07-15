using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaskShape
{
    public class Circle : Shape
    {
        public double radius { get; set; } 

        public Circle(double radius):base() 
        {
            if(IsExist(radius))
                this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private bool IsExist(double radius) 
        {
            if(radius<=0)
                throw new Exception("Такого круга не существует! Радиус должен быть положительным и больше 0!");
            return true;
        }
    }
}
