using ApplicationService;
using ApplicationService.Enum;

namespace winforms_app
{
    public partial class Main : Form
    {
        private MainApplicationService _service { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void menuOpt_file_open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                _service = new MainApplicationService();

                label_currentDirectory.Text = fbd.SelectedPath;
                label_currentDirectory.ForeColor = Color.Green;
                flowLayoutPanel_preview.Enabled = true;
                flowLayoutPanel_Selection.Enabled = true;
                searchFilter_Changed(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchFilter_Changed(object sender, EventArgs e)
        {
            var radioChecked = groupBox_filter.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)
                ?? throw new ArgumentNullException(nameof(RadioButton));

            List<FileInfo> files = new();
            switch (radioChecked.Name)
            {
                case "radioButton_contains":
                    textBox_searchFilter.ChangeToText();
                    files.AddRange(_service.SearchFiles(textBox_searchFilter.Text, label_currentDirectory.Text, Main_SearchFilter.Contains));
                    break;
                case "radioButton_greaterThan":
                    textBox_searchFilter.ChangeToNumber();
                    files.AddRange(_service.SearchFilesFromSize(
                        textBox_searchFilter.GetSize(),
                        label_currentDirectory.Text,
                        Main_SearchFilter.BiggerThan
                        )); break;
                case "radioButton_smallerThan":
                    textBox_searchFilter.ChangeToNumber();
                    files.AddRange(_service.SearchFilesFromSize(
                        textBox_searchFilter.GetSize(),
                        label_currentDirectory.Text,
                        Main_SearchFilter.SmallerThan
                        )); break;
            }
            dataGridView_selection.AddNewRowList(files, dataGridView_preview);
        }

        private void dataGridView_selection_cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<int> indexes = new();
            indexes.Add(e.RowIndex);

            DirectoryInfo di = new DirectoryInfo(label_currentDirectory.Text);

            dataGridView_selection.AddSelectRowsFromThisToThere(di, dataGridView_preview, indexes);
        }
        private void dataGridView_preview_cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<int> indexes = new();
            indexes.Add(e.RowIndex);

            DirectoryInfo di = new DirectoryInfo(label_currentDirectory.Text);

            dataGridView_preview.AddSelectRowsFromThisToThere(di, dataGridView_selection, indexes);
        }

        private void button_moveSelectedFiles_Click(object sender, EventArgs e)
        {
            if (dataGridView_selection.SelectedRows.Count > 0)
            {
                var indexes = dataGridView_selection.GetSelectedRowsIndexes();
                dataGridView_selection.AddSelectRowsFromThisToThere(new(label_currentDirectory.Text), dataGridView_preview, indexes);
            }
            else
            {
                var indexes = dataGridView_preview.GetSelectedRowsIndexes();
                dataGridView_preview.AddSelectRowsFromThisToThere(new(label_currentDirectory.Text), dataGridView_selection, indexes);
            }

        }
        private void dataGridView_selection_selectionChanged(object sender, EventArgs e)
            => dataGridView_selection.DeselectAnotherGrid(dataGridView_preview);
        private void dataGridView_preview_selectionChanged(object sender, EventArgs e)
            => dataGridView_preview.DeselectAnotherGrid(dataGridView_selection);

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
