/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Correct_Pyramid.
	/// </summary>
	public class Correct_Pyramid
	{
		private double a;
        private double k;
        private double h;
        private double perimeter;
        private double s;
        private double s1;
        private double b;
        private double v;
        public double A
        {
            get { return this.a; }
            set
            {
                if (this.a < 0)
                {
                    throw new ArgumentException("-!- The side of the triangle in the piramid is not a positive number! -!-");
                }
                this.a = value;
            }
        }
        public double K
        {
            get { return this.k; }
            set
            {
                if (this.k < 0)
                {
                    throw new ArgumentException("-!- The apothem in the piramid is not a positive number! -!-");
                }
                this.k = value;
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
        public double S
        {
            get { return this.s; }
        }
        public double S1
        {
            get { return this.s1; }
        }
        public double B
        {
            get { return this.b; }
        }
        public double V
        {
            get { return this.v; }
        }
        public Correct_Pyramid()
        {
            v = 0;
        }
        public double Calculate()
        {
            string SQRT = "\u221A";
            if (Math.Pow(k, 2) > Math.Pow((Math.Sqrt(3) * a / 6), 2)) //Math.Round((Math.Sqrt(3)*a/6),2)>Math.Round(k,2)
            {
                h = Math.Round((Math.Pow(k, 2) - Math.Pow((Math.Sqrt(3) * a / 6), 2)), 2);
            }
            else
            {
                Console.WriteLine("-!- The apothem MUST be LESS than a{0}3/6 !  -!-", SQRT);
                return a;
            }
            perimeter = 3 * a;
            b = Math.Pow(a, 2) * Math.Sqrt(3) / 4;
            s = perimeter * k / 2;
            s1 = s + b;
            v = b * h / 3;
            return v;
        }
        public void Show()
        {
            Console.WriteLine("--> a = {0}, k = {1}, h = {2}, P = {3}, S = {4}, B = {5}, S1 = {6}, V = {7}", a, k, h, perimeter, s, b, s1, v);
        }
	}
}
