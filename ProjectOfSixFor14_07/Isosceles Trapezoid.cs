/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Isosceles_Trapezoid.
	/// </summary>
	public class Isosceles_Trapezoid
	{
		private double a;
        private double b;
        private double c;
        private double h;
        private double perimeter;
        private double area;
        private double radius;
        private double radiuS;
        public double A
        {
            get { return this.a; }
            set
            {
                if (this.a < 0)
                {
                    throw new ArgumentException("The side of the trapezoid is not a positive number!");
                }
                this.a = value;
            }
        }
        public double B
        {
            get { return this.b; }
            set
            {
                if ((this.b < 0))
                {
                    throw new ArgumentException("-!- The side of the trapezoid is not a positive number! -!-");
                }
                this.b = value;
            }
        }
        public double C
        {
            get { return this.c; }
            set
            {
                if ((this.c < 0))
                {
                    throw new ArgumentException("-!- The side of the trapezoid is not a positive number! -!-");
                }
                this.c = value;
            }
        }
        public double H
        {
            get { return this.h; }
        }
        public double Perimeter
        {
            get { return this.perimeter; }
        }
        public double Radius
        {
            get { return this.radius; }
        }
        public double RadiuS
        {
            get { return this.radiuS; }
        }
        public double Area
        {
            get { return this.area; }
        }
        public Isosceles_Trapezoid()
        {
            area = 0;
        }
        public double Calculate()
        {
            perimeter = a + b + 2 * c;
            if (a >= b)
            {
                h = Math.Round(Math.Sqrt(Math.Pow(c, 2) - Math.Pow((a - b) / 2, 2)), 4);
            }
            else
            {
                h = Math.Round(Math.Sqrt(Math.Pow(c, 2) - Math.Pow((b - a) / 2, 2)), 4);
            }
            area = h * (a + b) / 2;
            if (Math.Pow(h, 2) == a * b)
            {
                radiuS = Math.Round((((Math.Sqrt(Math.Pow((a + b) / 2, 2) + Math.Pow(h, 2)) * c * a) / (a * h / 2)) / 4), 6);
            }
            if (a + b == 2 * c)
            {
                radius = h / 2;
            }
            return area;
        }
        public void Show()
        {
            Console.WriteLine("--> a = {0}, b = {1}, c = {2}, h = {3}, P = {4}, S = {5}, Radius of an inscribed circle: {6}, Radius of an circumscribed circle: {7}", a, b, c, h, perimeter, area, radius, radiuS);
        }
	}
}
