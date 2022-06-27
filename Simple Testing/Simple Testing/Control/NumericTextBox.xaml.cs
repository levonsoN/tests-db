using System;
using System.Windows.Controls;

namespace SimpleTesting.Control
{
    public partial class NumericTextBox : UserControl
    {
        private double minValue = 0;
        private double maxValue = 10;
        private double defaultValue = 0;
        private int decimalPlaces = 2;

        public int DecimalPlaces
        {
            get => decimalPlaces; set
            {
                decimalPlaces = value;
                MinValue = Math.Round(minValue, decimalPlaces);
                MaxValue = Math.Round(maxValue, decimalPlaces);
                DefaultValue = Math.Round(defaultValue, decimalPlaces);
                Value = Math.Round(Value, decimalPlaces);
            }
        }
        public double MinValue
        {
            get => minValue; set
            {
                minValue = Math.Round(value, decimalPlaces);
                if (maxValue < minValue)
                    maxValue = minValue;
                if (defaultValue < minValue)
                    defaultValue = minValue;
                if (Value < minValue)
                    Value = minValue;
            }
        }
        public double MaxValue
        {
            get => maxValue; set
            {
                maxValue = Math.Round(value, decimalPlaces);
                if (minValue > maxValue)
                    minValue = maxValue;
                if (defaultValue > maxValue)
                    defaultValue = maxValue;
                if (Value > maxValue)
                    Value = maxValue;
            }
        }
        public double DefaultValue
        {
            get => defaultValue; set
            {

                if (minValue < value)
                    defaultValue = minValue;
                else if (maxValue > value)
                    defaultValue = maxValue;
                else
                    defaultValue = Math.Round(value, decimalPlaces);
            }
        }
        public double Value
        {
            get
            {
                if (double.TryParse(textBox.Text, out double value))
                {
                    if (value < minValue)
                        return minValue;
                    else if (value > maxValue)
                        return maxValue;
                    else return Math.Round(value, decimalPlaces);
                }
                else return DefaultValue;
            }
            set
            {

                if (value < MinValue)
                    textBox.Text = MinValue.ToString("F" + decimalPlaces);
                else if (value > MaxValue)
                    textBox.Text = MaxValue.ToString("F" + decimalPlaces);
                else
                    textBox.Text = Math.Round(value, decimalPlaces).ToString("F" + decimalPlaces);
            }
        }
        public int InnerTabStop { get => textBox.TabIndex; set => textBox.TabIndex = value; }
        public NumericTextBox()
        {
            InitializeComponent();
            Value = defaultValue;
        }
        private void TextBoxLostFocus(object sender, System.Windows.RoutedEventArgs e) => Value = Value;
    }
}
