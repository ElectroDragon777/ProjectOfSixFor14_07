/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Sphere_and_Orb.
	/// </summary>
	public class Sphere_and_Orb
	{
		private double r;
        private double s;
        private double v;
        public double R
        {
            get { return this.r; }
            set
            {
                if (this.r < 0)
                {
                    throw new ArgumentException("-!- Radius is not a positive number! -!-");
                }
                this.r = value;
            }
        }
        public double S
        {
            get { return this.s; }
        }
        public double V
        {
            get { return this.v; }
        }
        public Sphere_and_Orb()
        {
            s = 0;
            v = 0;
        }
        public double Calculate()
        {
            s = 4 * Math.PI * Math.Pow(r, 2);
            v = s * r / 3;
            return v;
        }
        public void Show()
        {
            Console.WriteLine("--> Sphere: r = {0}, S = {2}.\nOrb: r = {0}, V = {1}", r, v, s);
        }
	}
}
