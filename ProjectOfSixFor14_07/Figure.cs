/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Figure.
	/// </summary>
	public class Figure
	{
		private string str;
		public string Str
		{
			get { return this.str; }
			set
			{
				if (str.Length == 0)
				{
					throw new ArgumentException("String length shouldn't be zero!");
				}
				this.str = value;
			}
		}
		public Figure(string str)
		{
			this.str = str;
			switch (this.str)
			{
				case "1.":
					{
						Circle circle = new Circle();
						Console.WriteLine(" --- III-1. Circle (Element to type in: R): --- ");
						Console.Write(" -> Type in the Radius: ");
						circle.Radius = double.Parse(Console.ReadLine());
						circle.CalculateProperties();
						circle.Show();
						break;
					}
				case "2.":
					{
						Rectangle rectangle = new Rectangle();
						Console.WriteLine(" --- III-2. Rectangle (Elements to type in: a (width), b (height)): ---");
						Console.Write(" -> Type in the Width: ");
						rectangle.Width = double.Parse(Console.ReadLine());
						Console.Write(" -> Type in the Height: ");
						rectangle.Height = double.Parse(Console.ReadLine());
						rectangle.Calculate();
						rectangle.Show();
						break;
					}
				case "3.":
					{
						Console.WriteLine(" --- III-3. Triangle (Elements to type in: a,b, angle between a&b): ---");
						Triangle triangle = new Triangle();
						Console.Write(" -> Type in the angle at the base of an isosceles triangle: ");
						triangle.Angle = double.Parse(Console.ReadLine());
						if (triangle.IfAnЕquilateralТriangle(triangle.Angle))
						{
							Console.Write(" -> (!60 degrees angles!) a = b = ");
							triangle.A = double.Parse(Console.ReadLine());
							triangle.B = triangle.A;
							triangle.Calculate();
							triangle.Show();
						}
						else
						{
							Console.WriteLine(" -> Insert a,b for the triangle.");
							Console.Write("a = ");
							triangle.A = double.Parse(Console.ReadLine());
							Console.Write("b = "); //Бедро
							triangle.B = double.Parse(Console.ReadLine());
							if ((Math.Round(triangle.A, 2) == Math.Round(triangle.B, 2)) || (triangle.A >= 2 * triangle.B))
							{
								if (triangle.Angle != 45)
								{
									if (Math.Pow(Math.Round(triangle.A, 3), 2) != Math.Round(triangle.B, 3))
									{
										Console.WriteLine("-!- You got this error maybe because: \n1) {0} degree angle doesn't support a = b = {1}\n2) a and b are not valid numbers for a triangle. -!-", triangle.Angle, triangle.A);
									}
								}
								else
								{
									Console.WriteLine("-!- You got this error maybe because: \n1) {0} degree angle doesn't support a = {1} and b = {2}. -!-", triangle.Angle, triangle.A, triangle.B);
								}
							}
							else
							{
								if (triangle.CosineTCheck())
								{
									triangle.Calculate();
									triangle.Show();
								}
								else
								{
									Console.WriteLine("-!- --> a = {0}, b = {1} doesn't exist according to the law of cosines ;-; -!-", triangle.A, triangle.B);
									Console.WriteLine("(Angle at base = {0})", triangle.Angle);
								}
							}
						}
						break;
					}
				case "4.":
					{
						Console.WriteLine(" --- III-4. Isosceles Trapezoid (Elements to type in: a,b,c): ---");
						Console.WriteLine(" -> Insert a,b,c for the isosceles trapezoid.");
						Isosceles_Trapezoid trapezoid = new Isosceles_Trapezoid();
						Console.Write("a = ");
						trapezoid.A = double.Parse(Console.ReadLine());
						Console.Write("b = ");
						trapezoid.B = double.Parse(Console.ReadLine());
						Console.Write("c = "); //бедро
						trapezoid.C = double.Parse(Console.ReadLine());
						trapezoid.Calculate();
						trapezoid.Show();
						break;
					}
				case "5.":
					{
						string SQRT = "\u221A";
						Console.WriteLine(" --- III-5. Correct/Right Triangle Pyramid (Elements to type in: a,k [-!- k<a{0}/6]): ---", SQRT);//sqrt symbol
						Correct_Pyramid CorrPyr = new Correct_Pyramid();
						Console.WriteLine(" -> Insert a,k for the correct/right pyramid.");
						Console.Write("a = ");
						CorrPyr.A = double.Parse(Console.ReadLine());
						Console.Write("k = ");
						CorrPyr.K = double.Parse(Console.ReadLine());
						if (Math.Pow(CorrPyr.K, 2) > Math.Pow((Math.Sqrt(3) * CorrPyr.A / 6), 2))
						{
							CorrPyr.Calculate();
							CorrPyr.Show();
						}
						break;
					}
				case "6.":
					{
						Console.WriteLine(" --- III-6. Rectangular Parallelepiped (Elements to type in: a,b,c [-!- c=h -!-]): ---");
						Rectangular_Parallelepiped RecPar = new Rectangular_Parallelepiped();
						Console.WriteLine(" -> Insert a,b,c for the parralelepiped.");
						Console.Write("a = ");
						RecPar.A = double.Parse(Console.ReadLine());
						Console.Write("b = ");
						RecPar.Bside = double.Parse(Console.ReadLine());
						Console.Write("c = ");
						RecPar.C = double.Parse(Console.ReadLine());
						RecPar.Calculate();
						RecPar.Show();
						break;
					}
				case "7.":
					{
						Console.WriteLine(" --- III-7. Right Circular Cylinder (Elements to type in: r,h): ---");
						Right_circular_cylinder RightCirCyl = new Right_circular_cylinder();
						Console.WriteLine("-> Insert r,h for the cylinder.");
						Console.Write("r = ");
						RightCirCyl.R = double.Parse(Console.ReadLine());
						Console.Write("h = ");
						RightCirCyl.H = double.Parse(Console.ReadLine());
						RightCirCyl.Calculate();
						RightCirCyl.Show();
						break;
					}
				case "8.":
					{
						Console.WriteLine(" --- III-8. Right Circular Cone (Elements to type in: r,h): ---");
						Right_Circular_Cone RightCirCone = new Right_Circular_Cone();
						Console.WriteLine(" -> Insert r,h for the cone.");
						Console.Write("r = ");
						RightCirCone.R = double.Parse(Console.ReadLine());
						Console.Write("h = ");
						RightCirCone.H = double.Parse(Console.ReadLine());
						RightCirCone.Calculate();
						RightCirCone.Show();
						break;
					}
				case "9.":
					{
						Console.WriteLine(" --- III-9. Right Circular Truncated Cone (Elements to type in: R,r,h [-!- R>r -!-]): ---");
						Right_Circular_Truncated_Cone RCTC = new Right_Circular_Truncated_Cone();
						Console.WriteLine(" -> Insert R,r,h for the truncated cone.");
						Console.Write("R = ");
						RCTC.R1 = double.Parse(Console.ReadLine());
						Console.Write("r = ");
						RCTC.R = double.Parse(Console.ReadLine());
						Console.Write("h = ");
						RCTC.H = double.Parse(Console.ReadLine());
						if (RCTC.R1 > RCTC.R)
						{
							RCTC.Calculate();
							RCTC.Show();
						}
						else
						{
							Console.WriteLine("-!- R MUST be bigger than r! (R>r) -!-");
						}
						break;
					}
				case "10.":
					{
						Console.WriteLine(" --- III-10. Sphere and Orb (Element to type in: R): ---");
						Sphere_and_Orb SphOrb = new Sphere_and_Orb();
						Console.WriteLine(" -> Type in the Radius:");
						Console.Write("R = ");
						SphOrb.R = double.Parse(Console.ReadLine());
						SphOrb.Calculate();
						SphOrb.Show();
						break;
					}
				default:
					{
						break;
					}
			}
		}
	}
}
