namespace colorPicker
{
    internal class ColorValidator
    {
        private double _min;
        private double _max;

        public ColorValidator(double min, double max)
        {
            _min = min;
            _max = max;
        }

        public virtual bool Validate(string valueString)
        {
            double value;
            if (double.TryParse(valueString, out value))
            {
                return value >= _min && value <= _max;
            }
            return false;
        }
    }
}
