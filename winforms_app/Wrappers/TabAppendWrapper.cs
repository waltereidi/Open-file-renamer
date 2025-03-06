using ApplicationService.Contracts;
using Presentation.Interfaces;
using Presentation.UI;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Presentation.Wrappers
{
    public class TabAppendWrapper : TabController
    {
        
        private AlsoNumberTextBox textBox_append;

        private TabPage tabPage_append;
        private RadioButton radioButton_append_appendAt;
        private RadioButton radioButton_append_appendToEnd;
        private RadioButton radioButton_append_appendToStart;
        private long GetPosition() => textBox_append.GetNumber() ?? 0;
        private string GetText() => textBox_append.Text.ToString();
        public TabAppendWrapper(
            Label label_currentDirectory, 
            AlsoNumberTextBox textBox_append, 
            DataGridView_Files dataGridView_preview, 
            DataGridView_Files dataGridView_selection, 
            TabPage tabPage_append, 
            RadioButton radioButton_append_appendAt, 
            RadioButton radioButton_append_appendToEnd, 
            RadioButton radioButton_append_appendToStart
            ) : base(dataGridView_preview , 
                dataGridView_selection , 
                tabPage_append,
                label_currentDirectory
        )
        {
            this.textBox_append = textBox_append;
            this.tabPage_append = tabPage_append;
            this.radioButton_append_appendAt = radioButton_append_appendAt;
            this.radioButton_append_appendToEnd = radioButton_append_appendToEnd;
            this.radioButton_append_appendToStart = radioButton_append_appendToStart;
        }
        public void ApplyClickEvent()
        {
                    
        }

        public override IOperationContract GetTabContent()
        {
            if (radioButton_append_appendAt.Checked)
                return new AppendAt(
                     GetPosition(),
                    _previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    );
            //else if (radioButton_append_appendToEnd.Checked)

            //else if (radioButton_append_appendToStart.Checked)
            else
                throw new InvalidOperationException();
        }
    }
}
