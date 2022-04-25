namespace Team4_Project4
{
    partial class CacheConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacheConfigForm));
            this.cacheConfigLabel = new System.Windows.Forms.Label();
            this.hitCyclesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.missCyclesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.twoSetAssocRadiobutton = new System.Windows.Forms.RadioButton();
            this.fourSetAssocRadiobutton = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entriesComboBox = new System.Windows.Forms.ComboBox();
            this.lineSizeComboBox = new System.Windows.Forms.ComboBox();
            this.hitCyclesLabel = new System.Windows.Forms.Label();
            this.missCycleslabel = new System.Windows.Forms.Label();
            this.cyclesLabel = new System.Windows.Forms.Label();
            this.configPanel = new System.Windows.Forms.Panel();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.lineSizeLabel = new System.Windows.Forms.Label();
            this.entriesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hitCyclesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missCyclesNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.configPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cacheConfigLabel
            // 
            this.cacheConfigLabel.AutoSize = true;
            this.cacheConfigLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cacheConfigLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cacheConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheConfigLabel.Location = new System.Drawing.Point(160, 36);
            this.cacheConfigLabel.Name = "cacheConfigLabel";
            this.cacheConfigLabel.Size = new System.Drawing.Size(264, 33);
            this.cacheConfigLabel.TabIndex = 1;
            this.cacheConfigLabel.Text = "Cache Configuration";
            // 
            // hitCyclesNumericUpDown
            // 
            this.hitCyclesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitCyclesNumericUpDown.Location = new System.Drawing.Point(143, 119);
            this.hitCyclesNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.hitCyclesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hitCyclesNumericUpDown.Name = "hitCyclesNumericUpDown";
            this.hitCyclesNumericUpDown.ReadOnly = true;
            this.hitCyclesNumericUpDown.Size = new System.Drawing.Size(70, 32);
            this.hitCyclesNumericUpDown.TabIndex = 113;
            this.hitCyclesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hitCyclesNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hitCyclesNumericUpDown_KeyPress);
            // 
            // missCyclesNumericUpDown
            // 
            this.missCyclesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missCyclesNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.missCyclesNumericUpDown.Location = new System.Drawing.Point(143, 157);
            this.missCyclesNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.missCyclesNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.missCyclesNumericUpDown.Name = "missCyclesNumericUpDown";
            this.missCyclesNumericUpDown.ReadOnly = true;
            this.missCyclesNumericUpDown.Size = new System.Drawing.Size(70, 32);
            this.missCyclesNumericUpDown.TabIndex = 114;
            this.missCyclesNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.missCyclesNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.missCyclesNumericUpDown_KeyPress);
            // 
            // twoSetAssocRadiobutton
            // 
            this.twoSetAssocRadiobutton.AutoSize = true;
            this.twoSetAssocRadiobutton.BackColor = System.Drawing.Color.Black;
            this.twoSetAssocRadiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoSetAssocRadiobutton.Location = new System.Drawing.Point(180, 3);
            this.twoSetAssocRadiobutton.Name = "twoSetAssocRadiobutton";
            this.twoSetAssocRadiobutton.Size = new System.Drawing.Size(249, 30);
            this.twoSetAssocRadiobutton.TabIndex = 115;
            this.twoSetAssocRadiobutton.Text = "2-Way Set Associative";
            this.twoSetAssocRadiobutton.UseVisualStyleBackColor = false;
            // 
            // fourSetAssocRadiobutton
            // 
            this.fourSetAssocRadiobutton.AutoSize = true;
            this.fourSetAssocRadiobutton.BackColor = System.Drawing.Color.Black;
            this.fourSetAssocRadiobutton.Checked = true;
            this.fourSetAssocRadiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourSetAssocRadiobutton.Location = new System.Drawing.Point(180, 39);
            this.fourSetAssocRadiobutton.Name = "fourSetAssocRadiobutton";
            this.fourSetAssocRadiobutton.Size = new System.Drawing.Size(249, 30);
            this.fourSetAssocRadiobutton.TabIndex = 116;
            this.fourSetAssocRadiobutton.TabStop = true;
            this.fourSetAssocRadiobutton.Text = "4-Way Set Associative";
            this.fourSetAssocRadiobutton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Silver;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(10, 311);
            this.closeButton.Margin = new System.Windows.Forms.Padding(1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 40);
            this.closeButton.TabIndex = 119;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(434, 311);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 40);
            this.saveButton.TabIndex = 120;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 121;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // entriesComboBox
            // 
            this.entriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesComboBox.FormattingEnabled = true;
            this.entriesComboBox.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.entriesComboBox.Location = new System.Drawing.Point(442, 119);
            this.entriesComboBox.Name = "entriesComboBox";
            this.entriesComboBox.Size = new System.Drawing.Size(121, 33);
            this.entriesComboBox.TabIndex = 122;
            this.entriesComboBox.Text = "8";
            this.entriesComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entriesComboBox_KeyPress);
            // 
            // lineSizeComboBox
            // 
            this.lineSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSizeComboBox.FormattingEnabled = true;
            this.lineSizeComboBox.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.lineSizeComboBox.Location = new System.Drawing.Point(442, 162);
            this.lineSizeComboBox.Name = "lineSizeComboBox";
            this.lineSizeComboBox.Size = new System.Drawing.Size(121, 33);
            this.lineSizeComboBox.TabIndex = 123;
            this.lineSizeComboBox.Text = "8";
            this.lineSizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lineSizeComboBox_KeyPress);
            // 
            // hitCyclesLabel
            // 
            this.hitCyclesLabel.AutoSize = true;
            this.hitCyclesLabel.BackColor = System.Drawing.Color.Black;
            this.hitCyclesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hitCyclesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitCyclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitCyclesLabel.Location = new System.Drawing.Point(37, 119);
            this.hitCyclesLabel.Name = "hitCyclesLabel";
            this.hitCyclesLabel.Size = new System.Drawing.Size(100, 27);
            this.hitCyclesLabel.TabIndex = 124;
            this.hitCyclesLabel.Text = "Cache Hit";
            // 
            // missCycleslabel
            // 
            this.missCycleslabel.AutoSize = true;
            this.missCycleslabel.BackColor = System.Drawing.Color.Black;
            this.missCycleslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missCycleslabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missCycleslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missCycleslabel.Location = new System.Drawing.Point(19, 157);
            this.missCycleslabel.Name = "missCycleslabel";
            this.missCycleslabel.Size = new System.Drawing.Size(118, 27);
            this.missCycleslabel.TabIndex = 125;
            this.missCycleslabel.Text = "Cache Miss";
            // 
            // cyclesLabel
            // 
            this.cyclesLabel.AutoSize = true;
            this.cyclesLabel.BackColor = System.Drawing.Color.Black;
            this.cyclesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cyclesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclesLabel.Location = new System.Drawing.Point(141, 89);
            this.cyclesLabel.Name = "cyclesLabel";
            this.cyclesLabel.Size = new System.Drawing.Size(74, 27);
            this.cyclesLabel.TabIndex = 126;
            this.cyclesLabel.Text = "Cycles";
            // 
            // configPanel
            // 
            this.configPanel.BackColor = System.Drawing.Color.Black;
            this.configPanel.Controls.Add(this.optionsLabel);
            this.configPanel.Controls.Add(this.cyclesLabel);
            this.configPanel.Controls.Add(this.lineSizeLabel);
            this.configPanel.Controls.Add(this.hitCyclesLabel);
            this.configPanel.Controls.Add(this.missCycleslabel);
            this.configPanel.Controls.Add(this.entriesLabel);
            this.configPanel.Controls.Add(this.fourSetAssocRadiobutton);
            this.configPanel.Controls.Add(this.twoSetAssocRadiobutton);
            this.configPanel.Controls.Add(this.lineSizeComboBox);
            this.configPanel.Controls.Add(this.missCyclesNumericUpDown);
            this.configPanel.Controls.Add(this.entriesComboBox);
            this.configPanel.Controls.Add(this.hitCyclesNumericUpDown);
            this.configPanel.Location = new System.Drawing.Point(-12, 72);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(607, 294);
            this.configPanel.TabIndex = 127;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BackColor = System.Drawing.Color.Black;
            this.optionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(461, 89);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(82, 27);
            this.optionsLabel.TabIndex = 130;
            this.optionsLabel.Text = "Options";
            // 
            // lineSizeLabel
            // 
            this.lineSizeLabel.AutoSize = true;
            this.lineSizeLabel.BackColor = System.Drawing.Color.Black;
            this.lineSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineSizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSizeLabel.Location = new System.Drawing.Point(278, 162);
            this.lineSizeLabel.Name = "lineSizeLabel";
            this.lineSizeLabel.Size = new System.Drawing.Size(158, 27);
            this.lineSizeLabel.TabIndex = 129;
            this.lineSizeLabel.Text = "Cache Line Size";
            // 
            // entriesLabel
            // 
            this.entriesLabel.AutoSize = true;
            this.entriesLabel.BackColor = System.Drawing.Color.Black;
            this.entriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entriesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesLabel.Location = new System.Drawing.Point(299, 119);
            this.entriesLabel.Name = "entriesLabel";
            this.entriesLabel.Size = new System.Drawing.Size(137, 27);
            this.entriesLabel.TabIndex = 128;
            this.entriesLabel.Text = "Cache Entries";
            // 
            // CacheConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cacheConfigLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.configPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CacheConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cache Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.hitCyclesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missCyclesNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configPanel.ResumeLayout(false);
            this.configPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cacheConfigLabel;
        private System.Windows.Forms.NumericUpDown hitCyclesNumericUpDown;
        private System.Windows.Forms.NumericUpDown missCyclesNumericUpDown;
        private System.Windows.Forms.RadioButton twoSetAssocRadiobutton;
        private System.Windows.Forms.RadioButton fourSetAssocRadiobutton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ComboBox entriesComboBox;
        private System.Windows.Forms.ComboBox lineSizeComboBox;
        private System.Windows.Forms.Label hitCyclesLabel;
        private System.Windows.Forms.Label missCycleslabel;
        private System.Windows.Forms.Label cyclesLabel;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.Label lineSizeLabel;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.Label optionsLabel;
    }
}