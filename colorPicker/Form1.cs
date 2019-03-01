using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace colorPicker
{
    public partial class ColorForm : Form
    {
        // Validators
        private Dictionary<ValidatorType, ColorValidator> _validators = new Dictionary<ValidatorType, ColorValidator>
        {
            {ValidatorType.RGB, new ColorValidator(0, 255) },
            {ValidatorType.Fraction, new ColorValidator(0, 1) },
            {ValidatorType.Degree, new ColorValidator(0, 360) }
        };
        private Dictionary<ColorSpaceEnum, String> _validationErrors = new Dictionary<ColorSpaceEnum, string>
        {
            { ColorSpaceEnum.RGB, "R, G, B in [0,255]" },
            { ColorSpaceEnum.HLS, "H in [0,360]; L, S in [0,100]" },
            { ColorSpaceEnum.CMYK, "C, M, Y, K in [0,100]" }
        };

        //Holder
        private ColorHolder _colorHolder = new ColorHolder();
        private bool _changeInProgress = false;

        public ColorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.Color = RgbToSystemColor();
            colorDialog.ShowDialog();

            RgbRBox.Text = colorDialog.Color.R.ToString();
            RgbGBox.Text = colorDialog.Color.G.ToString();
            RgbBBox.Text = colorDialog.Color.B.ToString();
        }

        private void ChangeColor(ColorSpaceEnum space)
        {
            _changeInProgress = true;

            switch (space)
            {
                case ColorSpaceEnum.RGB:
                    _colorHolder.RgbColor = new RgbColor(
                        Double.Parse(RgbRBox.Text),
                        Double.Parse(RgbGBox.Text),
                        Double.Parse(RgbBBox.Text));
                    break;
                case ColorSpaceEnum.HLS:
                    _colorHolder.HlsColor = new HlsColor(
                        Double.Parse(HlsHBox.Text),
                        Double.Parse(HlsLBox.Text),
                        Double.Parse(HlsSBox.Text));
                    break;
                case ColorSpaceEnum.CMYK:
                    _colorHolder.CmykColor = new CmykColor(
                        Double.Parse(CmykCBox.Text),
                        Double.Parse(CmykMBox.Text),
                        Double.Parse(CmykYBox.Text),
                        Double.Parse(CmykKBox.Text));
                    break;
                default:
                    break;
            }

            UpdateInterface(space);

            _changeInProgress = false;
        }

        private void UpdateInterface(ColorSpaceEnum space)
        {
            UpdateRgb();
            UpdateHls();
            UpdateCmyk();

            UpdateBox();
        }

        void UpdateRgb()
        {
            RgbRBox.Text = _colorHolder.RgbColor.R.ToString();
            RgbGBox.Text = _colorHolder.RgbColor.G.ToString();
            RgbBBox.Text = _colorHolder.RgbColor.B.ToString();

            RgbRBar.Value = (int)_colorHolder.RgbColor.R;
            RgbGBar.Value = (int)_colorHolder.RgbColor.G;
            RgbBBar.Value = (int)_colorHolder.RgbColor.B;
        }

        void UpdateCmyk()
        {
            CmykCBox.Text = Math.Round(_colorHolder.CmykColor.C, 2).ToString();
            CmykMBox.Text = Math.Round(_colorHolder.CmykColor.M, 2).ToString();
            CmykYBox.Text = Math.Round(_colorHolder.CmykColor.Y, 2).ToString();
            CmykKBox.Text = Math.Round(_colorHolder.CmykColor.K, 2).ToString();

            CmykCBar.Value = (int)(_colorHolder.CmykColor.C * 100);
            CmykMBar.Value = (int)(_colorHolder.CmykColor.M * 100);
            CmykYBar.Value = (int)(_colorHolder.CmykColor.Y * 100);
            CmykKBar.Value = (int)(_colorHolder.CmykColor.K * 100);
        }

        void UpdateHls()
        {
            HlsHBox.Text = _colorHolder.HlsColor.H.ToString();
            HlsLBox.Text = _colorHolder.HlsColor.L.ToString();
            HlsSBox.Text = _colorHolder.HlsColor.S.ToString();

            HlsHBar.Value = (int)_colorHolder.HlsColor.H;
            HlsLBar.Value = (int)(_colorHolder.HlsColor.L* 100);
            HlsSBar.Value = (int)(_colorHolder.HlsColor.S * 100);
        }

        private void UpdateBox()
        {
            ColorDispayBox.BackColor = RgbToSystemColor();
        }

        private System.Drawing.Color RgbToSystemColor()
        {
            return System.Drawing.Color.FromArgb
                ((byte)_colorHolder.RgbColor.R,
                 (byte)_colorHolder.RgbColor.G,
                 (byte)_colorHolder.RgbColor.B);
        }



        // TrackBar events
        private void RgbRBar_Scroll(object sender, EventArgs e)
        {
            RgbRBox.Text = RgbRBar.Value.ToString();
        }

        private void RgbGBar_Scroll(object sender, EventArgs e)
        {
            RgbGBox.Text = RgbGBar.Value.ToString();
        }

        private void RgbBBar_Scroll(object sender, EventArgs e)
        {
            RgbBBox.Text = RgbBBar.Value.ToString();
        }

        private void HlsHBar_Scroll(object sender, EventArgs e)
        {
            HlsHBox.Text = HlsHBar.Value.ToString();
        }

        private void HlsLBar_Scroll(object sender, EventArgs e)
        {
            HlsLBox.Text = (HlsLBar.Value / 100.0).ToString();
        }

        private void HlsSBar_Scroll(object sender, EventArgs e)
        {
            HlsSBox.Text = (HlsSBar.Value / 100.0).ToString();
        }

        private void CmykCBar_Scroll(object sender, EventArgs e)
        {
            CmykCBox.Text = (CmykCBar.Value / 100.0).ToString();
        }

        private void CmykMBar_Scroll(object sender, EventArgs e)
        {
            CmykMBox.Text = (CmykMBar.Value / 100.0).ToString();
        }

        private void CmykYBar_Scroll(object sender, EventArgs e)
        {
            CmykYBox.Text = (CmykYBar.Value / 100.0).ToString();
        }

        private void CmykKBar_Scroll(object sender, EventArgs e)
        {
            CmykKBox.Text = (CmykKBar.Value / 100.0).ToString();
        }



        // TextChanged events
        private void TextBoxChanged(ColorSpaceEnum space, ValidatorType validatorType, TextBox textBox)
        {
            // Supress declining partial typing
            if (textBox.Text.Length > 0 && ( textBox.Text[0] == ',' || (textBox.Text[textBox.Text.Length - 1] == ',')))
            {
                return;
            }

            if (_validators[validatorType].Validate(textBox.Text))
            {
                if (!_changeInProgress)
                {
                    ChangeColor(space);
                    textBox.ClearUndo();
                }
            }
            else
            {
                RestoreValues(space);
                InfoLabel.Text = _validationErrors[space];
            }
        }

        private void RestoreValues(ColorSpaceEnum space)
        {
            switch (space)
            {
                case ColorSpaceEnum.RGB:
                    UpdateRgb();
                    break;
                case ColorSpaceEnum.HLS:
                    
                    break;
                case ColorSpaceEnum.CMYK:
                    UpdateCmyk();
                    break;
                default:
                    break;
            }
        }

        private void RgbRBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.RGB, ValidatorType.RGB, RgbRBox);
        }

        private void RgbGBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.RGB, ValidatorType.RGB, RgbGBox);
        }

        private void RgbBBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.RGB, ValidatorType.RGB, RgbBBox);
        }

        private void HlsHBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.HLS, ValidatorType.Degree, HlsHBox);
        }

        private void HlsLBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.HLS, ValidatorType.Fraction, HlsLBox);
        }

        private void HlsSBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.HLS, ValidatorType.Fraction, HlsSBox);
        }

        private void CmykCBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.CMYK, ValidatorType.Fraction, CmykCBox);
        }

        private void CmykMBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.CMYK, ValidatorType.Fraction, CmykMBox);
        }

        private void CmykYBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.CMYK, ValidatorType.Fraction, CmykYBox);
        }

        private void CmykKBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxChanged(ColorSpaceEnum.CMYK, ValidatorType.Fraction, CmykKBox);
        }
    }
}