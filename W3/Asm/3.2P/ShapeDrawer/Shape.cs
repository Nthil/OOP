using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        public Shape(int x, int y)
        {
            _color = Color.Blue;
            _x = x;
            _y = y;
            _width = _height = 100;
        }

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            else
            {
                SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            }
        }

        public bool IsAt(Point2D p)
        {
            return SplashKit.PointInRectangle(p, SplashKit.RectangleFrom(X, Y, _width, _height));
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }

          
    }
}
