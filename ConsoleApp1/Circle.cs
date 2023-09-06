﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.name = "Circulo";
            this.radius = radius;
        }

        public override float GetArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
