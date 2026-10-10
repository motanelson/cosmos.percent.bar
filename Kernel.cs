using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;


namespace Cosmosbar
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1023;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.canvas.Clear(Color.White);
                while (true)
                {
                    Thread.Sleep(50);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {

        static int x = 0,w=7,h=40,y=400-20;
        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 3);

            
                
            graf.canvas.DrawFilledRectangle(p, new Sys.Graphics.Point(x*10, y), w, h);
            x = x + 1;
            if (x == 101)
            {
                x = 0;
                graf.canvas.Clear(Color.White);
            }
            graf.displays();
            

        }

    }






}
