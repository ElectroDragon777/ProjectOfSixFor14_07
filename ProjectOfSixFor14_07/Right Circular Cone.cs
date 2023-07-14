/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Right_Circular_Cone.
	/// </summary>
	public class Right_Circular_Cone
	{
		private double r;
        private double h;
        private double l;
        private double circlePerimeter;
        private double s;
        private double s1;
        private double b;
        private double v;
        public double R
        {
            get { return this.r; }
            set
            {
                if (this.r < 0)
                {
                    throw new ArgumentException("-!- The radius of the cone is not a positive number! -!-");
                }
                this.r = value;
            }
        }
        public double H
        {
            get { return this.h; }
            set
            {
                if (this.h < 0)
                {
                    throw new ArgumentException("-!- The height value is not a positive number! -!-");
                }
                this.h = value;
            }
        }
        public double L
        {
            get { return this.l; }
        }
        public double CirclePerimeter
        {
            get { return this.circlePerimeter; }
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
        public Right_Circular_Cone()
        {
            v = 0;
        }
        public double Calculate()
        {
            l = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2));
            circlePerimeter = Math.PI * 2 * r;
            b = Math.PI * Math.Pow(r, 2);
            s = Math.PI * r * l;
            s1 = s + b;
            v = b * h / 3;
            return v;
        }
        public void Show()
        {
            Console.WriteLine("--> r = {0}, h = {1}, l = {2}, C = {3}, S = {4}, S1 = {5}, B = {6}, V = {7}", r, h, l, circlePerimeter, s, s1, b, v);
        }
	}
}
