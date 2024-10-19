using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle: Shape
	{
		double radius;
		double Radius
		{
			get => radius;
			set=>radius = SizeFIlter(value);
		}
		public Circle(double radius, int startX, int startY, int lineWidht, Color color): base(startX, startY, lineWidht, color)
		{
			Radius = radius;
		}
		public double get_diameter()
		{
			return 2 * Radius;
		}
		public override double GetArea()
		{
			return Math.PI * (Math.Pow(Radius, 2));
		}
		public override double GetPerimeter()
		{
			return Math.PI * get_diameter();
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, StartX + (int)get_diameter(),StartY + (int)get_diameter());
		}
	}
}
