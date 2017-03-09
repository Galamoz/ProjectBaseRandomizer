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
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(534, 373);
        	this.tabControl1.TabIndex = 10;
        	// 
        	// tabPage1
        	// 
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
        	this.tabPage1.Location = new System.Drawing.Point(4, 25);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(526, 344);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "Project Base 0.7.2 Randomizer";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// randomSpoiler
        	// 
        	this.randomSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.randomSpoiler.Location = new System.Drawing.Point(8, 315);
        	this.randomSpoiler.Name = "randomSpoiler";
        	this.randomSpoiler.Size = new System.Drawing.Size(100, 23);
        	this.randomSpoiler.TabIndex = 35;
        	this.randomSpoiler.Text = "Random Spoiler";
        	this.randomSpoiler.UseVisualStyleBackColor = true;
        	this.randomSpoiler.Click += new System.EventHandler(this.randomSpoiler_Click);
        	// 
        	// report
        	// 
        	this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.report.Location = new System.Drawing.Point(428, 315);
        	this.report.Name = "report";
        	this.report.Size = new System.Drawing.Size(92, 23);
        	this.report.TabIndex = 22;
        	this.report.Text = "Report an issue";
        	this.report.UseVisualStyleBackColor = true;
        	this.report.Click += new System.EventHandler(this.report_Click);
        	// 
        	// createSpoilerLog
        	// 
        	this.createSpoilerLog.AutoSize = true;
        	this.createSpoilerLog.Location = new System.Drawing.Point(192, 7);
        	this.createSpoilerLog.Name = "createSpoilerLog";
        	this.createSpoilerLog.Size = new System.Drawing.Size(113, 17);
        	this.createSpoilerLog.TabIndex = 21;
        	this.createSpoilerLog.Text = "Create Spoiler Log";
        	this.createSpoilerLog.UseVisualStyleBackColor = true;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(8, 9);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(50, 13);
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
        	this.randomizerDifficulty.Location = new System.Drawing.Point(64, 6);
        	this.randomizerDifficulty.Name = "randomizerDifficulty";
        	this.randomizerDifficulty.Size = new System.Drawing.Size(121, 21);
        	this.randomizerDifficulty.TabIndex = 19;
        	// 
        	// controlsV11
        	// 
        	this.controlsV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.controlsV11.Location = new System.Drawing.Point(364, 17);
        	this.controlsV11.Name = "controlsV11";
        	this.controlsV11.Size = new System.Drawing.Size(75, 23);
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
        	this.browseV11.Location = new System.Drawing.Point(495, 82);
        	this.browseV11.Name = "browseV11";
        	this.browseV11.Size = new System.Drawing.Size(25, 25);
        	this.browseV11.TabIndex = 15;
        	this.browseV11.UseVisualStyleBackColor = true;
        	this.browseV11.Click += new System.EventHandler(this.browseV11_Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(3, 30);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(242, 13);
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
        	this.outputV11.Location = new System.Drawing.Point(6, 111);
        	this.outputV11.Multiline = true;
        	this.outputV11.Name = "outputV11";
        	this.outputV11.ReadOnly = true;
        	this.outputV11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.outputV11.Size = new System.Drawing.Size(514, 198);
        	this.outputV11.TabIndex = 10;
        	// 
        	// seedV11
        	// 
        	this.seedV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.seedV11.Location = new System.Drawing.Point(6, 46);
        	this.seedV11.Name = "seedV11";
        	this.seedV11.Size = new System.Drawing.Size(514, 20);
        	this.seedV11.TabIndex = 16;
        	// 
        	// createV11
        	// 
        	this.createV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.createV11.Location = new System.Drawing.Point(445, 17);
        	this.createV11.Name = "createV11";
        	this.createV11.Size = new System.Drawing.Size(75, 23);
        	this.createV11.TabIndex = 11;
        	this.createV11.Text = "Create";
        	this.createV11.UseVisualStyleBackColor = true;
        	this.createV11.Click += new System.EventHandler(this.createV11_Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(3, 69);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(385, 13);
        	this.label4.TabIndex = 13;
        	this.label4.Text = "Output Filename (<seed> is replaced with file seed, <date> is replaced with date)" +
	"";
        	// 
        	// filenameV11
        	// 
        	this.filenameV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.filenameV11.Location = new System.Drawing.Point(6, 85);
        	this.filenameV11.Name = "filenameV11";
        	this.filenameV11.Size = new System.Drawing.Size(483, 20);
        	this.filenameV11.TabIndex = 14;
        	this.filenameV11.Text = "SMPB Random <seed>.sfc";
        	this.filenameV11.TextChanged += new System.EventHandler(this.filenameV11_TextChanged);
        	this.filenameV11.Leave += new System.EventHandler(this.filename_Leave);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(532, 374);
        	this.Controls.Add(this.tabControl1);
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
    }
}

