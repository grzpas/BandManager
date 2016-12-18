using System.Windows.Forms;

namespace WindowsForms.Band.Controls
{
    public partial class NumericTextBox : TextBox
    {
        private bool _numberEntered = false;
        public NumericTextBox()
        {
            InitializeComponent();
            KeyPress += TextBoxKeyPress;
            KeyDown += TextBoxKeyDown;
            Text = "0";
        }


        private static bool CheckIfNumericKey(Keys K, bool isDecimalPoint)
        {
            if (K == Keys.Back) //backspace?
                return true;
            if (K == Keys.OemPeriod || K == Keys.Decimal)
                return !isDecimalPoint;
            if ((K >= Keys.D0) && (K <= Keys.D9))
                return true;
            if ((K >= Keys.NumPad0) && (K <= Keys.NumPad9))
                return true;
            
            return false;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {            
            if (_numberEntered == false)
            {         
                e.Handled = true;
            }
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {           
            var txtBox = (TextBox)sender;         
            _numberEntered = CheckIfNumericKey(e.KeyCode, txtBox.Text.Contains("."));
        }
    }
}
