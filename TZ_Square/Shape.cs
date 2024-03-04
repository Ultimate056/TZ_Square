using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TZ_Square.Interfaces;

namespace TZ_Square
{

    public class Circle : IShape
    {
        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }

        public Circle(double radius)
        {
           _radius = radius;
        }

        double IShape.GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (CheckRectangler(a, b, c)) {
                _isRectangler = true;
            }
            else if(CheckRectangler(a, c, b)) {
                _isRectangler = true;
                (c, b) = (b, c);
            }
            else if(CheckRectangler(b, c, a))
            {
                _isRectangler = true;
                (c, a) = (a, c);
            }

        }

        private bool _isRectangler = false;

        public bool IsRectangler { get => _isRectangler; }

        // Теорема Пифагора
        private bool CheckRectangler(double x, double y, double z)
        {
            return Math.Round(Math.Pow(x, 2), 4) + Math.Round(Math.Pow(y, 2), 4) == Math.Round(Math.Pow(z, 2), 4);
        }


        double IShape.GetSquare()
        {
            if (_isRectangler) return a * b / 2;

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
