using ApplicationService.Enum;
using Presentation.UI;

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
            button1 = new Button();
            tabControl_numberedSequence = new TabControl();
            tabPage_numberedSequence = new TabPage();
            tabPage2 = new TabPage();
            label_currentDirectory = new Label();
            flowLayoutPanel_Selection = new FlowLayoutPanel();
            dataGridView_selection = new DataGridView();
            Column_Selection_FileName = new DataGridViewTextBoxColumn();
            Column_Selection_FileExtension = new DataGridViewTextBoxColumn();
            Column_Selection_FileSize = new DataGridViewTextBoxColumn();
            Column_Selection_Hidden_FullName = new DataGridViewTextBoxColumn();
            Column_Preview_FileName = new DataGridViewTextBoxColumn();
            Column_Preview_FileExtension = new DataGridViewTextBoxColumn();
            Column_Preview_FileSize = new DataGridViewTextBoxColumn();
            Column_Preview_Hidden_FullName = new DataGridViewTextBoxColumn();
            flowLayoutPanel_preview = new FlowLayoutPanel();
            dataGridView_preview = new DataGridView();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox_filter.SuspendLayout();
            tabControl_numberedSequence.SuspendLayout();
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
            toolStrip2.Location = new Point(0, 424);
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
            start.Location = new Point(368, 186);
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
            // button1
            // 
            button1.Location = new Point(368, 248);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(66, 53);
            button1.TabIndex = 14;
            button1.Text = "rollback";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // tabControl_numberedSequence
            // 
            tabControl_numberedSequence.Controls.Add(tabPage_numberedSequence);
            tabControl_numberedSequence.Controls.Add(tabPage2);
            tabControl_numberedSequence.Location = new Point(4, 3);
            tabControl_numberedSequence.Margin = new Padding(4, 3, 4, 3);
            tabControl_numberedSequence.Name = "tabControl_numberedSequence";
            tabControl_numberedSequence.SelectedIndex = 0;
            tabControl_numberedSequence.Size = new Size(334, 89);
            tabControl_numberedSequence.TabIndex = 15;
            // 
            // tabPage_numberedSequence
            // 
            tabPage_numberedSequence.Location = new Point(4, 24);
            tabPage_numberedSequence.Margin = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Name = "tabPage_numberedSequence";
            tabPage_numberedSequence.Padding = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Size = new Size(326, 61);
            tabPage_numberedSequence.TabIndex = 0;
            tabPage_numberedSequence.Text = "Numbered Sequence";
            tabPage_numberedSequence.UseVisualStyleBackColor = true;
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
            label_currentDirectory.Click += label1_Click;
            // 
            // flowLayoutPanel_Selection
            // 
            flowLayoutPanel_Selection.Controls.Add(label_currentDirectory);
            flowLayoutPanel_Selection.Controls.Add(groupBox_filter);
            flowLayoutPanel_Selection.Controls.Add(dataGridView_selection);
            flowLayoutPanel_Selection.Enabled = false;
            flowLayoutPanel_Selection.Location = new Point(12, 35);
            flowLayoutPanel_Selection.Name = "flowLayoutPanel_Selection";
            flowLayoutPanel_Selection.Size = new Size(349, 386);
            flowLayoutPanel_Selection.TabIndex = 0;
            flowLayoutPanel_Selection.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridView_selection
            // 
            dataGridView_selection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_selection.Columns.AddRange(new DataGridViewColumn[] { Column_Selection_FileName, Column_Selection_FileExtension, Column_Selection_FileSize, Column_Selection_Hidden_FullName });
            dataGridView_selection.Location = new Point(3, 100);
            dataGridView_selection.Name = "dataGridView_selection";
            dataGridView_selection.Size = new Size(341, 275);
            dataGridView_selection.TabIndex = 0;
            dataGridView_selection.CellContentClick += dataGridView_selection_CellContentClick;
            // 
            // Column_Selection_FileName
            // 
            Column_Selection_FileName.HeaderText = "Name";
            Column_Selection_FileName.Name = "Column_Selection_FileName";
            // 
            // Column_Selection_FileExtension
            // 
            Column_Selection_FileExtension.HeaderText = "Extension";
            Column_Selection_FileExtension.Name = "Column_Selection_FileExtension";
            // 
            // Column_Selection_FileSize
            // 
            Column_Selection_FileSize.HeaderText = "Size";
            Column_Selection_FileSize.Name = "Column_Selection_FileSize";
            // 
            // Column_Selection_Hidden_FullName
            // 
            Column_Selection_Hidden_FullName.HeaderText = "hidden fullName";
            Column_Selection_Hidden_FullName.Name = "Column_Selection_Hidden_FullName";
            Column_Selection_Hidden_FullName.Visible = false;
            // 
            // Column_Preview_FileName
            // 
            Column_Preview_FileName.HeaderText = "Name";
            Column_Preview_FileName.Name = "Column_Preview_FileName";
            // 
            // Column_Preview_FileExtension
            // 
            Column_Preview_FileExtension.HeaderText = "Extension";
            Column_Preview_FileExtension.Name = "Column_Preview_FileExtension";
            // 
            // Column_Preview_FileSize
            // 
            Column_Preview_FileSize.HeaderText = "Size";
            Column_Preview_FileSize.Name = "Column_Preview_FileSize";
            // 
            // Column_Preview_Hidden_FullName
            // 
            Column_Preview_Hidden_FullName.HeaderText = "hidden fullName";
            Column_Preview_Hidden_FullName.Name = "Column_Preview_Hidden_FullName";
            Column_Preview_Hidden_FullName.Visible = false;
            // 
            // flowLayoutPanel_preview
            // 
            flowLayoutPanel_preview.Controls.Add(tabControl_numberedSequence);
            flowLayoutPanel_preview.Controls.Add(dataGridView_preview);
            flowLayoutPanel_preview.Enabled = false;
            flowLayoutPanel_preview.Location = new Point(441, 35);
            flowLayoutPanel_preview.Name = "flowLayoutPanel_preview";
            flowLayoutPanel_preview.Size = new Size(344, 386);
            flowLayoutPanel_preview.TabIndex = 0;
            // 
            // dataGridView_preview
            // 
            dataGridView_preview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_preview.Columns.AddRange(new DataGridViewColumn[] { Column_Preview_FileName, Column_Preview_FileExtension, Column_Preview_FileSize, Column_Preview_Hidden_FullName });
            dataGridView_preview.Location = new Point(3, 98);
            dataGridView_preview.Name = "dataGridView_preview";
            dataGridView_preview.Size = new Size(335, 277);
            dataGridView_preview.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(797, 449);
            Controls.Add(flowLayoutPanel_preview);
            Controls.Add(flowLayoutPanel_Selection);
            Controls.Add(button1);
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
        private Button button1;
        private TabControl tabControl_numberedSequence;
        private TabPage tabPage_numberedSequence;
        private TabPage tabPage2;
        private RadioButton radioButton_smallerThan;
        private RadioButton radioButton_contains;
        private RadioButton radioButton_greaterThan;
        private Label label_currentDirectory;
        private FlowLayoutPanel flowLayoutPanel_Selection;
        private FlowLayoutPanel flowLayoutPanel_preview;
        private DataGridView dataGridView_selection;
        private DataGridView dataGridView_preview;
        private DataGridViewTextBoxColumn Column_Selection_FileName;
        private DataGridViewTextBoxColumn Column_Selection_FileExtension;
        private DataGridViewTextBoxColumn Column_Selection_FileSize;
        private DataGridViewTextBoxColumn Column_Selection_Hidden_FullName;

        private DataGridViewTextBoxColumn Column_Preview_FileName;
        private DataGridViewTextBoxColumn Column_Preview_FileExtension;
        private DataGridViewTextBoxColumn Column_Preview_FileSize;
        private DataGridViewTextBoxColumn Column_Preview_Hidden_FullName;

    }
}
