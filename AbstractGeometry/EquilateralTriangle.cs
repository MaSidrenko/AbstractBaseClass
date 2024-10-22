using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class EquilateralTriangle: Triangle
	{
		double side;
		public double Side
		{
			get => side;
			set => side = SizeFIlter(value);
		}
		public EquilateralTriangle(double side, int startX, int startY, int lineWidht, Color color): base(startX, startY, lineWidht, color)
		{
			Side = side;
		}
		public override double Get_Height_Triangle()
		{
			return Math.Sqrt(Math.Pow(side, 2) - (Math.Pow(side / 2, 2)));
		}
		public override double GetArea()
		{
			return 0.5 * Side * Get_Height_Triangle();
		}
		public override double GetPerimeter()
		{
			return 3 * Side;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			
			Point[] vertices =
			{
				new Point(StartX, StartY + (int) side ),
				new Point(StartX + (int) side, StartY + (int)side ),
				new Point(StartX+ (int) side/2, StartY + (int) side - (int)Get_Height_Triangle())
			};
			e.Graphics.DrawPolygon(pen, vertices);
		}
	}
}
