
using Presentation.Interfaces;

namespace Presentation.Wrappers
{
    public class ComboBox_Versioning : IComboBoxVersioning
    {
        private readonly ComboBox _comboBox;
        private readonly TabControl _tabControl;
        public ComboBox_Versioning(ComboBox combo, TabControl tabControl)
        {
            _comboBox = combo;
            _tabControl = tabControl;
            _comboBox.Items.Insert(0 , "Current");
            _comboBox.SelectedIndex = 0;
        }
        public void Click();
        



    }
}
