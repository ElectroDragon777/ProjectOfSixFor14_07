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
	/// Description of Right_Circular_Truncated_Cone.
	/// </summary>
	public class Right_Circular_Truncated_Cone
	{
		private double rBig;
        private double r;
        private double h;
        private double l;
        private double s;
        private double s1;
        private double v;
        public double R1
        {
            get { return this.rBig; }
            set
            {
                if (this.rBig < 0)
                {
                    throw new ArgumentException("-!- The radius of the bigger circle is not a positive number! -!-");
                }
                this.rBig = value;
            }
        }
        public double R
        {
            get { return this.r; }
            set
            {
                if (this.r < 0)
                {
                    throw new ArgumentException("-!- The radius of the smallest circle is not a positive number! -!-");
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
        public double S
        {
            get { return this.s; }
        }
        public double S1
        {
            get { return this.s1; }
        }
        public double V
        {
            get { return this.v; }
        }
        public Right_Circular_Truncated_Cone()
        {
            v = 0;
        }
        public double Calculate()
        {
            l = Math.Sqrt(Math.Pow((rBig - r), 2) + Math.Pow(h, 2));
            s = Math.PI * r * l;
            s1 = s + Math.PI * (Math.Pow(rBig, 2) + Math.Pow(r, 2));
            v = (Math.PI * h / 3) * (Math.Pow(rBig, 2) + Math.Pow(r, 2) + rBig * r);
            return v;
        }
        public void Show()
        {
            Console.WriteLine("--> R = {0}, r = {1}, h = {2}, l = {3}, S = {4}, S1 = {5}, V = {6}", rBig, r, h, l, s, s1, v);
        }
	}
}
