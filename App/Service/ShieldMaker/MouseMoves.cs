using System.Drawing;
using System.Threading;
using App.Service.Mouse;

namespace App.Service.ShieldMaker
{
    public class MouseMoves
    {
        public static void LinearSmoothMove(Point newPosition, int steps)
        {
            MouseOperations.MousePoint start = MouseOperations.GetCursorPosition();
            Point p = new Point(start.X, start.Y);
            PointF iterPoint = p;

            // Find the slope of the line segment defined by start and newPosition
            PointF slope = new PointF(newPosition.X - start.X, newPosition.Y - start.Y);

            // Divide by the number of steps
            slope.X = slope.X / steps;
            slope.Y = slope.Y / steps;

            // Move the mouse to each iterative point.
            for (int i = 0; i < steps; i++)
            {
                iterPoint = new PointF(iterPoint.X + slope.X, iterPoint.Y + slope.Y);

                MouseOperations.MousePoint o = new MouseOperations.MousePoint((int)iterPoint.X, (int)iterPoint.Y);
                MouseOperations.SetCursorPosition(o);
                Thread.Sleep(1);
            }

            // Move the mouse to the final destination.
            MouseOperations.SetCursorPosition(newPosition.X, newPosition.Y);
        }
    }
}