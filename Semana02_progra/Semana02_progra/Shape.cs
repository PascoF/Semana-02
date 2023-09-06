using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02_progra
{
    class Shape
    {
        protected string name;

        public string GetName()
        {
            return name;
        }

        public virtual float CalculateArea()
        {
            return 0;
        }
    }
}
