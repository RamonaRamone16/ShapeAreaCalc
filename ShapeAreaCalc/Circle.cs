using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalc
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area { get => Math.PI * Math.Pow(Radius, 2); }
    }
}
