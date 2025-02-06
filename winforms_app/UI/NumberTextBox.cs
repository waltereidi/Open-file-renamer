using Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.UI
{
    public class NumberTextBox : TextBox
    {
        public NumberTextBox() { }
        public NumberTextBox(TextBox old ) 
        {
            ObjectClone.CopyProperties(old, this);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
