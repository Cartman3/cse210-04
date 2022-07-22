using System.Collections.Generic;


namespace cse210_04.Game.Casting
{
    // A color.
    // The responsibility of Color is to hold and provide information about itself. Color has 
    // a few convenience methods for comparing and converting them.
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        // Constructs a new instance of Color using the given red, green and blue values.
        // The given red value (0-255).
        // The given green value (0-255).
        // The given blue value (0-255).
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        // Gets the color's alpha value.
        // The alpha value.
        public int GetAlpha()
        {
            return alpha;
        }

        // Gets the color's blue value.
        // The blue value.
        public int GetBlue()
        {
            return blue;
        }

        // Gets the color's green value.
        // The green value.
        public int GetGreen()
        {
            return green;
        }

        // Gets the color's red value.
        // The red value.
        public int GetRed()
        {
            return red;
        }

    }
}