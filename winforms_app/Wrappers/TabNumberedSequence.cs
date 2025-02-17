using ApplicationService;
using FileManager.Enum;
using FileManager.Interfaces;
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
        private string GetSeparator() => _text.Text.ToString();
        public TabNumberedSequence(Label directory ,
            Label label ,
            TextBox text ,
            RadioButton sequenceBefore,
            RadioButton sequenceAfter,
            DataGridView_Files previewGrid 
            ) 
        {
            _label = label;
            _text = text;
            _radioButton_sequenceBefore = sequenceBefore;
            _radioButton_sequenceAfter = sequenceAfter; 
            _directory = directory;
        }
        public void GetPreview(object sender, EventArgs e)
        {
            //if (_radioButton_sequenceAfter.Checked) 
            //    return _service.GetNumberedSequenceAfterPreview(_directory.Text.ToString(), GetSeparator());

            //else if (_radioButton_sequenceBefore.Checked) 
            //    return _service.GetNumberedSequenceBeforePreview(_directory.Text.ToString(),GetSeparator());

            //throw new ArgumentNullException("Option is not selected");
        }


    }
}
