using System;
using System.Collections.Generic;
using System.Drawing;

namespace App.Service.ShieldMaker
{
    public static class RandomShieldMaker
    {
        public static bool PointInPolygon(Point p, List<Point> points)
        {
            var maxPoint = points.Count-1;
            var totalAngle = GetAngle(points[maxPoint].X, points[maxPoint].Y, p.X, p.Y, points[0].X, points[0].Y);
            for (var i = 0; i < maxPoint; i++)
            {
                totalAngle += GetAngle(points[i].X, points[i].Y, p.X, p.Y, points[i + 1].X, points[i + 1].Y);
            }
            return (Math.Abs(totalAngle) > 0.000001);
        }

        private static float GetAngle(float ax, float ay, float bx, float @by, float cx, float cy)
        {
            var dotProduct = DotProduct(ax, ay, bx, @by, cx, cy);
            var crossProduct = CrossProductLength(ax, ay, bx, @by, cx, cy);
            return (float)Math.Atan2(crossProduct, dotProduct);
        }

        private static float DotProduct(float ax, float ay, float bx, float @by, float cx, float cy)
        {
            var bAx = ax - bx;
            var bAy = ay - @by;
            var bCx = cx - bx;
            var bCy = cy - @by;
            return (bAx * bCx + bAy * bCy);
        }

        private static float CrossProductLength(float ax, float ay, float bx, float @by, float cx, float cy)
        {
            var bAx = ax - bx;
            var bAy = ay - @by;
            var bCx = cx - bx;
            var bCy = cy - @by;
            return (bAx * bCy - bAy * bCx);
        }

    }
}
