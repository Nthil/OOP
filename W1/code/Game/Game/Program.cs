// See https://aka.ms/new-console-template for more information

namespace MyProject;
class Tank
{
    string Color;
    int x, y;

    public void setPosition(int x1, int y1)
    {
        x = x1;
        y = y1;
    }

    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }
    public void setColor(string c1)
    {
        color = c1;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Tank Player1 = new Tank();
        Player1.setColor("Green");
        Player1.setPosition(200, 200);

        Tank Player2 = new Tank();
        Player2.setColor("Yellow");
        Player2.setPosition(50, 180);

        Tank V1 = new Tank();
        V1.setColor("White");
        V1.setPosition(100, 0);

        Tank V2 = new Tank();
        V2.setColor("White");
        V2.setPosition(220, 0);

        Console.WriteLine("Current Position: " + Player1.GetX().ToString() + " - " + Player1.GetY().ToString());
        Console.ReadKey;

        Player1.setPosition(50, 200);
        Console.WriteLine("New Position: " + Player1.GetX().ToString() + " - " + Player1.GetY().ToString());
        Console.ReadKey;
    }
}