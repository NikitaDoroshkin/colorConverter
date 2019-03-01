namespace colorPicker
{
    class ColorHolder
    {
        private RgbColor _rgbColor;
        private HlsColor _hlsColor;
        private CmykColor _cmykColor;

        public ColorHolder()
        {
            _rgbColor = new RgbColor(0, 0, 0);
            _hlsColor = new HlsColor(0, 0, 0);
            _cmykColor = new CmykColor(0, 0, 0, 1);
        }

        public RgbColor RgbColor
        {
            get => _rgbColor;
            set
            {
                _hlsColor.Update(value);
                _cmykColor.Update(value);
                _rgbColor = value;
            }
        }

        public HlsColor HlsColor
        {
            get => _hlsColor;
            set
            {
                _rgbColor.Update(value);
                _cmykColor.Update(_rgbColor);
                _hlsColor = value;
            }
        }

        public CmykColor CmykColor
        {
            get => _cmykColor;
            set
            {
                _rgbColor.Update(value);
                _hlsColor.Update(_rgbColor);
                _cmykColor = value;
            }
        }
    }
}
