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
	/// Description of Triangle.
	/// </summary>
	public class Triangle
	{
		private double a;
        private double b;
        private double h;
        private double perimeter;
        private double area;
        private double radius;
        private double radiuS;
        private double angle;
        public double A
        {
            get { return this.a; }
            set
            {
                if (this.a < 0)
                {
                    throw new ArgumentException("The side of the triangle is not a positive number!");
                }
                this.a = value;
            }
        }
        public double B
        {
            get { return this.b; }
            set
            {
                if ((this.b < 0) || (b > 2 * a + 1))
                {
                    throw new ArgumentException("The value of the side of the triangle isn't valid!");
                }
                this.b = value;
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
        public double Angle
        {
            get { return this.angle; }
            set
            {
                if ((this.angle < 90) || (this.angle > 0))
                {
                    this.angle = value;
                }
                else
                {
                    throw new ArgumentException("Angle value is not valid.");
                }

            }
        }
        public bool IfAnЕquilateralТriangle(double Angle)
        {
            double AngleonTop = 180 - 2 * Angle;
            if (Angle == AngleonTop)
            {
                a = b;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Calculate()
        {
            if (Angle == 45) //Равнобедрен правоъгълен
            {
                this.h = Math.Round(Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a / 2, 2)), 2);
                radius = (2 * b - a) / 2;
                radiuS = a / 2;
                area = (a * h) / 2;
                perimeter = a + 2 * b;
            }
            else
            {
                if (Angle == 60) // Равностранен
                {
                    h = Math.Round((Math.Sqrt(3) * a) / 2, 2);
                    radius = h / 3;
                    radiuS = 2 * radius;
                    area = (a * h) / 2;
                    perimeter = 3 * a;
                }
                else //Всеки друг случай     a=3,b=4
                {
                    h = Math.Round(Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a / 2, 2)), 2); //
                    area = Math.Round((a * h) / 2, 2);
                    radiuS = Math.Round((a * Math.Pow(b, 2)) / (4 * area), 2);
                    radius = Math.Round((a * h) / (a + 2 * b), 2);
                    perimeter = a + 2 * b;
                }
            }
            return (area);
        }
        public bool CosineTCheck()
        {
            double AngleC = 180 - 2 * Angle; // CONVERT COS TO DEGREES
            double CosValueDegrees = Math.Cos(AngleC * Math.PI / 180);
            double ApproximateASquared = Math.Round(2 * Math.Pow(b, 2) * (1 - CosValueDegrees), 2);
            // Console.WriteLine(ApproximateASquared); DEBUG
            double ApproximateA = Math.Round(Math.Sqrt(ApproximateASquared), 2);
            // Console.WriteLine(ApproximateA); DEBUG
            if (a == ApproximateA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IfGolden()
        {
            if (angle == 72)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IfSilver()
        {
            if ((angle == 36))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Show()
        {
            if (IfGolden() || IfSilver())
            {
                if (IfGolden())
                {
                    Console.WriteLine("--> a = {0}, b = {1}, h = {2}, P = {3}, S = {4}, Radius of an inscribed circle: {5}, Radius of an circumscribed circle: {6}", a, b, h, perimeter, area, radius, radiuS);
                    Console.WriteLine("Golden triangle! (Angle at base = {0})", angle);
                }
                if (IfSilver())
                {
                    Console.WriteLine("--> a = {0}, b = {1}, h = {2}, P = {3}, S = {4}, Radius of an inscribed circle: {5}, Radius of an circumscribed circle: {6}", a, b, h, perimeter, area, radius, radiuS);
                    Console.WriteLine("Silver triangle! (Angle at base = {0})", angle);
                }
            }
            else
            {
                if (angle == 60)
                {
                    Console.WriteLine("--> a = {0}, h = {1}, P = {2}, S = {3}, Radius of an inscribed circle: {4}, Radius of an circumscribed circle: {5}", a, h, perimeter, area, radius, radiuS);
                    Console.WriteLine("Non-golden triangle! (Angle at base = 60)");
                }
                else
                {
                    Console.WriteLine("--> a = {0}, b = {1}, h = {2}, P = {3}, S = {4}, Radius of an inscribed circle: {5}, Radius of an circumscribed circle: {6}", a, b, h, perimeter, area, radius, radiuS);
                    Console.WriteLine("Non-golden triangle! (Angle at base = {0})", angle);
                }
            }
        }
	}
}
