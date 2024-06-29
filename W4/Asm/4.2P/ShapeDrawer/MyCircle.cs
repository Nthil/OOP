using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(Color clr, int rad) : base(clr)
        {
            _radius = rad;
        }
        public MyCircle() : this(Color.Blue, 50) //Set MyCirCle's rad to 50
        { 
        }
        public override void Draw()
        {
            if (Selected) DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.White, X, Y, _radius + 2);
        }
        public override bool IsAt(Point2D pt) // Check if the point is within the circle
        {
            double a = (double)(pt.X - X);
            double b = (double)(pt.Y - Y);
            if (Math.Sqrt(a*a + b*b) < _radius)
            {
                return true;
            }
            return false;
        }
    }
}
