using ApplicationService.Contracts;
using Presentation.Interfaces;
using Presentation.UI;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Presentation.Wrappers
{
    public class TabAppendWrapper : TabController, ITabAppend
    {
        
        private AlsoNumberTextBox _textBox_append;
        private AlsoNumberTextBox _textBox_append_position;
        private TabPage _tabPage_append;
        private RadioButton _radioButton_append_appendAt;
        private RadioButton _radioButton_append_appendToEnd;
        private RadioButton _radioButton_append_appendToStart;
        private long GetPosition() => _textBox_append_position.GetNumber() ?? 0;
        private string GetText() => _textBox_append.Text.ToString();
        public TabAppendWrapper(
            Label label_currentDirectory, 
            AlsoNumberTextBox textBox_append, 
            DataGridView_Files dataGridView_preview, 
            DataGridView_Files dataGridView_selection, 
            TabPage tabPage_append, 
            RadioButton radioButton_append_appendAt, 
            RadioButton radioButton_append_appendToEnd, 
            RadioButton radioButton_append_appendToStart,
            AlsoNumberTextBox textBox_append_position
            ) : base(dataGridView_preview , 
                dataGridView_selection , 
                tabPage_append,
                label_currentDirectory
        )
        {
            this._textBox_append = textBox_append;
            this._tabPage_append = tabPage_append;
            this._radioButton_append_appendAt = radioButton_append_appendAt;
            this._radioButton_append_appendToEnd = radioButton_append_appendToEnd;
            this._radioButton_append_appendToStart = radioButton_append_appendToStart;
            this._textBox_append_position = textBox_append_position;

            radioButton_append_appendAt.CheckedChanged += this.ApplyClickEvent;
            radioButton_append_appendAt.CheckedChanged += this.GetPreview;

            radioButton_append_appendToEnd.CheckedChanged += this.ApplyClickEvent;
            radioButton_append_appendToEnd.CheckedChanged += this.GetPreview;

            radioButton_append_appendToStart.CheckedChanged += this.ApplyClickEvent;
            radioButton_append_appendToStart.CheckedChanged += this.GetPreview;
        }
        public void ApplyClickEvent(object sender, EventArgs e)
        {
            if (_radioButton_append_appendAt.Checked)
                _textBox_append_position.Enabled = true; 
            else if (_radioButton_append_appendToEnd.Checked)
                _textBox_append_position.Enabled = false;
            else if (_radioButton_append_appendToStart.Checked)
                _textBox_append_position.Enabled = false;
        }

        public override IOperationContract GetTabContent()
        {
            if (_radioButton_append_appendAt.Checked)
                return new AppendAt(
                    GetPosition(),
                    GetText(), 
                    _previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    );
            else if (_radioButton_append_appendToEnd.Checked)
                return new AppendToEnd(
                    GetText(),
                    _previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    );
            else if (_radioButton_append_appendToStart.Checked) 
                return new AppendToStart(
                    GetText(),
                    _previewGrid.GetAllFiles(new(_directory.Text)),
                    _directory.Text
                    );
            else
                throw new InvalidOperationException();
        }
    }
}
