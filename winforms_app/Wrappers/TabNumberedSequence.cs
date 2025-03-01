using ApplicationService;
using ApplicationService.Contracts;
using ApplicationService.Enum;
using FileManager.Interfaces;
using Presentation.Interfaces;
using Presentation.UI;


namespace Presentation.Wrappers
{
    public class TabNumberedSequence : ITabNumberedSequence
    {
        
        private readonly Label _label;
        private readonly TextBox _text;
        private readonly RadioButton _radioButton_sequenceBefore;
        private readonly RadioButton _radioButton_sequenceAfter;
        private readonly Label _directory;
        private readonly MainApplicationService _service = new();
        private readonly DataGridView_Files _previewGrid;
        private readonly DataGridView_Files _selectionGrid;
        public readonly TabPage _tab;
        private string GetSeparator() => _text.Text.ToString();
        public TabNumberedSequence(Label directory ,
            Label label ,
            TextBox text ,
            RadioButton sequenceBefore,
            RadioButton sequenceAfter,
            DataGridView_Files previewGrid ,
            DataGridView_Files selectionGrid , 
            TabPage tab 
            ) 
        {
            _label = label;
            _text = text;
            _radioButton_sequenceBefore = sequenceBefore;
            _radioButton_sequenceAfter = sequenceAfter; 
            _directory = directory;
            _previewGrid = previewGrid;
            _selectionGrid = selectionGrid;
            _tab = tab;
            
        }

        public void GetPreview(object sender, EventArgs e)
        {
            var files = _service.GetPreview( GetTabContent());
            _previewGrid.AddNewRowList(files , _selectionGrid);
        }
        public IOperationContract GetTabContent()
        {
            if (_radioButton_sequenceAfter.Checked) 
                return new NumberedSequenceAfter(GetSeparator(), _previewGrid.GetAllFiles(new(_directory.Text)) , _directory.Text);
            else if (_radioButton_sequenceBefore.Checked) 
                return new NumberedSequenceBefore(GetSeparator(), _previewGrid.GetAllFiles(new(_directory.Text)), _directory.Text);
            else throw new InvalidOperationException();
        }

        public TabPage TabGetInstance() => this._tab;
        
    }
}
