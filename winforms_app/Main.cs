using ApplicationService;
using ApplicationService.Enum;
using Presentation.UI;
using System.ComponentModel;

namespace winforms_app
{
    public partial class Main : Form
    {
        private readonly MainApplicationService _service;
        public Main()
        {
            InitializeComponent();
            _service = new MainApplicationService();
        }

        private void menuOpt_file_open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
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

            Main_SearchFilter filter ;
            switch (radioChecked.Name)
            {
                case "radioButton_contains":
                    filter = Main_SearchFilter.Contains;
                    await _service.ChangeSearchFilter(textBox_searchFilter.Text, label_currentDirectory.Text, filter);
                    break;
                case "radioButton_select":
                    {
                        filter = Main_SearchFilter.Select;
                        NumberTextBox ntb = new NumberTextBox(textBox_searchFilter);
                        await _service.ChangeSearchFilter(textBox_searchFilter.Text, label_currentDirectory.Text, filter);
                    }break;
                case "radioButton_greaterThan":
                    {
                        filter = Main_SearchFilter.GreaterThan;
                        NumberTextBox ntb = new NumberTextBox(textBox_searchFilter);
                        await _service.ChangeSearchFilter(textBox_searchFilter.Text, label_currentDirectory.Text, filter);
                    }break;
                case "radioButton_smallerThan":
                    filter = Main_SearchFilter.SmallerThan;
                    await _service.ChangeSearchFilter(textBox_searchFilter.Text, label_currentDirectory.Text, filter);
                    break;
            }

            
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
    }
}
