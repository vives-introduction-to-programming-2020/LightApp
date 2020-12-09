using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
    class LightBulb
    {
        // LightBulb
        // ------------------
        // - brightness : int        // 0 - 100
        // - isOn : bool
        // - location: string
        // ------------------
        // + LightBulb()
        // + LightBulb(brightness: int)
        // + LightBulb(brightness: int, location: string)
        // + On()
        // + Off()
        // + SetLocation(location: string)
        // + Dim(percentage : int)
        // + ToString() : string
        // ------------------

        // Constructor:
        // - Same name as the class
        // - No return type, not even void
        // - Almost always public
        public LightBulb(int brightness, string location)
        {
            // this.brightness = brightness;
            Dim(brightness);
            SetLocation(location);
        }

        public LightBulb(int brightness)
        {
            // this.brightness = brightness;
            Dim(brightness);
        }

        // Default Constructor
        // = With no arguments
        public LightBulb()
        {
            //this.brightness = 50;
            Dim(50);
        }

        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }

        public void Dim(int percentage)
        {
            brightness = percentage;
            On();   // If off we turn on
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }

        public override string ToString()
        {
            if (isOn)
            {
                return $"{location} Lamp is on with a brighness of {brightness} percentage.".Trim();
            }
            else
            {
                return $"{location} Lamp is off.".Trim();
            }
        }

        private int brightness = 0;
        private bool isOn = false;
        private string location = "";
    }
}
