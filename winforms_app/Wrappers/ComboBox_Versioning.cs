
using ApplicationService;
using FileManager;
using Presentation.Interfaces;
using Presentation.UI;

namespace Presentation.Wrappers
{
    public class ComboBox_Versioning : IComboBoxVersioning
    {
        private readonly ComboBox _comboBox;
        private readonly TabControl _tabControl;
        private readonly DataGridView_Files _dataGrid;
        private readonly Label _directory;
        private readonly MainApplicationService _service = new MainApplicationService();
        private List<Tuple<Guid, int>> Versions 
        {
            get =>_service.GetVersions(_directory.Text); 
        }
        public ComboBox_Versioning
        (
            ComboBox c, 
            TabControl t, 
            DataGridView_Files d, 
            Label directory 
        )
        {
            _comboBox = c;
            _tabControl = t;
            _dataGrid = d;
            _directory = directory;

            _comboBox.Items.Insert(0 , "Current");
            _comboBox.SelectedIndex = 0;
            _comboBox.SelectedIndexChanged += Combobox_changed;
            _comboBox.Click+= LoadVersions;

        }

        private void LoadVersions(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Combobox_changed(object? sender, EventArgs e)
        {
            if (_comboBox.SelectedIndex != 0)
                _tabControl.Enabled = false;
            else 
                _tabControl.Enabled = true;
        }

        private void AddNewOptionList(List<Tuple<Guid , int>> list)
        {
            _comboBox.Items.Clear();
            _comboBox.Items.Insert(0, "Current");
            Versions.ForEach(f => _comboBox.Items.Insert(f.Item2 , f.Item2));

        }
        



    }
}
