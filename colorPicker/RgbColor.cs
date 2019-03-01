using System;

namespace colorPicker
{
    class RgbColor
    {
        public double R { get; private set; }
        public double G { get; private set; }
        public double B { get; private set; }

        public RgbColor(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }

        public void Update(HslColor color)
        {
            if (color.S == 0)
            {
                R = G = B = (byte)(color.L * 255);
            }
            else
            {
                double m1, m2;
                double hue = color.H / 360;

                m2 = (color.L < 0.5) ? (color.L * (1 + color.S)) : ((color.L + color.S) - (color.L * color.S));
                m1 = 2 * color.L - m2;

                R = (int)(255 * HueToRGB(m1, m2, hue + (1.0f / 3)));
                G = (int)(255 * HueToRGB(m1, m2, hue));
                B = (int)(255 * HueToRGB(m1, m2, hue - (1.0f / 3)));
            }

            double HueToRGB(double v1, double v2, double vH)
            {
                if (vH < 0)
                    vH += 1;

                if (vH > 1)
                    vH -= 1;

                if ((6 * vH) < 1)
                    return (v1 + (v2 - v1) * 6 * vH);

                if ((2 * vH) < 1)
                    return v2;

                if ((3 * vH) < 2)
                    return (v1 + (v2 - v1) * ((2.0f / 3) - vH) * 6);

                return v1;
            }
        }

        public void Update(CmykColor color)
        {
            double cyan = color.C;
            double magenta = color.M;
            double yellow = color.Y;
            double black = color.K;

            R = Convert.ToByte((1 - Math.Min(1, cyan * (1 - black) + black)) * 255);
            G = Convert.ToByte((1 - Math.Min(1, magenta * (1 - black) + black)) * 255);
            B = Convert.ToByte((1 - Math.Min(1, yellow * (1 - black) + black)) * 255);
        }
    }
}
