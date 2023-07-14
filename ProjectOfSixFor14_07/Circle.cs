/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle
	{
		private double radius;
		private double diameter;
		private double circumference;
		private double area;
		public double Radius
		{
			get
			{
				return this.radius;
			}
			set
			{
				if (radius < 0)
				{
					throw new ArgumentException("-!- Radius should be not-negative! -!-");
				}
				this.radius = value;
			}
		}
		public double Diameter
		{
			get
			{
				return this.diameter;
			}
		}
		public double Circumference
		{
			get
			{
				return this.circumference;
			}
		}
		public double Area
		{
			get
			{
				return this.area;
			}
		}
		public Circle()
		{

		}
		public Circle(double rad)
		{
			Radius = rad;
		}
		public double CalculateProperties()
		{
			this.diameter = 2 * this.radius;
			this.circumference = 2 * Math.PI * this.radius;
			this.area = Math.PI * (this.radius * this.radius);
			return (diameter);
		}
		public void Show()
		{
			Console.WriteLine("R = {0}, D = {1}, C = {2}, S = {3}", Radius, Diameter, Circumference, Area);
		}
	}
}
