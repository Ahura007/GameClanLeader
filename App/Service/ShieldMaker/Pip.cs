using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using App.Service.Mouse;

namespace App.Service.ShieldMaker
{
    public static class Pip
    {
        public static List<Point> PointInPolygan(List<Point> corner)
        {
            var x = new List<Point>();
            var r = new Random();
            var minMaxX = new Point(corner.Min(p => p.X), corner.Max(p => p.X));
            var minMaxY = new Point(corner.Min(p => p.Y), corner.Max(p => p.Y));

            for (int i = 0; i < 200; i++)
            {
                int XX = r.Next(minMaxX.X, minMaxX.Y);
                int YY = r.Next(minMaxY.X, minMaxY.Y);
                var pp = new Point(XX, YY);
                var correctArea = RandomShieldMaker.PointInPolygon(pp, corner);
                if (correctArea)
                {
                    x.Add(pp);
                }
            }
            return x;
        }
    }
}
