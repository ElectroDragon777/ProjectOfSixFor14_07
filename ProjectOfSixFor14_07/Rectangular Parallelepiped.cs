/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Rectangular_Parallelepiped.
	/// </summary>
	public class Rectangular_Parallelepiped
	{
		private double a;
		private double bside;
		private double c;
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
					throw new ArgumentException("The side of the parallelepiped is not a positive number!");
				}
				this.a = value;
			}
		}
		public double Bside
		{
			get { return this.bside; }
			set
			{
				if (this.bside < 0)
				{
					throw new ArgumentException("-!- The side of the parallelepiped is not a positive number! -!-");
				}
				this.bside = value;
			}
		}
		public double C
		{
			get { return this.c; }
			set
			{
				if (this.c < 0)
				{
					throw new ArgumentException("-!- The side of the parallelepiped is not a positive number! -!-");
				}
				this.c = value;
			}
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
		public Rectangular_Parallelepiped()
		{
			v = 0;
		}
		public double Calculate()
		{
			perimeter = 2 * (a + bside);
			b = a * bside;
			s = perimeter * c;
			s1 = s + 2 * b;
			v = b * c;
			return v;
		}
		public void Show()
		{
			Console.WriteLine("--> a = {0}, b = {1}, c = {2}, P = {3}, S = {4}, B = {5}, S1 = {6}, V = {7}", a, bside, c, perimeter, s, b, s1, v);
		}
	}
}
