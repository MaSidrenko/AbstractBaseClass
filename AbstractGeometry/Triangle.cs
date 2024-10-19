using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract internal class Triangle: Shape
	{
		public Triangle(int startX, int startY, int lineWidht, Color color): base(startX, startY, lineWidht, color) { }
		public abstract double get_height_triangle();
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
            Console.WriteLine("Высота треугольника: " + get_height_triangle());
		}
	}
}
