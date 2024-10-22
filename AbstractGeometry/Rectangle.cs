using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Rectangle: Shape, IHaveDiagonal
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = SizeFIlter(value);
		}
		public double Height
		{ 
			get => height;
			set => height = SizeFIlter(value);
		}
		public Rectangle
			(
				double width, double height, 
				int startX, int startY, int lineWidht, Color color
			)
			:base(startX, startY, lineWidht, color)
		{
			Width = width;
			Height = height;
		}
		public double GetDiagonal()
		{
			return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height,2));
		}
		public override double GetArea()=> Width * Height;
		public override double GetPerimeter()=>2 * (Width + Height);
		
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX,StartY, (int)Width, (int)Height);
			DrawDiagonal(e);
		}
		public void DrawDiagonal(PaintEventArgs e)
		{
			e.Graphics.DrawLine(new Pen(Color, LineWidth), StartX, StartY, StartX + (int)Width, StartY + (int)Height);
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
            Console.WriteLine("Высота: " + height);
            Console.WriteLine("Ширина: " + width);
		}
	}
}
