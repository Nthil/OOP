using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            Drawing myShape = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Rectangle;

            new Window("Drawing Shape", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                
                 //
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                //
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle newShape = new MyRectangle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        myShape.AddShape(newShape);
                    }
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newShape = new MyCircle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        myShape.AddShape(newShape);
                    }
                    if (kindToAdd == ShapeKind.Line)
                    {
                        MyLine newShape = new MyLine();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        myShape.AddShape(newShape);
                    }
                    Console.WriteLine("Mouse Left");
                }


                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myShape.SelectedShapesAt(SplashKit.MousePosition());
                    Console.WriteLine("Mouse Right");
                }
                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                    {
                        Console.WriteLine("Backspace");
                    }
                    if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                    {
                        Console.WriteLine("Delete");
                    }
                    myShape.RemoveShape();
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Background = SplashKit.RandomRGBColor(255);
                    Console.WriteLine("SpaceKey");
                }

                myShape.Draw();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Drawing Shape"));
        }
    }
}
