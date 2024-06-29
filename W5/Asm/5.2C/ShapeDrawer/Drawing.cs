using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        StreamWriter writer;
        StreamReader reader;
        public Drawing (Color background) //  Constructor
        {
            _shapes = new List<Shape> ();
            _background = background;
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public Drawing() : this (Color.White)  // default Constructor
        {
        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public void AddShape (Shape shape)
        {
            _shapes.Add (shape);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape s in _shapes) 
            {
                s.Draw();
            }

        }

        public void SelectedShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))       //Select the clicked shapes
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }
        public List<Shape> SelectedShapes
        {
            get 
            {
                List<Shape> SelectedShapes = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        SelectedShapes.Add (s);
                    }
                }
                return SelectedShapes;
            }
        }

        public void RemoveShape()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }
            }
        }
        public void Save (string filename)
        {
            writer = new StreamWriter(filename);
            writer.WriteColor(_background);
            writer.WriteLine(ShapeCount);
            foreach (Shape s in _shapes)
                {
                s.SaveTo(writer);
                }
            writer.Close();
        }
        public void Load (string filename) 
        { 
            reader = new StreamReader(filename);
            try
            {
               Shape s;
            string kind;
            Background = reader.ReadColor();
            int count = reader.ReadInteger();
            _shapes.Clear();

            for (int i = 0; i<count; i++) 
            {
                kind = reader.ReadLine();
                switch(kind)
                {
                    case "Rectangle":
                        s = new MyRectangle();
                        break;

                    case "Circle":
                        s = new MyCircle();
                        break;

                    case "Line":
                        s = new MyLine();
                        break;

                    default: 
                        throw new InvalidDataException("Error at shape: " + kind);
                }
                s.LoadFrom(reader);
                AddShape(s);
            }
            }
            finally
            {
            reader.Close();
            }
            
        }
    }
}
