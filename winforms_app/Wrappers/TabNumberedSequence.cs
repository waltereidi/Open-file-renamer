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

        public void NumberedSequenceAfterChecked(object sender, EventArgs e)
        {
            
        }

        public void NumberedSequenceBeforeChecked(object sender, EventArgs e)
        {


        }
        public void TextAppendChanged(object sender, EventArgs e)
        {

        }
        private void GetPreview()
        {

        }


    }
}
