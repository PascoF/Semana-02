using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Shape
	{

		protected string name;

		public string GetName()
		{
			return name;
		}


		public virtual float GetArea()
		{
			return 0;
		}
	}
}
