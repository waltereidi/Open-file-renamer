using ApplicationService.Enum;
using Presentation.UI.Main;

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
            toolStripTop = new ToolStrip();
            menu_file = new ToolStripDropDownButton();
            menuOpt_file_open = new ToolStripMenuItem();
            panel_folderFiles = new Panel();
            panel_filePreview = new Panel();
            toolStripBottom = new ToolStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripLabel_progress = new ToolStripLabel();
            buttonStart = new Button();
            textBox_searchFilter = new TextBox();

            radioButtonFilters[0] = new RadioButton();
            radioButtonFilters[1] = new RadioButton();
            radioButtonFilters[2] = new RadioButton();
            radioButtonFilters[3] = new RadioButton();

            groupBox_filter = new GroupBoxFilter(textBox_searchFilter , radioButtonFilters);
            button_rollBack = new Button();
            tabControl_numberedSequence = new TabControl();
            tabPage_numberedSequence = new TabPage();
            tabPage2 = new TabPage();
            toolStripTop.SuspendLayout();
            toolStripBottom.SuspendLayout();
            tabControl_numberedSequence.SuspendLayout();

            // 
            // toolStripTop
            // 
            toolStripTop.Items.AddRange(new ToolStripItem[] { menu_file });
            toolStripTop.Location = new Point(0, 0);
            toolStripTop.Name = "toolStripTop";
            toolStripTop.Size = new Size(796, 25);
            toolStripTop.TabIndex = 0;
            toolStripTop.Text = "toolStripTop";
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
            // panel_folderFiles
            // 
            panel_folderFiles.BackColor = Color.NavajoWhite;
            panel_folderFiles.BorderStyle = BorderStyle.Fixed3D;
            panel_folderFiles.Location = new Point(22, 116);
            panel_folderFiles.Name = "panel_folderFiles";
            panel_folderFiles.Size = new Size(339, 296);
            panel_folderFiles.TabIndex = 1;
            panel_folderFiles.Paint += panel_1_Paint;
            // 
            // panel_filePreview
            // 
            panel_filePreview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_filePreview.BackColor = SystemColors.Window;
            panel_filePreview.BorderStyle = BorderStyle.Fixed3D;
            panel_filePreview.Location = new Point(444, 116);
            panel_filePreview.Name = "panel_filePreview";
            panel_filePreview.Size = new Size(334, 296);
            panel_filePreview.TabIndex = 2;
            panel_filePreview.Paint += panel_2_Paint;
            // 
            // toolStripBottom
            // 
            toolStripBottom.BackColor = SystemColors.Window;
            toolStripBottom.Dock = DockStyle.Bottom;
            toolStripBottom.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripLabel_progress });
            toolStripBottom.Location = new Point(0, 425);
            toolStripBottom.Name = "toolStripBottom";
            toolStripBottom.Size = new Size(796, 25);
            toolStripBottom.TabIndex = 3;
            toolStripBottom.Text = "toolStripBottom";
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
            // buttonStart
            // 
            buttonStart.Location = new Point(367, 116);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(66, 60);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // textBox_searchFilter
            // 
            textBox_searchFilter.Location = new Point(6, 47);
            textBox_searchFilter.Name = "textBox_searchFilter";
            textBox_searchFilter.Size = new Size(327, 23);
            textBox_searchFilter.TabIndex = 5;
            textBox_searchFilter.TextChanged += textBox_searchFilter_Changed;
            // 
            // radioButton1
            // 
            radioButtonFilters[0].AutoSize = true;
            radioButtonFilters[0].Location = new Point(6, 22);
            radioButtonFilters[0].Name = Main_SearchFilter.Contains.ToString();
            radioButtonFilters[0].Size = new Size(72, 19);
            radioButtonFilters[0].TabIndex = 9;
            radioButtonFilters[0].TabStop = true;
            radioButtonFilters[0].Text = "Contains";
            radioButtonFilters[0].UseVisualStyleBackColor = true;
            radioButtonFilters[0].CheckedChanged += textBox_searchFilter_Changed;
            // 
            // radioButton2
            // 
            radioButtonFilters[1].AutoSize = true;
            radioButtonFilters[1].Location = new Point(84, 22);
            radioButtonFilters[1].Name = Main_SearchFilter.BiggerThan.ToString();
            radioButtonFilters[1].Size = new Size(88, 19);
            radioButtonFilters[1].TabIndex = 10;
            radioButtonFilters[1].TabStop = true;
            radioButtonFilters[1].Text = "Bigger Than";
            radioButtonFilters[1].UseVisualStyleBackColor = true;
            radioButtonFilters[1].CheckedChanged += textBox_searchFilter_Changed;
            // 
            // radioButton3
            // 
            radioButtonFilters[2].AutoSize = true;
            radioButtonFilters[2].Location = new Point(168, 22);
            radioButtonFilters[2].Name = Main_SearchFilter.SmallerThan.ToString();
            radioButtonFilters[2].Size = new Size(93, 19);
            radioButtonFilters[2].TabIndex = 11;
            radioButtonFilters[2].TabStop = true;
            radioButtonFilters[2].Text = "Smaller Than";
            radioButtonFilters[2].UseVisualStyleBackColor = true;
            radioButtonFilters[2].CheckedChanged += textBox_searchFilter_Changed;
            // 
            // radioButton4
            // 
            radioButtonFilters[3].AutoSize = true;
            radioButtonFilters[3].Location = new Point(267, 22);
            radioButtonFilters[3].Name = Main_SearchFilter.Select.ToString();
            radioButtonFilters[3].Size = new Size(56, 19);
            radioButtonFilters[3].TabIndex = 12;
            radioButtonFilters[3].TabStop = true;
            radioButtonFilters[3].Text = "Select";
            radioButtonFilters[3].UseVisualStyleBackColor = true;
            radioButtonFilters[3].CheckedChanged += textBox_searchFilter_Changed;
            // 
            // button_rollBack
            // 
            button_rollBack.Location = new Point(367, 182);
            button_rollBack.Name = "button_rollBack";
            button_rollBack.Size = new Size(66, 57);
            button_rollBack.TabIndex = 14;
            button_rollBack.Text = "rollback";
            button_rollBack.UseVisualStyleBackColor = true;
            button_rollBack.Click += button1_Click_2;
            // 
            // tabControl_numberedSequence
            // 
            tabControl_numberedSequence.Controls.Add(tabPage_numberedSequence);
            tabControl_numberedSequence.Controls.Add(tabPage2);
            tabControl_numberedSequence.Location = new Point(444, 28);
            tabControl_numberedSequence.Name = "tabControl_numberedSequence";
            tabControl_numberedSequence.SelectedIndex = 0;
            tabControl_numberedSequence.Size = new Size(334, 81);
            tabControl_numberedSequence.TabIndex = 15;
            // 
            // tabPage_numberedSequence
            // 
            tabPage_numberedSequence.Location = new Point(4, 24);
            tabPage_numberedSequence.Name = "tabPage_numberedSequence";
            tabPage_numberedSequence.Padding = new Padding(3);
            tabPage_numberedSequence.Size = new Size(326, 53);
            tabPage_numberedSequence.TabIndex = 0;
            tabPage_numberedSequence.Text = "Numbered Sequence";
            tabPage_numberedSequence.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(326, 53);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(796, 450);
            Controls.Add(tabControl_numberedSequence);
            Controls.Add(button_rollBack);
            Controls.Add(groupBox_filter);
            Controls.Add(buttonStart);
            Controls.Add(toolStripBottom);
            Controls.Add(panel_filePreview);
            Controls.Add(panel_folderFiles);
            Controls.Add(toolStripTop);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "Free File Editor";
            toolStripTop.ResumeLayout(false);
            toolStripTop.PerformLayout();
            toolStripBottom.ResumeLayout(false);
            toolStripBottom.PerformLayout();
            groupBox_filter.ResumeLayout(false);
            groupBox_filter.PerformLayout();
            tabControl_numberedSequence.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripTop;
        private ToolStripDropDownButton menu_file;
        private ToolStripMenuItem menuOpt_file_open;
        private Panel panel_folderFiles;
        private Panel panel_filePreview;
        private ToolStrip toolStripBottom;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button buttonStart;
        private TextBox textBox_searchFilter;
        private ToolStripLabel toolStripLabel_progress;
        private RadioButton[] radioButtonFilters = new RadioButton[4]; 
        private GroupBox groupBox_filter;
        private Button button_rollBack;
        private TabControl tabControl_numberedSequence;
        private TabPage tabPage_numberedSequence;
        private TabPage tabPage2;
    }
}
