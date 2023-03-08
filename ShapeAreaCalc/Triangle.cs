using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalc
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double P { get => (A + B + C) / 2; }

        public override double Area { get => Math.Sqrt(P * (P - A) * (P - B) * (P - C)); }

        public bool CalcIsRight() { // определяет является ли прямоугольник прямоугольным
            var arr = new[] {A, B, C};
            var largestSide = arr.Max();
            var twoOther = arr.Where(x => x != largestSide).ToList();

            return Math.Pow(largestSide, 2) == (Math.Pow(twoOther[0], 2) + Math.Pow(twoOther[1], 2));
        }
    }
}
