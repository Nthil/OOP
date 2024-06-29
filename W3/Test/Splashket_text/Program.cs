using System;
using SplashKitSDK;

namespace splashket_text
{
    public class Program
    {
        static SoundEffect sound;
        static void PlayMusic(string name)
        {
            sound = SplashKit.SoundEffectNamed(name);
            sound.Play();
        }
        public static void Main()
        {
            string musicname = "";
            new Window("New games", 800, 600);
            SplashKit.LoadSoundEffect("SummerTime", "Lana1.mp3");
            SplashKit.LoadSoundEffect("The Man I Love", "Lana2.mp3");
            SplashKit.LoadSoundEffect("Hotel no.2", "Lana3.mp3");
            //SoundEffect sound = SplashKit.SoundEffectNamed("Lana");
            //sound.Play();
            do
            {
                SplashKit.ProcessEvents();
                //SplashKit.DrawCircle(Color.Red, 100, 100, 20);
                //SplashKit.FillCircle(Color.Red, 100, 100, 20);
                //SplashKit.DrawRectangle(Color.Blue, 100, 100, 40, 40);
                SplashKit.DrawText("Select Music" + (10 + musicname), Color.BlueViolet, 100, 80);
                SplashKit.DrawTriangle(Color.Red, 100, 100, 120, 120, 100, 140);
                SplashKit.DrawText("1. SummerTime", Color.BlueViolet, 130, 115);
                SplashKit.DrawTriangle(Color.Red, 100, 160, 120, 180, 100, 200);
                SplashKit.DrawText("2. The Man I Love", Color.BlueViolet, 130, 175);
                SplashKit.DrawTriangle(Color.Red, 100, 220, 120, 240, 100, 260);
                SplashKit.DrawText("3. Hotel no.2", Color.BlueViolet, 130, 235);

                if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.MousePosition().X >= 100 && SplashKit.MousePosition().X <= 300 && SplashKit.MousePosition().Y >= 100 && SplashKit.MousePosition().Y <= 140)
                {
                    if (sound != null)
                    { 
                        sound.Stop();
                    }

                    PlayMusic("SummerTime");
                    musicname = "SummerTime";
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.MousePosition().X >= 100 && SplashKit.MousePosition().X <= 300 && SplashKit.MousePosition().Y >= 160 && SplashKit.MousePosition().Y <= 200)
                {
                    if (sound != null)
                        sound.Stop();
                    PlayMusic("The Man I Love");
                    musicname = "The Man I Love";
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.MousePosition().X >= 100 && SplashKit.MousePosition().X <= 300 && SplashKit.MousePosition().Y >= 220 && SplashKit.MousePosition().Y <= 260)
                {
                    if (sound != null)
                        sound.Stop();
                    PlayMusic("Hotel no.2");
                    musicname = "Hotel no.2";
                }
                //SplashKit.ClearScreen();

                //SplashKit.DrawText("Hello World",Color.Blue, 150, 200);
                //SplashKit.DrawText("Mouse Position" + SplashKit.MousePosition().X.ToString() + SplashKit.MousePosition().Y.ToString(),Color.Blue, 400, 200);
                SplashKit.RefreshScreen();
                SplashKit.ClearScreen();
                SplashKit.Delay(2);
            }
            while (!SplashKit.WindowCloseRequested("New games"));
        }
    }
}
