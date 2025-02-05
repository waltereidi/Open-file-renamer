using ApplicationService;
using ApplicationService.Enum;

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
                MessageBox.Show(fbd.SelectedPath);

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

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        private async void textBox_searchFilter_Changed(object sender, EventArgs e)
        {
            var selectedButton = radioButtonFilters.First(x => x.Enabled);

            Main_SearchFilter selectedOption;

            if (!Enum.TryParse(selectedButton.Name, out selectedOption))
                throw new ArgumentNullException(selectedButton.Name);

            await _service.ChangeSearchFilter(selectedOption, textBox_searchFilter.Text);
        }

        private void panel_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
