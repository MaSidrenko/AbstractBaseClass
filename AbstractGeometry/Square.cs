using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square: Rectangle
	{
		double side;
		public Square(double side, int startX, int startY, int lineWidht, Color color) : base(side, side, startX, startY, lineWidht, color)
		{ }
			
		
	}
}
