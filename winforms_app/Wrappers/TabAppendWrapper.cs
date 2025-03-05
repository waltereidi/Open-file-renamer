using Presentation.Interfaces;
using Presentation.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Wrappers
{
    public class TabAppendWrapper : TabController
    {
        private Label label_currentDirectory;
        private TextBox textBox_append;

        private TabPage tabPage_append;
        private RadioButton radioButton_append_appendAt;
        private RadioButton radioButton_append_appendToEnd;
        private RadioButton radioButton_append_appendToStart;

        public TabAppendWrapper(
            Label label_currentDirectory, 
            TextBox textBox_append, 
            DataGridView_Files dataGridView_preview, 
            DataGridView_Files dataGridView_selection, 
            TabPage tabPage_append, 
            RadioButton radioButton_append_appendAt, 
            RadioButton radioButton_append_appendToEnd, 
            RadioButton radioButton_append_appendToStart
            ) : base(dataGridView_preview , dataGridView_selection , tabPage_append)
        {
            this.label_currentDirectory = label_currentDirectory;
            this.textBox_append = textBox_append;
            this.tabPage_append = tabPage_append;
            this.radioButton_append_appendAt = radioButton_append_appendAt;
            this.radioButton_append_appendToEnd = radioButton_append_appendToEnd;
            this.radioButton_append_appendToStart = radioButton_append_appendToStart;
        }

        public override IOperationContract GetTabContent()
        {
            throw new NotImplementedException();
        }
    }
}
