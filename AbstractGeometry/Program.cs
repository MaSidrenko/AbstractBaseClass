//#define RECTANGLE
//#define TRIANGLE
#define CIRCLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Printing;


namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			///Console.WriteLine("Abstract Geometry");
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
	

#if RECTANGLE
			Rectangle rectangle = new Rectangle(100, 50, 450, 50, 3, Color.Red);
			rectangle.Info(e);
			Square square = new Square(100, 450, 150, 4, Color.OrangeRed);
			square.Info(e); 
#endif

#if TRIANGLE
			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(50, 60, 150, 5, Color.Orange);
			equilateralTriangle.Info(e);
			IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(60, 10, 150, 150, 5, Color.OrangeRed);
			isoscelesTriangle.Info(e);
			RightTriangle rightTriangle = new RightTriangle(70, 10, 200, 200, 5, Color.DarkOrange);
			rightTriangle.Info(e); 
#endif

#if CIRCLE
			Circle circle = new Circle(100, 100, 100, 5, Color.Orchid);
			circle.Info(e); 
#endif

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}