using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangulo : Shape
    {
        private float Base;
        private float height;

		public Triangulo(float Base, float height)
		{
			this.name = "Triangulo";
			this.Base = Base;
			this.height = height;
		}

		public override float GetArea()
		{
			return (Base * height)/2;
		}

	}
}
