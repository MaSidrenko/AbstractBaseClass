using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle: Shape, IHaveDiameter
	{
		double radius;
		double Radius
		{
			get => radius;
			set => radius = SizeFIlter(value);
		}
		public Circle(double radius, int startX, int startY, int lineWidht, Color color): base(startX, startY, lineWidht, color)
		{
			Radius = radius;
		}
		//public double get_diameter()=>2 * Radius;
		public double GetDiameter() => 2 * Radius;
		public override double GetArea() => Math.PI * (Math.Pow(Radius, 2));
		public override double GetPerimeter() => Math.PI * GetDiameter();
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)GetDiameter(), (float)GetDiameter());
			DrawDiameter(e);
		}
		public void DrawDiameter(PaintEventArgs e)
		{
			double dx = Radius * (1 - 1 / Math.Sqrt(2));
			e.Graphics.DrawLine
				(
					new Pen(Color, LineWidth), 
					StartX + (float)dx, StartY + (float)dx, 
					StartX + (float)GetDiameter() - (float)dx, StartY + (float)GetDiameter() - (float)dx
				);
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
            Console.WriteLine("Радиус круга: " + Radius);
            Console.WriteLine("Диаметер круга: " + GetDiameter());
		}
	}
}
