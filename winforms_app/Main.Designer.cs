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
            start = new Button();
            textBox_editarArquivo = new TextBox();
            previewLabel = new Label();
            toolStripLabel_progress = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menu_file });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
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
            panel_1.BackColor = SystemColors.ButtonFace;
            panel_1.BorderStyle = BorderStyle.Fixed3D;
            panel_1.Location = new Point(22, 91);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(339, 296);
            panel_1.TabIndex = 1;
            panel_1.Paint += panel_1_Paint;
            // 
            // panel_2
            // 
            panel_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_2.BackColor = SystemColors.ButtonFace;
            panel_2.BorderStyle = BorderStyle.Fixed3D;
            panel_2.Location = new Point(439, 91);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(339, 296);
            panel_2.TabIndex = 2;
            panel_2.Paint += panel2_Paint;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripLabel_progress });
            toolStrip2.Location = new Point(0, 425);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 25);
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
            // start
            // 
            start.Location = new Point(367, 205);
            start.Name = "start";
            start.Size = new Size(66, 60);
            start.TabIndex = 4;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += button1_Click;
            // 
            // textBox_editarArquivo
            // 
            textBox_editarArquivo.Location = new Point(22, 41);
            textBox_editarArquivo.Name = "textBox_editarArquivo";
            textBox_editarArquivo.Size = new Size(339, 23);
            textBox_editarArquivo.TabIndex = 5;
            textBox_editarArquivo.TextChanged += textBox_editarArquivo_TextChanged;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            previewLabel.Location = new Point(439, 73);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(48, 15);
            previewLabel.TabIndex = 6;
            previewLabel.Text = "Preview";
            // 
            // toolStripLabel_progress
            // 
            toolStripLabel_progress.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel_progress.Name = "toolStripLabel_progress";
            toolStripLabel_progress.Size = new Size(29, 22);
            toolStripLabel_progress.Text = "0 % ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(previewLabel);
            Controls.Add(textBox_editarArquivo);
            Controls.Add(start);
            Controls.Add(toolStrip2);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "Free File Editor";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
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
        private TextBox textBox_editarArquivo;
        private Label previewLabel;
        private ToolStripLabel toolStripLabel_progress;
    }
}
