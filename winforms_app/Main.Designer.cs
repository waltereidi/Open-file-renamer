using ApplicationService.Enum;
using FileManager.Interfaces;
using Presentation.UI;
using Presentation.Wrappers;

namespace winforms_app
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            menu_file = new ToolStripDropDownButton();
            menuOpt_file_open = new ToolStripMenuItem();
            toolStrip2 = new ToolStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripLabel_progress = new ToolStripLabel();
            start = new Button();
            groupBox_filter = new GroupBox();
            radioButton_greaterThan = new RadioButton();
            radioButton_smallerThan = new RadioButton();
            radioButton_contains = new RadioButton();
            textBox_searchFilter = new AlsoNumberTextBox();
            tabControl_numberedSequence = new TabControl();
            tabPage_numberedSequence = new TabPage();
            numberedSequence_label = new Label();
            NumberedSequence_text = new TextBox();
            numbered_Sequence_before = new RadioButton();
            numbered_sequence_after = new RadioButton();
            tabPage2 = new TabPage();
            label_currentDirectory = new Label();
            flowLayoutPanel_Selection = new FlowLayoutPanel();
            dataGridView_selection = new DataGridView_Files();
            flowLayoutPanel_preview = new FlowLayoutPanel();
            dataGridView_preview = new DataGridView_Files();
            tabControl1 = new TabControl();
            button_moveSelectedFiles = new Button();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox_filter.SuspendLayout();
            tabControl_numberedSequence.SuspendLayout();
            tabPage_numberedSequence.SuspendLayout();
            flowLayoutPanel_Selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_selection).BeginInit();
            flowLayoutPanel_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_preview).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menu_file });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(797, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { menuOpt_file_open });
            menu_file.Name = "menu_file";
            menu_file.Size = new Size(38, 22);
            menu_file.Text = "File";
            // 
            // menuOpt_file_open
            // 
            menuOpt_file_open.Name = "menuOpt_file_open";
            menuOpt_file_open.Size = new Size(103, 22);
            menuOpt_file_open.Text = "Open";
            menuOpt_file_open.Click += menuOpt_file_open_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripLabel_progress });
            toolStrip2.Location = new Point(0, 454);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(0, 0, 2, 0);
            toolStrip2.Size = new Size(797, 25);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Margin = new Padding(1, 2, 20, 1);
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(339, 22);
            // 
            // toolStripLabel_progress
            // 
            toolStripLabel_progress.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel_progress.Name = "toolStripLabel_progress";
            toolStripLabel_progress.Size = new Size(29, 22);
            toolStripLabel_progress.Text = "0 % ";
            // 
            // start
            // 
            start.Location = new Point(368, 247);
            start.Margin = new Padding(4, 3, 4, 3);
            start.Name = "start";
            start.Size = new Size(66, 56);
            start.TabIndex = 4;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += button1_Click;
            // 
            // groupBox_filter
            // 
            groupBox_filter.Controls.Add(radioButton_greaterThan);
            groupBox_filter.Controls.Add(radioButton_smallerThan);
            groupBox_filter.Controls.Add(radioButton_contains);
            groupBox_filter.Controls.Add(textBox_searchFilter);
            groupBox_filter.Location = new Point(4, 18);
            groupBox_filter.Margin = new Padding(4, 3, 4, 3);
            groupBox_filter.Name = "groupBox_filter";
            groupBox_filter.Padding = new Padding(4, 3, 4, 3);
            groupBox_filter.Size = new Size(340, 76);
            groupBox_filter.TabIndex = 13;
            groupBox_filter.TabStop = false;
            groupBox_filter.Text = "Filter";
            // 
            // radioButton_greaterThan
            // 
            radioButton_greaterThan.AutoSize = true;
            radioButton_greaterThan.Location = new Point(235, 21);
            radioButton_greaterThan.Margin = new Padding(4, 3, 4, 3);
            radioButton_greaterThan.Name = "radioButton_greaterThan";
            radioButton_greaterThan.Size = new Size(97, 19);
            radioButton_greaterThan.TabIndex = 8;
            radioButton_greaterThan.TabStop = true;
            radioButton_greaterThan.Text = "Greater Than";
            radioButton_greaterThan.UseVisualStyleBackColor = true;
            radioButton_greaterThan.CheckedChanged += searchFilter_Changed;
            // 
            // radioButton_smallerThan
            // 
            radioButton_smallerThan.AutoSize = true;
            radioButton_smallerThan.Location = new Point(110, 21);
            radioButton_smallerThan.Margin = new Padding(4, 3, 4, 3);
            radioButton_smallerThan.Name = "radioButton_smallerThan";
            radioButton_smallerThan.Size = new Size(99, 19);
            radioButton_smallerThan.TabIndex = 7;
            radioButton_smallerThan.TabStop = true;
            radioButton_smallerThan.Text = "Smaller Than";
            radioButton_smallerThan.UseVisualStyleBackColor = true;
            radioButton_smallerThan.CheckedChanged += searchFilter_Changed;
            // 
            // radioButton_contains
            // 
            radioButton_contains.AutoSize = true;
            radioButton_contains.Checked = true;
            radioButton_contains.Location = new Point(5, 21);
            radioButton_contains.Margin = new Padding(4, 3, 4, 3);
            radioButton_contains.Name = "radioButton_contains";
            radioButton_contains.Size = new Size(73, 19);
            radioButton_contains.TabIndex = 6;
            radioButton_contains.TabStop = true;
            radioButton_contains.Text = "Contains";
            radioButton_contains.UseVisualStyleBackColor = true;
            radioButton_contains.CheckedChanged += searchFilter_Changed;
            // 
            // textBox_searchFilter
            // 
            textBox_searchFilter.Location = new Point(5, 44);
            textBox_searchFilter.Margin = new Padding(4, 3, 4, 3);
            textBox_searchFilter.Name = "textBox_searchFilter";
            textBox_searchFilter.Size = new Size(328, 21);
            textBox_searchFilter.TabIndex = 5;
            textBox_searchFilter.TextChanged += searchFilter_Changed;
            // 
            // tabControl_numberedSequence
            // 
            tabControl_numberedSequence.Controls.Add(tabPage_numberedSequence);
            tabControl_numberedSequence.Controls.Add(tabPage2);
            tabControl_numberedSequence.Dock = DockStyle.Bottom;
            tabControl_numberedSequence.Location = new Point(4, 3);
            tabControl_numberedSequence.Margin = new Padding(4, 3, 4, 3);
            tabControl_numberedSequence.Name = "tabControl_numberedSequence";
            tabControl_numberedSequence.SelectedIndex = 0;
            tabControl_numberedSequence.Size = new Size(334, 89);
            tabControl_numberedSequence.TabIndex = 15;
            // 
            // tabPage_numberedSequence
            // 

            tabPage_numberedSequence.Controls.Add(numberedSequence_label);
            tabPage_numberedSequence.Controls.Add(NumberedSequence_text);
            tabPage_numberedSequence.Controls.Add(numbered_Sequence_before);
            tabPage_numberedSequence.Controls.Add(numbered_sequence_after);
            TabNumberedSequenceWrapper = new TabNumberedSequence(label_currentDirectory, 
                numberedSequence_label ,
                NumberedSequence_text , 
                numbered_Sequence_before , 
                numbered_sequence_after ,
                dataGridView_preview
                );
            tabPage_numberedSequence.Location = new Point(4, 24);
            tabPage_numberedSequence.Margin = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Name = "tabPage_numberedSequence";
            tabPage_numberedSequence.Padding = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Size = new Size(326, 61);
            tabPage_numberedSequence.TabIndex = 0;
            tabPage_numberedSequence.Text = "Numbered Sequence";
            tabPage_numberedSequence.UseVisualStyleBackColor = true;
            // 
            // numberedSequence_label
            // 
            numberedSequence_label.AutoSize = true;
            numberedSequence_label.Location = new Point(7, 12);
            numberedSequence_label.Name = "numberedSequence_label";
            numberedSequence_label.Size = new Size(75, 15);
            numberedSequence_label.TabIndex = 3;
            numberedSequence_label.Text = "Append Text";
            // 
            // NumberedSequence_text
            // 
            NumberedSequence_text.Location = new Point(7, 34);
            NumberedSequence_text.Name = "NumberedSequence_text";
            NumberedSequence_text.Size = new Size(211, 21);
            NumberedSequence_text.TabIndex = 2;
            NumberedSequence_text.KeyUp += TabNumberedSequenceWrapper.GetPreview;
            // 
            // numbered_Sequence_before
            // 
            numbered_Sequence_before.AutoSize = true;
            numbered_Sequence_before.Location = new Point(224, 6);
            numbered_Sequence_before.Name = "numbered_Sequence_before";
            numbered_Sequence_before.Size = new Size(61, 19);
            numbered_Sequence_before.TabIndex = 1;
            numbered_Sequence_before.TabStop = true;
            numbered_Sequence_before.Text = "Before";
            numbered_Sequence_before.UseVisualStyleBackColor = true;
            numbered_Sequence_before.Checked = true; 
            numbered_Sequence_before.CheckedChanged += TabNumberedSequenceWrapper.GetPreview;
            // 
            // numbered_sequence_after
            // 
            numbered_sequence_after.AutoSize = true;
            numbered_sequence_after.Location = new Point(224, 39);
            numbered_sequence_after.Name = "numbered_sequence_after";
            numbered_sequence_after.Size = new Size(49, 19);
            numbered_sequence_after.TabIndex = 0;
            numbered_sequence_after.TabStop = true;
            numbered_sequence_after.Text = "After";
            numbered_sequence_after.UseVisualStyleBackColor = true;
            numbered_sequence_after.CheckedChanged += TabNumberedSequenceWrapper.GetPreview;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(326, 61);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_currentDirectory
            // 
            label_currentDirectory.AutoSize = true;
            label_currentDirectory.FlatStyle = FlatStyle.Flat;
            label_currentDirectory.ForeColor = Color.Red;
            label_currentDirectory.Location = new Point(4, 0);
            label_currentDirectory.Margin = new Padding(4, 0, 4, 0);
            label_currentDirectory.Name = "label_currentDirectory";
            label_currentDirectory.Size = new Size(100, 15);
            label_currentDirectory.TabIndex = 16;
            label_currentDirectory.Text = "Select a directory";
            // 
            // flowLayoutPanel_Selection
            // 
            flowLayoutPanel_Selection.Controls.Add(label_currentDirectory);
            flowLayoutPanel_Selection.Controls.Add(groupBox_filter);
            flowLayoutPanel_Selection.Controls.Add(dataGridView_selection);
            flowLayoutPanel_Selection.Enabled = false;
            flowLayoutPanel_Selection.Location = new Point(12, 35);
            flowLayoutPanel_Selection.Name = "flowLayoutPanel_Selection";
            flowLayoutPanel_Selection.Size = new Size(349, 398);
            flowLayoutPanel_Selection.TabIndex = 0;
            // 
            // dataGridView_selection
            // 
            dataGridView_selection.AllowUserToAddRows = false;
            dataGridView_selection.AllowUserToResizeRows = false;
            dataGridView_selection.Location = new Point(3, 100);
            dataGridView_selection.Name = "dataGridView_selection";
            dataGridView_selection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_selection.Size = new Size(341, 291);
            dataGridView_selection.TabIndex = 0;
            dataGridView_selection.CellDoubleClick += dataGridView_selection_cellDoubleClick;
            dataGridView_selection.SelectionChanged += dataGridView_selection_selectionChanged;
            // 
            // flowLayoutPanel_preview
            // 
            flowLayoutPanel_preview.Controls.Add(tabControl_numberedSequence);
            flowLayoutPanel_preview.Controls.Add(dataGridView_preview);
            flowLayoutPanel_preview.Controls.Add(tabControl1);
            flowLayoutPanel_preview.Enabled = false;
            flowLayoutPanel_preview.Location = new Point(441, 35);
            flowLayoutPanel_preview.Name = "flowLayoutPanel_preview";
            flowLayoutPanel_preview.Size = new Size(344, 398);
            flowLayoutPanel_preview.TabIndex = 0;
            // 
            // dataGridView_preview
            // 
            dataGridView_preview.AllowUserToAddRows = false;
            dataGridView_preview.AllowUserToResizeRows = false;
            dataGridView_preview.Location = new Point(3, 98);
            dataGridView_preview.Name = "dataGridView_preview";
            dataGridView_preview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_preview.Size = new Size(335, 240);
            dataGridView_preview.TabIndex = 0;
            dataGridView_preview.CellDoubleClick += dataGridView_preview_cellDoubleClick;
            dataGridView_preview.SelectionChanged += dataGridView_preview_selectionChanged;
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(3, 344);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(341, 51);
            tabControl1.TabIndex = 16;
            // 
            // button_moveSelectedFiles
            // 
            button_moveSelectedFiles.Location = new Point(368, 185);
            button_moveSelectedFiles.Name = "button_moveSelectedFiles";
            button_moveSelectedFiles.Size = new Size(66, 56);
            button_moveSelectedFiles.TabIndex = 5;
            button_moveSelectedFiles.Text = "Move Selected Files";
            button_moveSelectedFiles.UseVisualStyleBackColor = true;
            button_moveSelectedFiles.Click += button_moveSelectedFiles_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(797, 479);
            Controls.Add(button_moveSelectedFiles);
            Controls.Add(flowLayoutPanel_preview);
            Controls.Add(flowLayoutPanel_Selection);
            Controls.Add(start);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "Free File Editor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox_filter.ResumeLayout(false);
            groupBox_filter.PerformLayout();
            tabControl_numberedSequence.ResumeLayout(false);
            tabPage_numberedSequence.ResumeLayout(false);
            tabPage_numberedSequence.PerformLayout();
            flowLayoutPanel_Selection.ResumeLayout(false);
            flowLayoutPanel_Selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_selection).EndInit();
            flowLayoutPanel_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_preview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton menu_file;
        private ToolStripMenuItem menuOpt_file_open;
        private ToolStrip toolStrip2;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button start;
        private AlsoNumberTextBox textBox_searchFilter;
        private ToolStripLabel toolStripLabel_progress;
        private GroupBox groupBox_filter;
        private TabControl tabControl_numberedSequence;
        private TabPage tabPage_numberedSequence;
        private TabPage tabPage2;
        private RadioButton radioButton_smallerThan;
        private RadioButton radioButton_contains;
        private RadioButton radioButton_greaterThan;
        private Label label_currentDirectory;
        private FlowLayoutPanel flowLayoutPanel_Selection;
        private FlowLayoutPanel flowLayoutPanel_preview;
        private DataGridView_Files dataGridView_preview;
        private TabControl tabControl1;
        private DataGridView_Files dataGridView_selection;
        private Button button_moveSelectedFiles;
        private RadioButton numbered_Sequence_before;
        private RadioButton numbered_sequence_after;
        private Label numberedSequence_label;
        private TextBox NumberedSequence_text;
        private ITabNumberedSequence TabNumberedSequenceWrapper; 
    }
}
