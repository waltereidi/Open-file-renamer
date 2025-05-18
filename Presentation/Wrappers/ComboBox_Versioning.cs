
using ApplicationService;
using FileManager;
using FileManager.DAO;
using Presentation.Interfaces;
using Presentation.UI;

namespace Presentation.Wrappers
{
    public class ComboBox_Versioning : IComboBoxVersioning
    {
        //private readonly ComboBox _comboBox;
        //private readonly TabControl _tabControl;
        //private readonly DataGridView_Files _previewDataGrid;
        //private readonly DataGridView_Files _selectionDataGrid;
        //private readonly Label _directory;
        //private readonly MainApplicationService _service = new MainApplicationService();
        //private List<Tuple<Guid, int>> Versions
        //{
        //    get => _service.GetVersions(_directory.Text);
        //}
        //public ComboBox_Versioning
        //(
        //    ComboBox c,
        //    TabControl t,
        //    DataGridView_Files preview_grid,
        //    DataGridView_Files selection_grid,
        //    Label directory
        //)
        //{
        //    _comboBox = c;
        //    _tabControl = t;
        //    _previewDataGrid = preview_grid;
        //    _selectionDataGrid = selection_grid;
        //    _directory = directory;

        //    _comboBox.Items.Insert(0, "Current");
        //    _comboBox.SelectedIndex = 0;
        //    _comboBox.SelectedIndexChanged += Combobox_changed;
        //    _comboBox.Click += AddNewOptionList;

        //}

        //private void Combobox_changed(object? sender, EventArgs e)
        //{
        //    if (_comboBox.SelectedIndex != 0)
        //    {
        //        _tabControl.Enabled = false;
        //        _previewDataGrid.SaveCurrentGrid();
        //    }
        //    else
        //    {
        //        _tabControl.Enabled = true;
        //        _previewDataGrid.RestoreStoredRows();
        //        _previewDataGrid.AddNewRowList(GetSelectedVersion().files, _selectionDataGrid);
        //    }

        //}
        ////private VersionedModifications.Version GetSelectedVersion()
        ////    => _service.GetVersionById(_directory.Text, Versions
        ////        .First(f => f.Item2 == _comboBox.SelectedIndex).Item1);

        //private void AddNewOptionList(object? sender, EventArgs e)
        //{
        //    _comboBox.Items.Clear();
        //    _comboBox.Items.Insert(0, "Current");
        //    Versions.ForEach(f => _comboBox.Items.Insert(f.Item2, f.Item2));

        //}




    }
}