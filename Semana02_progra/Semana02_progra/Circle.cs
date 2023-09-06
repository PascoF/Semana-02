﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02_progra
{
    class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.name = "Circle";
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
