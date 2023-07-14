/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Right_circular_cylinder.
	/// </summary>
	public class Right_circular_cylinder
	{
		private double r;
        private double h;
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
                    throw new ArgumentException("-!- The radius of the cylinder is not a positive number! -!-");
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
        public Right_circular_cylinder()
        {
            v = 0;
        }
        public double Calculate()
        {
            circlePerimeter = Math.PI * 2 * r;
            b = Math.PI * Math.Pow(r, 2);
            s = circlePerimeter * h;
            s1 = s + 2 * b;
            v = b * h;
            return v;
        }
        public void Show()
        {
            Console.WriteLine("--> r = {0}, h = {1}, C = {2}, S = {3}, S1 = {4}, B = {5}, V = {6}", r, h, circlePerimeter, s, s1, b, v);
        }
	}
}
