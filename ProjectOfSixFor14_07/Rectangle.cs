/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Rectangle.
	/// </summary>
	public class Rectangle
	{
		 private double width;
        private double height;
        private double area;
        private double radius;
        private double radiuS;
        public double Width
        {
            get { return this.width; }
            set
            {
                if (this.width < 0)
                {
                    throw new ArgumentException("-!- Width is not a positive number! -!-");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (this.height < 0)
                {
                    throw new ArgumentException("-!- Height is not a positive number! -!-");
                }
                this.height = value;
            }
        }
        public double Area
        {
            get { return this.area; }
        }
        public double Radius
        {
            get { return this.radius; }
        }
        public double RadiuS
        {
            get { return this.radiuS; }
        }
        public Rectangle()
        {

        }
        public bool IfGolden(double width, double height) //width = a; height = b => a = b^3/[(1-b)*(1+b)] //3, 4.854
        {
            if (width > height)
            {
                if (Math.Round(width / height, 3) == 1.618) //Math.Round(height/(width-height),3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (width < height)
                {
                    if (Math.Round(height / width, 3) == 1.618)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public double Calculate()
        {
            this.area = this.width * this.height;
            if (width == height)
            {
                this.radius = width / 2;
                this.radiuS = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)) / 2;
            }
            return (area);
        }
        public void Show()
        {
            if (!IfGolden(width, height))
            {
                if (width == height)
                {
                    Console.WriteLine("--> Width: {0}, Height: {1}, Area: {2}, Radius of an inscribed circle: {3}, Radius of an circumscribed circle: {4}", Width, Height, Area, Radius, RadiuS);
                    Console.WriteLine("Non-golden square.");
                }
                else
                {
                    Console.WriteLine("--> Width: {0}, Height: {1}, Area: {2}", Width, Height, Area);
                    Console.WriteLine("Non-golden rectangle.");
                }

            }
            else
            {
                if (width == height)
                {
                    Console.WriteLine("--> Width: {0}, Height: {1}, Area: {2}, Radius of an inscribed circle: {3}, Radius of an circumscribed circle: {4}", Width, Height, Area, Radius, RadiuS);
                    Console.WriteLine("Lucky! It is a golden square.");
                }
                else
                {
                    Console.WriteLine("--> Width: {0}, Height: {1}, Area: {2}", Width, Height, Area);
                    Console.WriteLine("Lucky! It is a golden rectangle.");
                }
            }
        }
	}
}
