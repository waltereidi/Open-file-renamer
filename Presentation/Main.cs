using ApplicationService;
using ApplicationService.Enum;
using Presentation.Interfaces;
using Presentation.Wrappers;
using System.Net.Http.Headers;

namespace Presentation
{
    public partial class Main : Form
    {
        private MainApplicationService _service { get; set; }
        public Main()
        {
            InitializeComponent();
            InitializeTabPatternMatchingWrapper();
            InitializaTabNumberedSequenceWrapper();
            InitializeTabAppend();
            InitializeTabControl();
        }

        private void InitializeTabAppend()
            => TabAppendWrapper = new TabAppendWrapper
                (
                    label_currentDirectory,
                    textBox_append,
                    dataGridView_preview,
                    dataGridView_selection,
                    tabPage_append,
                    radioButton_append_appendAt,
                    radioButton_append_appendToEnd,
                    radioButton_append_appendToStart,
                    textBox_append_position
                );

        private void InitializaTabNumberedSequenceWrapper()
            => TabNumberedSequenceWrapper = new TabNumberedSequenceWrapper
                (
                    label_currentDirectory,
                    numberedSequence_label,
                    NumberedSequence_text,
                    numbered_Sequence_before,
                    numbered_sequence_after,
                    dataGridView_preview,
                    dataGridView_selection,
                    tabPage_numberedSequence
                );


        private void InitializeTabControl()
            => TabPatternMatchingWrapper = new TabPatternMatching
            (
                label_currentDirectory,
                label_patternMatching_to,
                textBox_Pattern_to,
                textBox_pattern_from,
                comboBox_patternMatching_operation,
                dataGridView_preview,
                dataGridView_selection,
                tabPage_patternMatching
            );
        private void InitializeTabPatternMatchingWrapper()
            => TabControlWrapper = new TabControlWrapper(tabControl,
                new List<ITabControl> {
                    TabNumberedSequenceWrapper,
                    TabPatternMatchingWrapper,
                    TabAppendWrapper
                });
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

        private void button_start_click(object sender, EventArgs e)
        {
            _service = new MainApplicationService();
            _service.RenameFiles(TabControlWrapper.GetSelectedTabData());
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
                        textBox_searchFilter.GetNumber(),
                        label_currentDirectory.Text,
                        Main_SearchFilter.BiggerThan
                        )); break;
                case "radioButton_smallerThan":
                    textBox_searchFilter.ChangeToNumber();
                    files.AddRange(_service.SearchFilesFromSize(
                        textBox_searchFilter.GetNumber(),
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
