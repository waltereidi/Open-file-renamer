using ApplicationService;
using ApplicationService.Contracts;
using ApplicationService.Interfaces;
using Presentation.UI;


namespace Presentation.Wrappers
{
    public class TabNumberedSequenceWrapper : TabController
    {
        
        private readonly Label _label;
        private readonly TextBox _text;
        private readonly RadioButton _radioButton_sequenceBefore;
        private readonly RadioButton _radioButton_sequenceAfter;
        private readonly MainApplicationService _service = new();
        private string GetSeparator() => _text.Text.ToString();
        public TabNumberedSequenceWrapper(Label directory ,
            Label label ,
            TextBox text ,
            RadioButton sequenceBefore,
            RadioButton sequenceAfter,
            DataGridView_Files previewGrid ,
            DataGridView_Files selectionGrid , 
            TabPage tab 
            ) : base (previewGrid , selectionGrid , tab , directory)
        {
            _label = label;
            _text = text;
            _radioButton_sequenceBefore = sequenceBefore;
            _radioButton_sequenceAfter = sequenceAfter;

            text.KeyUp += this.GetPreview;
            _radioButton_sequenceBefore.CheckedChanged += this.GetPreview;
            _radioButton_sequenceAfter.CheckedChanged += this.GetPreview;
        }

        public override IOperationContract GetTabContent()
        {
            if (_radioButton_sequenceAfter.Checked) 
                return new NumberedSequenceAfter
                    (
                        GetSeparator(),
                        _previewGrid.GetAllFiles(new(_directory.Text)) , 
                        _directory.Text
                    );
            else if (_radioButton_sequenceBefore.Checked) 
                return new NumberedSequenceBefore
                    (
                        GetSeparator(), 
                        _previewGrid.GetAllFiles(new(_directory.Text)), 
                        _directory.Text
                    );
            else throw new InvalidOperationException();
        }


        
    }
}
