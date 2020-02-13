namespace SuperMetroidRandomizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.randomSpoiler = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.createSpoilerLog = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randomizerDifficulty = new System.Windows.Forms.ComboBox();
            this.controlsV11 = new System.Windows.Forms.Button();
            this.browseV11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputV11 = new System.Windows.Forms.TextBox();
            this.seedV11 = new System.Windows.Forms.TextBox();
            this.createV11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filenameV11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBaseRomPath = new System.Windows.Forms.TextBox();
            this.bBrowseBaseRomPath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 459);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bBrowseBaseRomPath);
            this.tabPage1.Controls.Add(this.tbBaseRomPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.randomSpoiler);
            this.tabPage1.Controls.Add(this.report);
            this.tabPage1.Controls.Add(this.createSpoilerLog);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.randomizerDifficulty);
            this.tabPage1.Controls.Add(this.controlsV11);
            this.tabPage1.Controls.Add(this.browseV11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.outputV11);
            this.tabPage1.Controls.Add(this.seedV11);
            this.tabPage1.Controls.Add(this.createV11);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.filenameV11);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(704, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project Base 0.7.2 Randomizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // randomSpoiler
            // 
            this.randomSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.randomSpoiler.Location = new System.Drawing.Point(11, 388);
            this.randomSpoiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomSpoiler.Name = "randomSpoiler";
            this.randomSpoiler.Size = new System.Drawing.Size(133, 28);
            this.randomSpoiler.TabIndex = 35;
            this.randomSpoiler.Text = "Random Spoiler";
            this.randomSpoiler.UseVisualStyleBackColor = true;
            this.randomSpoiler.Click += new System.EventHandler(this.randomSpoiler_Click);
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.report.Location = new System.Drawing.Point(571, 388);
            this.report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(123, 28);
            this.report.TabIndex = 22;
            this.report.Text = "Report an issue";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // createSpoilerLog
            // 
            this.createSpoilerLog.AutoSize = true;
            this.createSpoilerLog.Location = new System.Drawing.Point(256, 9);
            this.createSpoilerLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createSpoilerLog.Name = "createSpoilerLog";
            this.createSpoilerLog.Size = new System.Drawing.Size(148, 21);
            this.createSpoilerLog.TabIndex = 21;
            this.createSpoilerLog.Text = "Create Spoiler Log";
            this.createSpoilerLog.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Difficulty:";
            // 
            // randomizerDifficulty
            // 
            this.randomizerDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomizerDifficulty.FormattingEnabled = true;
            this.randomizerDifficulty.Items.AddRange(new object[] {
            "Casual",
            "Speedrunner",
            "Masochist"});
            this.randomizerDifficulty.Location = new System.Drawing.Point(85, 7);
            this.randomizerDifficulty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomizerDifficulty.Name = "randomizerDifficulty";
            this.randomizerDifficulty.Size = new System.Drawing.Size(160, 24);
            this.randomizerDifficulty.TabIndex = 19;
            // 
            // controlsV11
            // 
            this.controlsV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsV11.Location = new System.Drawing.Point(485, 21);
            this.controlsV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlsV11.Name = "controlsV11";
            this.controlsV11.Size = new System.Drawing.Size(100, 28);
            this.controlsV11.TabIndex = 18;
            this.controlsV11.Tag = "Current";
            this.controlsV11.Text = "Controls";
            this.controlsV11.UseVisualStyleBackColor = true;
            this.controlsV11.Click += new System.EventHandler(this.controlsV11_Click);
            // 
            // browseV11
            // 
            this.browseV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseV11.Image = global::SuperMetroidRandomizer.Properties.Resources.MenuFileSaveIcon;
            this.browseV11.Location = new System.Drawing.Point(660, 101);
            this.browseV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseV11.Name = "browseV11";
            this.browseV11.Size = new System.Drawing.Size(33, 31);
            this.browseV11.TabIndex = 15;
            this.browseV11.UseVisualStyleBackColor = true;
            this.browseV11.Click += new System.EventHandler(this.browseV11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Seed (leave blank to generate new random ROM)";
            this.label3.Click += new System.EventHandler(this.Label3Click);
            // 
            // outputV11
            // 
            this.outputV11.AcceptsReturn = true;
            this.outputV11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputV11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputV11.Location = new System.Drawing.Point(8, 183);
            this.outputV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputV11.Multiline = true;
            this.outputV11.Name = "outputV11";
            this.outputV11.ReadOnly = true;
            this.outputV11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputV11.Size = new System.Drawing.Size(684, 197);
            this.outputV11.TabIndex = 10;
            // 
            // seedV11
            // 
            this.seedV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seedV11.Location = new System.Drawing.Point(8, 57);
            this.seedV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seedV11.Name = "seedV11";
            this.seedV11.Size = new System.Drawing.Size(684, 22);
            this.seedV11.TabIndex = 16;
            // 
            // createV11
            // 
            this.createV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createV11.Location = new System.Drawing.Point(593, 21);
            this.createV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createV11.Name = "createV11";
            this.createV11.Size = new System.Drawing.Size(100, 28);
            this.createV11.TabIndex = 11;
            this.createV11.Text = "Create";
            this.createV11.UseVisualStyleBackColor = true;
            this.createV11.Click += new System.EventHandler(this.createV11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output Filename (<seed> is replaced with file seed, <date> is replaced with date)" +
    "";
            // 
            // filenameV11
            // 
            this.filenameV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameV11.Location = new System.Drawing.Point(8, 105);
            this.filenameV11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filenameV11.Name = "filenameV11";
            this.filenameV11.Size = new System.Drawing.Size(643, 22);
            this.filenameV11.TabIndex = 14;
            this.filenameV11.Text = "SMPB Random <seed>.sfc";
            this.filenameV11.TextChanged += new System.EventHandler(this.filenameV11_TextChanged);
            this.filenameV11.Leave += new System.EventHandler(this.filename_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Base ROM";
            // 
            // tbBaseRomPath
            // 
            this.tbBaseRomPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBaseRomPath.Location = new System.Drawing.Point(8, 153);
            this.tbBaseRomPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbBaseRomPath.Name = "tbBaseRomPath";
            this.tbBaseRomPath.Size = new System.Drawing.Size(643, 22);
            this.tbBaseRomPath.TabIndex = 37;
            // 
            // bBrowseBaseRomPath
            // 
            this.bBrowseBaseRomPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseBaseRomPath.Image = global::SuperMetroidRandomizer.Properties.Resources.MenuFileSaveIcon;
            this.bBrowseBaseRomPath.Location = new System.Drawing.Point(659, 149);
            this.bBrowseBaseRomPath.Margin = new System.Windows.Forms.Padding(4);
            this.bBrowseBaseRomPath.Name = "bBrowseBaseRomPath";
            this.bBrowseBaseRomPath.Size = new System.Drawing.Size(33, 31);
            this.bBrowseBaseRomPath.TabIndex = 38;
            this.bBrowseBaseRomPath.UseVisualStyleBackColor = true;
            this.bBrowseBaseRomPath.Click += new System.EventHandler(this.bBrowseBaseRomPath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 460);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Super Metroid Project Base Randomizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button browseV11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputV11;
        private System.Windows.Forms.TextBox seedV11;
        private System.Windows.Forms.Button createV11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filenameV11;
        private System.Windows.Forms.Button controlsV11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox randomizerDifficulty;
        private System.Windows.Forms.CheckBox createSpoilerLog;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button randomSpoiler;
        private System.Windows.Forms.Button bBrowseBaseRomPath;
        private System.Windows.Forms.TextBox tbBaseRomPath;
        private System.Windows.Forms.Label label1;
    }
}

