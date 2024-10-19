using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class RightTriangle: Triangle
	{
		double side;
		double a;//Основание треугольника
		double Side
		{
			get => side;
			set => side = SizeFIlter(value);
		}
		double A
		{
			get => a;
			set => a = SizeFIlter(value);
		}
	
		public RightTriangle(double side, double a,  int startX, int startY, int lineWidht, Color color): base(startX, startY, lineWidht, color)
		{
			Side = side;
			A = a;
			
		}
		public override double get_height_triangle()
		{
			return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(A / 2, 2));
		}
		public override double GetArea()
		{
			return 0.5 * Side * get_height_triangle();
		}
		public override double GetPerimeter()
		{
			return Side + A + get_height_triangle();
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] vertices =
			{
				new Point(StartX, StartY + (int)get_height_triangle()),
				new Point(StartX + (int)A, StartY),
				new Point(StartX + (int)A, StartY + (int)get_height_triangle())
			};
			e.Graphics.DrawPolygon(pen, vertices);
		}
	}
}
