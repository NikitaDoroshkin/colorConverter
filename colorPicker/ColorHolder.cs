namespace colorPicker
{
    class ColorHolder
    {
        private RgbColor _rgbColor;
        private HslColor _hslColor;
        private CmykColor _cmykColor;

        public ColorHolder()
        {
            _rgbColor = new RgbColor(0, 0, 0);
            _hslColor = new HslColor(0, 0, 0);
            _cmykColor = new CmykColor(0, 0, 0, 1);
        }

        public RgbColor RgbColor
        {
            get => _rgbColor;
            set
            {
                _hslColor.Update(value);
                _cmykColor.Update(value);
                _rgbColor = value;
            }
        }

        public HslColor HslColor
        {
            get => _hslColor;
            set
            {
                _rgbColor.Update(value);
                _cmykColor.Update(_rgbColor);
                _hslColor = value;
            }
        }

        public CmykColor CmykColor
        {
            get => _cmykColor;
            set
            {
                _rgbColor.Update(value);
                _hslColor.Update(_rgbColor);
                _cmykColor = value;
            }
        }
    }
}
