using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
    class Color
    {
        // Color
        // ---------------------------------
        // - red: int           // 0 - 255
        // - green: int         // 0 - 255
        // - blue: int          // 0 - 255
        // ---------------------------------
        // + Color()
        // + Color(red: int, green:int, blue: int)
        // 
        // + SetRed(red: int)       // this.red = red
        // + SetGreen(red: int)
        // + SetBlue(red: int)
        //
        // + GetRed() : int         // return red
        // + GetGreen() : int
        // + GetBlue() : int
        //
        // + ToString(): string     // [R=10, G=24, B=55]
        // ---------------------------------

        // Color blueish = new Color();
        // blueish.SetBlue(40);
        // blueish.SetGreen(4);
        // int blue = blueish.GetBlue();

        // Default constructor = No arguments
        public Color()
        {
            SetRed(0);
            SetGreen(0);
            SetBlue(0);
        }

        public Color(int red, int green, int blue)
        {
            SetRed(red);
            SetGreen(green);
            SetBlue(blue);
        }

        public void SetRed(int red)
        {
            //if (red < 0)
            //{
            //    red = 0;
            //}
            //else if (red > 255)
            //{
            //    red = 255;
            //}
            //this.red = red;

            // this.red = Math.Abs(red % 255); // Not so good

            this.red = Math.Max(Math.Min(red, 255), 0);
        }

        public void SetGreen(int green)
        {
            this.green = Math.Max(Math.Min(green, 255), 0);
        }

        public void SetBlue(int blue)
        {
            this.blue = Math.Max(Math.Min(blue, 255), 0);
        }

        public int GetRed()
        {
            return red;
        }
        public int GetGreen()
        {
            return green;
        }
        public int GetBlue()
        {
            return blue;
        }

        public void Dim(int percentage)
        {
            percentage = Math.Max(Math.Min(percentage, 100), 0);

            SetRed(percentage * red / 100);
            SetGreen(percentage * green / 100);
            SetBlue(percentage * blue / 100);
        }

        public override string ToString()
        {
            return $"[R={red}, G={green}, B={blue}]";
        }

        private int red = 0;
        private int green = 0;
        private int blue = 0;
    }
}
