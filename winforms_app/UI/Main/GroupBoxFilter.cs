using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.UI.Main
{
    public class GroupBoxFilter : GroupBox
    {
        public GroupBoxFilter(TextBox txtBox , RadioButton[] radioBtn )
        {
            this.SuspendLayout();
            this.Controls.Add(txtBox);
            this.Controls.Add(radioBtn[0]);
            this.Controls.Add(radioBtn[1]);
            this.Controls.Add(radioBtn[2]);
            this.Controls.Add(radioBtn[3]);

            this.Location = new Point(22, 28);
            this.Name = "groupBox_filter";
            this.Size = new Size(339, 81);
            this.TabIndex = 13;
            this.TabStop = false;
            this.Text = "Filter";
  
        }
    }
}
