using ApplicationService.Enum;

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
            panel_1 = new Panel();
            panel_2 = new Panel();
            toolStrip2 = new ToolStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripLabel_progress = new ToolStripLabel();
            start = new Button();
            textBox_searchFilter = new TextBox();
            
            radioButtonFilters[0] = new RadioButton();
            radioButtonFilters[1] = new RadioButton();
            radioButtonFilters[2] = new RadioButton();
            radioButtonFilters[3] = new RadioButton();

            groupBox_filter = new GroupBox();
            button1 = new Button();
            tabControl_numberedSequence = new TabControl();
            tabPage_numberedSequence = new TabPage();
            tabPage2 = new TabPage();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox_filter.SuspendLayout();
            tabControl_numberedSequence.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menu_file });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(796, 25);
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
            // panel_1
            // 
            panel_1.BackColor = Color.NavajoWhite;
            panel_1.BorderStyle = BorderStyle.Fixed3D;
            panel_1.Location = new Point(22, 116);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(339, 296);
            panel_1.TabIndex = 1;
            // 
            // panel_2
            // 
            panel_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_2.BackColor = SystemColors.Window;
            panel_2.BorderStyle = BorderStyle.Fixed3D;
            panel_2.Location = new Point(444, 116);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(334, 296);
            panel_2.TabIndex = 2;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripLabel_progress });
            toolStrip2.Location = new Point(0, 425);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(796, 25);
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
            start.Location = new Point(367, 116);
            start.Name = "start";
            start.Size = new Size(66, 60);
            start.TabIndex = 4;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += button1_Click;
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
            radioButtonFilters[1].Name = Main_SearchFilter.BiggerThan.ToString(); ;
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
            radioButtonFilters[2].CheckedChanged += textBox_searchFilter_Changed;
            // 
            // groupBox_filter
            // 
            groupBox_filter.Controls.Add(radioButtonFilters[3]);
            groupBox_filter.Controls.Add(radioButtonFilters[0]);
            groupBox_filter.Controls.Add(radioButtonFilters[2]);
            groupBox_filter.Controls.Add(textBox_searchFilter);
            groupBox_filter.Controls.Add(radioButtonFilters[1]);
            groupBox_filter.Location = new Point(22, 28);
            groupBox_filter.Name = "groupBox_filter";
            groupBox_filter.Size = new Size(339, 81);
            groupBox_filter.TabIndex = 13;
            groupBox_filter.TabStop = false;
            groupBox_filter.Text = "Filter";
            // 
            // button1
            // 
            button1.Location = new Point(367, 182);
            button1.Name = "button1";
            button1.Size = new Size(66, 57);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
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
            Controls.Add(button1);
            Controls.Add(groupBox_filter);
            Controls.Add(start);
            Controls.Add(toolStrip2);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "Free File Editor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox_filter.ResumeLayout(false);
            groupBox_filter.PerformLayout();
            tabControl_numberedSequence.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton menu_file;
        private ToolStripMenuItem menuOpt_file_open;
        private Panel panel_1;
        private Panel panel_2;
        private ToolStrip toolStrip2;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button start;
        private TextBox textBox_searchFilter;
        private ToolStripLabel toolStripLabel_progress;
        private RadioButton[] radioButtonFilters = new RadioButton[4]; 
        private GroupBox groupBox_filter;
        private Button button1;
        private TabControl tabControl_numberedSequence;
        private TabPage tabPage_numberedSequence;
        private TabPage tabPage2;
    }
}
