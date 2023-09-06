using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cuadrado : Shape
	{
		public float side;

		public Cuadrado(float side)
		{
			this.name = "Cuadrado";
			this.side = side;
		}


		public override float GetArea()
		{
			return side * side;
		}
	}
}
