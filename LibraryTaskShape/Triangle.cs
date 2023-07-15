using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaskShape
{
    public class Triangle : Shape
    {
        public double aSide { get; set; }
        public double bSide { get; set; }
        public double cSide { get; set; }

        public Triangle(double a, double b, double c) : base()
        {
            if (IsExist(a, b, c)) 
            {
                this.aSide = a; 
                this.bSide = b; 
                this.cSide = c;
            }
        }

        public override double Area()
        {
            double p  = (this.aSide + this.bSide + this.cSide)/2;
            return Math.Sqrt(p * (p - this.aSide) * (p - this.bSide) * (p - this.cSide));
        }

        private bool IsExist(double a, double b, double c) 
        {
            if (a > b + c || b > a + c || c > a + b)
                throw new Exception("Сторона треугольника не может быть больше суммы двух других сторон!");
            if (a < 0 || b < 0 || c < 0)
                throw new Exception("Сторона треугольника не может быть меньше 0!");
            return true;
        }

        public bool isRightTriangle() 
        {
            /*
             Я нашел 2 способа проверить, что треугольник - прямоугольный:
                1. По теореме пифагора проверяем все 3 стороны
                    По уравнению:
                    a^2 = b^2 + c^2

                    Тут я не использую корень, поскольку он намного дольше выполняется, чем возведение в квадрат
                2. Если его площадь равна половине площади прямоугольника сделанного из 2 сторон
                    Это легко доказать, так как площадь прямоугольного треугольника равна половине
                    произведения его катетов.
                    А просто произведение его катетов равна площади прямоугольника из этих 2 катетов.

            Так как для 1 случай требует только возведение в степень 
             

            Также можно избавиться от множетсвенных проверок для каждой пары сторон если мы заранее 
            определим 2 катета (они меньше гипотенузы) и гипотенузу. Это позволит немного быстрее выполнять код.
             */

            // Определяем две наименьшие стороны треугольника
            // Определяем гипотенузу треугольника
            double min1, min2, hyp;

            if (this.aSide <= this.bSide && this.aSide <= this.cSide)
            {
                min1 = this.aSide;
                min2 = Math.Min(this.bSide, this.cSide);
                hyp = Math.Max(this.bSide, this.cSide);
            }
            else if (this.bSide <= this.aSide && this.bSide <= this.cSide)
            {
                min1 = this.bSide;
                min2 = Math.Min(this.aSide, this.cSide);
                hyp = Math.Max(this.aSide, this.cSide);
            }
            else
            {
                min1 = this.cSide;
                min2 = Math.Min(this.aSide, this.bSide);
                hyp = Math.Max(this.aSide, this.bSide);
            }

            // Определяем гипотенузу треугольника

            if (Math.Pow(hyp, 2) == Math.Pow(min1, 2) + Math.Pow(min2, 2))
                return true;

            /*if (Math.Pow(this.aSide, 2) == Math.Pow(this.bSide, 2) + Math.Pow(this.cSide, 2) ||
                Math.Pow(this.bSide, 2) == Math.Pow(this.aSide, 2) + Math.Pow(this.cSide, 2) ||
                Math.Pow(this.cSide, 2) == Math.Pow(this.aSide, 2) + Math.Pow(this.bSide, 2))
                return true;*/
            /*double area = this.Area() * 2;
            if(this.aSide * this.bSide == area || 
                this.aSide * this.cSide == area || 
                this.bSide * this.cSide == area)
                return true;
            */
            return false;
        }
    }
}
