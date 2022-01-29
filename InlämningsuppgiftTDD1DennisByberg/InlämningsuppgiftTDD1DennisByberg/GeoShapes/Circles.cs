﻿using InlämningsuppgiftTDD1DennisByberg.Shapes;
using System;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Circles : IShapeModel
    {
        public float Radius { get; }

        public Circles(float radius)
        {
            Radius = radius;
        }

        public float Area()
        {
            var circleArea = (float)Math.PI * Radius * Radius;
            return circleArea;
        }

        public float Perimeter()
        {
            var diameter = Radius * 2;
            var perimeter = (float)Math.PI * diameter;
            return perimeter;
        }
    }
}
