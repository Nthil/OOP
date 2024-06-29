using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private int _length;

        public MyLine(Color clr, int length) : base(clr)
        {
            _length = length;
        }
        public MyLine() : this(Color.BlueViolet, 150)
        {
        }
        public override void Draw()
        {
            if (Selected) DrawOutline();
            SplashKit.DrawLine(Color, X, Y, X + _length, Y);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.White, X - 2, Y - 2, _length + 4, 4);
        }
        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, X + _length, Y));   
        }
    }
}
