﻿using ApplicationService.Enum;
using FileManager.Interfaces;
using Presentation.Interfaces;
using Presentation.UI;
using Presentation.Wrappers;

namespace Presentation
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
            button_start = new Button();
            groupBox_filter = new GroupBox();
            radioButton_greaterThan = new RadioButton();
            radioButton_smallerThan = new RadioButton();
            radioButton_contains = new RadioButton();
            textBox_searchFilter = new AlsoNumberTextBox();
            tabControl = new TabControl();
            tabPage_numberedSequence = new TabPage();
            numberedSequence_label = new Label();
            NumberedSequence_text = new TextBox();
            numbered_Sequence_before = new RadioButton();
            numbered_sequence_after = new RadioButton();
            tabPage_patternMatching = new TabPage();
            label_patternMatching_to = new Label();
            textBox_Pattern_to = new AlsoNumberTextBox();
            textBox_pattern_from = new AlsoNumberTextBox();
            comboBox_patternMatching_operation = new ComboBox();
            tabPage_append = new TabPage();
            label_append_postion = new Label();
            textBox_append_position = new AlsoNumberTextBox();
            radioButton_append_appendAt = new RadioButton();
            radioButton_append_appendToEnd = new RadioButton();
            radioButton_append_appendToStart = new RadioButton();
            label2 = new Label();
            textBox_append = new AlsoNumberTextBox();
            label_currentDirectory = new Label();
            dataGridView_preview = new DataGridView_Files();
            preview_column_FileName = new DataGridViewTextBoxColumn();
            preview_column_FileSize = new DataGridViewTextBoxColumn();
            preview_column_Hidden_FullName = new DataGridViewTextBoxColumn();
            dataGridView_selection = new DataGridView_Files();
            selection_column_FileName = new DataGridViewTextBoxColumn();
            selection_column_FileSize = new DataGridViewTextBoxColumn();
            selection_column_Hidden_FullName = new DataGridViewTextBoxColumn();
            flowLayoutPanel_Selection = new FlowLayoutPanel();
            flowLayoutPanel_preview = new FlowLayoutPanel();
            button_moveSelectedFiles = new Button();
            btn_rollback = new Button();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox_filter.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage_numberedSequence.SuspendLayout();
            tabPage_patternMatching.SuspendLayout();
            tabPage_append.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_preview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_selection).BeginInit();
            flowLayoutPanel_Selection.SuspendLayout();
            flowLayoutPanel_preview.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menu_file });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(955, 25);
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
            toolStrip2.Location = new Point(0, 459);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(0, 0, 2, 0);
            toolStrip2.Size = new Size(955, 25);
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
            // button_start
            // 
            button_start.Location = new Point(368, 247);
            button_start.Margin = new Padding(4, 3, 4, 3);
            button_start.Name = "button_start";
            button_start.Size = new Size(66, 56);
            button_start.TabIndex = 4;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_click;
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
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_numberedSequence);
            tabControl.Controls.Add(tabPage_patternMatching);
            tabControl.Controls.Add(tabPage_append);
            tabControl.Dock = DockStyle.Bottom;
            tabControl.Location = new Point(4, 3);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(499, 110);
            tabControl.TabIndex = 15;
            // 
            // tabPage_numberedSequence
            // 
            tabPage_numberedSequence.Controls.Add(numberedSequence_label);
            tabPage_numberedSequence.Controls.Add(NumberedSequence_text);
            tabPage_numberedSequence.Controls.Add(numbered_Sequence_before);
            tabPage_numberedSequence.Controls.Add(numbered_sequence_after);
            tabPage_numberedSequence.Location = new Point(4, 24);
            tabPage_numberedSequence.Margin = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Name = "tabPage_numberedSequence";
            tabPage_numberedSequence.Padding = new Padding(4, 3, 4, 3);
            tabPage_numberedSequence.Size = new Size(491, 82);
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
            // 
            // numbered_Sequence_before
            // 
            numbered_Sequence_before.AutoSize = true;
            numbered_Sequence_before.Checked = true;
            numbered_Sequence_before.Location = new Point(224, 6);
            numbered_Sequence_before.Name = "numbered_Sequence_before";
            numbered_Sequence_before.Size = new Size(61, 19);
            numbered_Sequence_before.TabIndex = 1;
            numbered_Sequence_before.TabStop = true;
            numbered_Sequence_before.Text = "Before";
            numbered_Sequence_before.UseVisualStyleBackColor = true;
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
            // 
            // tabPage_patternMatching
            // 
            tabPage_patternMatching.Controls.Add(label_patternMatching_to);
            tabPage_patternMatching.Controls.Add(textBox_Pattern_to);
            tabPage_patternMatching.Controls.Add(textBox_pattern_from);
            tabPage_patternMatching.Controls.Add(comboBox_patternMatching_operation);
            tabPage_patternMatching.Location = new Point(4, 24);
            tabPage_patternMatching.Name = "tabPage_patternMatching";
            tabPage_patternMatching.Padding = new Padding(3);
            tabPage_patternMatching.Size = new Size(491, 82);
            tabPage_patternMatching.TabIndex = 1;
            tabPage_patternMatching.Text = "Pattern";
            tabPage_patternMatching.UseVisualStyleBackColor = true;
            // 
            // label_patternMatching_to
            // 
            label_patternMatching_to.AutoSize = true;
            label_patternMatching_to.Location = new Point(239, 49);
            label_patternMatching_to.Name = "label_patternMatching_to";
            label_patternMatching_to.Size = new Size(17, 15);
            label_patternMatching_to.TabIndex = 3;
            label_patternMatching_to.Text = "to";
            // 
            // textBox_Pattern_to
            // 
            textBox_Pattern_to.Location = new Point(262, 46);
            textBox_Pattern_to.Name = "textBox_Pattern_to";
            textBox_Pattern_to.Size = new Size(223, 21);
            textBox_Pattern_to.TabIndex = 2;
            // 
            // textBox_pattern_from
            // 
            textBox_pattern_from.Location = new Point(6, 46);
            textBox_pattern_from.Name = "textBox_pattern_from";
            textBox_pattern_from.Size = new Size(231, 21);
            textBox_pattern_from.TabIndex = 1;
            // 
            // comboBox_patternMatching_operation
            // 
            comboBox_patternMatching_operation.FormattingEnabled = true;
            comboBox_patternMatching_operation.Location = new Point(6, 12);
            comboBox_patternMatching_operation.Name = "comboBox_patternMatching_operation";
            comboBox_patternMatching_operation.Size = new Size(231, 23);
            comboBox_patternMatching_operation.TabIndex = 0;
            // 
            // tabPage_append
            // 
            tabPage_append.Controls.Add(label_append_postion);
            tabPage_append.Controls.Add(textBox_append_position);
            tabPage_append.Controls.Add(radioButton_append_appendAt);
            tabPage_append.Controls.Add(radioButton_append_appendToEnd);
            tabPage_append.Controls.Add(radioButton_append_appendToStart);
            tabPage_append.Controls.Add(label2);
            tabPage_append.Controls.Add(textBox_append);
            tabPage_append.Location = new Point(4, 24);
            tabPage_append.Name = "tabPage_append";
            tabPage_append.Padding = new Padding(3);
            tabPage_append.Size = new Size(491, 82);
            tabPage_append.TabIndex = 2;
            tabPage_append.Text = "Append";
            tabPage_append.UseVisualStyleBackColor = true;
            // 
            // label_append_postion
            // 
            label_append_postion.AutoSize = true;
            label_append_postion.Location = new Point(17, 12);
            label_append_postion.Name = "label_append_postion";
            label_append_postion.Size = new Size(51, 15);
            label_append_postion.TabIndex = 6;
            label_append_postion.Text = "Position";
            // 
            // textBox_append_position
            // 
            textBox_append_position.Location = new Point(67, 10);
            textBox_append_position.Name = "textBox_append_position";
            textBox_append_position.Size = new Size(40, 21);
            textBox_append_position.TabIndex = 5;
            // 
            // radioButton_append_appendAt
            // 
            radioButton_append_appendAt.AutoSize = true;
            radioButton_append_appendAt.Checked = true;
            radioButton_append_appendAt.Location = new Point(240, 56);
            radioButton_append_appendAt.Name = "radioButton_append_appendAt";
            radioButton_append_appendAt.Size = new Size(126, 19);
            radioButton_append_appendAt.TabIndex = 4;
            radioButton_append_appendAt.TabStop = true;
            radioButton_append_appendAt.Text = "Append at position";
            radioButton_append_appendAt.UseVisualStyleBackColor = true;
            // 
            // radioButton_append_appendToEnd
            // 
            radioButton_append_appendToEnd.AutoSize = true;
            radioButton_append_appendToEnd.Location = new Point(240, 31);
            radioButton_append_appendToEnd.Name = "radioButton_append_appendToEnd";
            radioButton_append_appendToEnd.Size = new Size(104, 19);
            radioButton_append_appendToEnd.TabIndex = 3;
            radioButton_append_appendToEnd.TabStop = true;
            radioButton_append_appendToEnd.Text = "Append to end";
            radioButton_append_appendToEnd.UseVisualStyleBackColor = true;
            // 
            // radioButton_append_appendToStart
            // 
            radioButton_append_appendToStart.AutoSize = true;
            radioButton_append_appendToStart.Location = new Point(240, 6);
            radioButton_append_appendToStart.Name = "radioButton_append_appendToStart";
            radioButton_append_appendToStart.Size = new Size(106, 19);
            radioButton_append_appendToStart.TabIndex = 2;
            radioButton_append_appendToStart.TabStop = true;
            radioButton_append_appendToStart.Text = "Append to start";
            radioButton_append_appendToStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Append";
            // 
            // textBox_append
            // 
            textBox_append.Location = new Point(67, 54);
            textBox_append.Name = "textBox_append";
            textBox_append.Size = new Size(164, 21);
            textBox_append.TabIndex = 0;
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
            // dataGridView_preview
            // 
            dataGridView_preview.AllowUserToAddRows = false;
            dataGridView_preview.AllowUserToResizeRows = false;
            dataGridView_preview.Columns.AddRange(new DataGridViewColumn[] { preview_column_FileName, preview_column_FileSize, preview_column_Hidden_FullName });
            dataGridView_preview.Location = new Point(3, 119);
            dataGridView_preview.Name = "dataGridView_preview";
            dataGridView_preview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_preview.Size = new Size(499, 302);
            dataGridView_preview.TabIndex = 0;
            dataGridView_preview.CellDoubleClick += dataGridView_preview_cellDoubleClick;
            dataGridView_preview.SelectionChanged += dataGridView_preview_selectionChanged;
            // 
            // preview_column_FileName
            // 
            preview_column_FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            preview_column_FileName.HeaderText = "Name";
            preview_column_FileName.Name = "preview_column_FileName";
            // 
            // preview_column_FileSize
            // 
            preview_column_FileSize.HeaderText = "Size";
            preview_column_FileSize.Name = "preview_column_FileSize";
            // 
            // preview_column_Hidden_FullName
            // 
            preview_column_Hidden_FullName.HeaderText = "hidden Id";
            preview_column_Hidden_FullName.Name = "preview_column_Hidden_FullName";
            preview_column_Hidden_FullName.Visible = false;
            // 
            // dataGridView_selection
            // 
            dataGridView_selection.AllowUserToAddRows = false;
            dataGridView_selection.AllowUserToResizeRows = false;
            dataGridView_selection.Columns.AddRange(new DataGridViewColumn[] { selection_column_FileName, selection_column_FileSize, selection_column_Hidden_FullName });
            dataGridView_selection.Location = new Point(3, 100);
            dataGridView_selection.Name = "dataGridView_selection";
            dataGridView_selection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_selection.Size = new Size(341, 321);
            dataGridView_selection.TabIndex = 0;
            dataGridView_selection.CellDoubleClick += dataGridView_selection_cellDoubleClick;
            dataGridView_selection.SelectionChanged += dataGridView_selection_selectionChanged;
            // 
            // selection_column_FileName
            // 
            selection_column_FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            selection_column_FileName.HeaderText = "Name";
            selection_column_FileName.Name = "selection_column_FileName";
            // 
            // selection_column_FileSize
            // 
            selection_column_FileSize.HeaderText = "Size";
            selection_column_FileSize.Name = "selection_column_FileSize";
            // 
            // selection_column_Hidden_FullName
            // 
            selection_column_Hidden_FullName.HeaderText = "hidden Id";
            selection_column_Hidden_FullName.Name = "selection_column_Hidden_FullName";
            selection_column_Hidden_FullName.Visible = false;
            // 
            // flowLayoutPanel_Selection
            // 
            flowLayoutPanel_Selection.Controls.Add(label_currentDirectory);
            flowLayoutPanel_Selection.Controls.Add(groupBox_filter);
            flowLayoutPanel_Selection.Controls.Add(dataGridView_selection);
            flowLayoutPanel_Selection.Enabled = false;
            flowLayoutPanel_Selection.Location = new Point(12, 35);
            flowLayoutPanel_Selection.Name = "flowLayoutPanel_Selection";
            flowLayoutPanel_Selection.Size = new Size(349, 421);
            flowLayoutPanel_Selection.TabIndex = 0;
            // 
            // flowLayoutPanel_preview
            // 
            flowLayoutPanel_preview.Controls.Add(tabControl);
            flowLayoutPanel_preview.Controls.Add(dataGridView_preview);
            flowLayoutPanel_preview.Enabled = false;
            flowLayoutPanel_preview.Location = new Point(441, 35);
            flowLayoutPanel_preview.Name = "flowLayoutPanel_preview";
            flowLayoutPanel_preview.Size = new Size(502, 421);
            flowLayoutPanel_preview.TabIndex = 0;
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
            // btn_rollback
            // 
            btn_rollback.Location = new Point(367, 309);
            btn_rollback.Name = "btn_rollback";
            btn_rollback.Size = new Size(66, 56);
            btn_rollback.TabIndex = 6;
            btn_rollback.Text = "Rollback";
            btn_rollback.UseVisualStyleBackColor = true;
            btn_rollback.Click += btn_rollback_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(955, 484);
            Controls.Add(btn_rollback);
            Controls.Add(button_moveSelectedFiles);
            Controls.Add(flowLayoutPanel_preview);
            Controls.Add(flowLayoutPanel_Selection);
            Controls.Add(button_start);
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
            tabControl.ResumeLayout(false);
            tabPage_numberedSequence.ResumeLayout(false);
            tabPage_numberedSequence.PerformLayout();
            tabPage_patternMatching.ResumeLayout(false);
            tabPage_patternMatching.PerformLayout();
            tabPage_append.ResumeLayout(false);
            tabPage_append.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_preview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_selection).EndInit();
            flowLayoutPanel_Selection.ResumeLayout(false);
            flowLayoutPanel_Selection.PerformLayout();
            flowLayoutPanel_preview.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton menu_file;
        private ToolStripMenuItem menuOpt_file_open;
        private ToolStrip toolStrip2;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button button_start;
        private AlsoNumberTextBox textBox_searchFilter;
        private ToolStripLabel toolStripLabel_progress;
        private GroupBox groupBox_filter;
        private TabControl tabControl;
        
        private TabPage tabPage_numberedSequence;
        private RadioButton radioButton_smallerThan;
        private RadioButton radioButton_contains;
        private RadioButton radioButton_greaterThan;
        private Label label_currentDirectory;
        private FlowLayoutPanel flowLayoutPanel_Selection;
        private FlowLayoutPanel flowLayoutPanel_preview;
        private DataGridView_Files dataGridView_preview;
        private DataGridView_Files dataGridView_selection;
        private Button button_moveSelectedFiles;
        private RadioButton numbered_Sequence_before;
        private RadioButton numbered_sequence_after;
        private Label numberedSequence_label;
        private TextBox NumberedSequence_text;

        private DataGridViewTextBoxColumn selection_column_FileName;
        private DataGridViewTextBoxColumn selection_column_FileSize;
        private DataGridViewTextBoxColumn selection_column_Hidden_FullName;
        private DataGridViewTextBoxColumn preview_column_FileName;
        private DataGridViewTextBoxColumn preview_column_FileSize;
        private DataGridViewTextBoxColumn preview_column_Hidden_FullName;
        private TabPage tabPage_patternMatching;
        private AlsoNumberTextBox textBox_pattern_from;
        private ComboBox comboBox_patternMatching_operation;
        private TabPage tabPage_append;
        private Label label_patternMatching_to;
        private AlsoNumberTextBox textBox_Pattern_to;
        //
        // Custom Wrappers
        //
        private ITabControl TabNumberedSequenceWrapper;
        private ITabControl TabPatternMatchingWrapper;
        private ITabAppend TabAppendWrapper;
        
        private ITabControlWrapper TabControlWrapper;

        private RadioButton radioButton_append_appendAt;
        private RadioButton radioButton_append_appendToEnd;
        private RadioButton radioButton_append_appendToStart;
        private Label label2;
        private AlsoNumberTextBox textBox_append;
        private Label label_append_postion;
        private AlsoNumberTextBox textBox_append_position;
        private Button btn_rollback;
        //Code removed for further implementation
        //private Label label_versioning;
        //private ComboBox comboBox_versioning;
        //private IComboBoxVersioning comboBoxWrapper;

    }
}
