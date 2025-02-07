using Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.UI
{
    public class AlsoNumberTextBox : TextBox
    {
        private bool IsNumber { get; set; } = false;
        public AlsoNumberTextBox() { }

        public void ChangeToText() => IsNumber = false;
        public void ChangeToNumber() => IsNumber = true;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsNumber)
                return;

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
        public long? GetSize()
        {
            long size = 0;
            long.TryParse(this.Text , out size);
            return size != 0 ? size : null; 
        }
    }
}
