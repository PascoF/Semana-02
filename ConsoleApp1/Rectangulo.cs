using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangulo : Shape
	{
		private float width;
		private float height;

		public Rectangulo(float width, float height)
		{
			this.width = width;
			this.height = height;
		}

		public override float GetArea()
		{
			return width * height;
		}
	}
}
