using System;

namespace colorPicker
{
    class HslColor
    {
        public double H { get; private set; }
        public double L { get; private set; }
        public double S { get; private set; }

        public HslColor(double h, double l, double s)
        {
            H = h;
            L = l;
            S = s;
        }

        public void Update(RgbColor rgb)
        {
            double r = (rgb.R / 255.0);
            double g = (rgb.G / 255.0);
            double b = (rgb.B / 255.0);

            double min = Math.Min(Math.Min(r, g), b);
            double max = Math.Max(Math.Max(r, g), b);
            double delta = max - min;

            L = (max + min) / 2;

            if (delta == 0)
            {
                H = 0;
                S = 0.0f;
            }
            else
            {
                S = (L <= 0.5) ? (delta / (max + min)) : (delta / (2 - max - min));

                double hue;

                if (r == max)
                {
                    hue = ((g - b) / 6) / delta;
                }
                else if (g == max)
                {
                    hue = (1.0f / 3) + ((b - r) / 6) / delta;
                }
                else
                {
                    hue = (2.0f / 3) + ((r - g) / 6) / delta;
                }

                if (hue < 0)
                    hue += 1;
                if (hue > 1)
                    hue -= 1;

                H = (int)(hue * 360);
            }
        }
    }
}
