using ApplicationService.Contracts;
using Presentation.Interfaces;
using Presentation.UI;

namespace Presentation.Wrappers
{
    public class TabPatternMatching : TabController, ITabPatternMatching
    {
        private Label label_currentDirectory;
        private Label label_patternMatching_to;
        private AlsoNumberTextBox textBox_Pattern_to;
        private AlsoNumberTextBox textBox_pattern_from;
        private ComboBox comboBox_patternMatching_operation;
        private List<Tuple<int, string>> _options = new() { 
            new(0 , "Replace"),
            new(1 , "ToLower"),
            new(2 , "ToUpper"),
            new(3 , "Words"),
            new(4 , "Digits"),
            new(5 , "Regex"),
        }; 

        public TabPatternMatching(
            Label label_currentDirectory, 
            Label label_patternMatching_to,
            AlsoNumberTextBox textBox_Pattern_to,
            AlsoNumberTextBox textBox_pattern_from, 
            ComboBox comboBox_patternMatching_operation, 
            DataGridView_Files dataGridView_preview, 
            DataGridView_Files dataGridView_selection, 
            TabPage tabPage_patternMatching)
            :base
            (
                dataGridView_preview,
                dataGridView_selection,
                tabPage_patternMatching, 
                label_currentDirectory
            )
        {
            this.label_currentDirectory = label_currentDirectory;
            this.label_patternMatching_to = label_patternMatching_to;
            this.textBox_Pattern_to = textBox_Pattern_to;
            this.textBox_pattern_from = textBox_pattern_from;
            this.comboBox_patternMatching_operation = comboBox_patternMatching_operation;
            AddComboOptions();

        }
        private void AddComboOptions()
            => comboBox_patternMatching_operation.Items.AddRange(
                    _options.OrderBy(o=> o.Item1)
                    .Select(s => s.Item2).ToArray()
                );

        public void ApplyComboSelectEvent(object sender, EventArgs e)
        {
            switch (comboBox_patternMatching_operation.SelectedIndex)
            {
                case 0: ApplyReplace();break;
                case 1: ApplyToLower();break;
                case 2: ApplyToUpper();break;
                case 3: ApplyWords();break;
                case 4: ApplyDigits();break;
                case 5: ApplyRegex(); break;
                default: throw new InvalidOperationException();
            }
        }
        private void ApplyRegex()
        {
            textBox_pattern_from.Enabled = true;
            textBox_Pattern_to.Enabled = true;
        }

        private void ApplyReplace()
        {
            textBox_pattern_from.Enabled = true;
            textBox_Pattern_to.Enabled = true;
        }
        private void ApplyToLower()
        {
            textBox_Pattern_to.Enabled = false;
            textBox_pattern_from.Enabled = false;
        }
        private void ApplyToUpper()
        {
            textBox_Pattern_to.Enabled = false;
            textBox_pattern_from.Enabled = false;
        }
        private void ApplyWords()
        {
            textBox_pattern_from.Enabled = true;
            textBox_Pattern_to.Enabled = false;
        }
        private void ApplyDigits()
        {
            textBox_pattern_from.Enabled = true;
            textBox_Pattern_to.Enabled = false;
        }
        public override IOperationContract GetTabContent()
            => comboBox_patternMatching_operation.SelectedIndex switch
            {
                0 => new ReplacePattern( 
                    textBox_Pattern_to.Text , 
                    textBox_pattern_from.Text  , 
                    base._previewGrid.GetAllFiles(new(_directory.Text)), 
                    _directory.Text
                    ),
                1 => new ToLowerPattern(
                    base._previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    ),
                2 => new ToUpperPattern(
                    base._previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    ),
                3 => new WordsPattern(
                    textBox_pattern_from.Text,
                    base._previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    ),
                4 => new DigitsPattern(
                    textBox_pattern_from.Text,
                    base._previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    ),
                5 => new RegexPattern(
                    textBox_Pattern_to.Text,
                    textBox_pattern_from.Text,
                    base._previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    ),
                _ => throw new InvalidOperationException(),
            };
    }
}
