using System;

namespace colorPicker
{
    class CmykColor
    {
        public double C { get; private set; }
        public double M { get; private set; }
        public double Y { get; private set; }
        public double K { get; private set; }

        public CmykColor(double c, double m, double y, double k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }

        public void Update(RgbColor color)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            K = HandleCorner(Math.Min(1.0 - red / 255.0, Math.Min(1.0 - green / 255.0, 1.0 - blue / 255.0)));
            C = HandleCorner((1.0 - (red / 255.0) - K) / (1.0 - K));
            M = HandleCorner((1.0 - (green / 255.0) - K) / (1.0 - K));
            Y = HandleCorner((1.0 - (blue / 255.0) - K) / (1.0 - K));

            double HandleCorner(double value)
            {
                if (value < 0 || double.IsNaN(value))
                {
                    value = 0;
                }

                return value;
            }
        }
    }
}
