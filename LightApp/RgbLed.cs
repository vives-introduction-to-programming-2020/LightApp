using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
    class RgbLed
    {
        // RgbLed
        // --------------------------
        // - color: Color
        // - isOn: boolean
        // --------------------------
        // + On()
        // + Off()
        // + SetColor(color: Color)
        // + ToString(): string
        // --------------------------

        public void On()
        {
            isOn = true;
        }
        public void Off()
        {
            isOn = false;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            if (!isOn)
            {
                return "The LED is off";
            } else
            {
                return "The LED is on with a color of " + color;
            }
        }

        private Color color = new Color();      // without new Color() => null
        private bool isOn = false;
    }
}
