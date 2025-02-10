using ApplicationService;
using ApplicationService.Enum;
using Presentation.UI;
using System.ComponentModel;

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
                _service = new MainApplicationService(new(fbd.SelectedPath));
                
                label_currentDirectory.Text = fbd.SelectedPath;
                label_currentDirectory.ForeColor = Color.Green;

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
        private async void searchFilter_Changed(object sender, EventArgs e)
        {
            var radioChecked = groupBox_filter.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)
                ?? throw new ArgumentNullException(nameof(RadioButton));

            List<FileInfo> files = new();
            switch (radioChecked.Name)
            {
                case "radioButton_contains":
                     files.AddRange(_service.SearchFiles(textBox_searchFilter.Text, label_currentDirectory.Text, Main_SearchFilter.Contains));
                    break;
                case "radioButton_greaterThan":
                    files.AddRange(_service.SearchFilesFromSize(
                        textBox_searchFilter.GetSize(),
                        label_currentDirectory.Text,
                        Main_SearchFilter.BiggerThan
                        )); break;
                case "radioButton_smallerThan":
                    files.AddRange(_service.SearchFilesFromSize(
                        textBox_searchFilter.GetSize(),
                        label_currentDirectory.Text,
                        Main_SearchFilter.SmallerThan
                        )); break;
            }
            dataGridView_selection.AddNewRowList(files);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }


        private void panel_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_selection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
