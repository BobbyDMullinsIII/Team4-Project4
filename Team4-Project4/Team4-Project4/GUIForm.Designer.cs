namespace Team4_Project4
{
    partial class GUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForm));
            this.MNAWLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyPanel = new System.Windows.Forms.Panel();
            this.saveAssemblyButton = new System.Windows.Forms.Button();
            this.clearAssemblyButton = new System.Windows.Forms.Button();
            this.loadAssemblyButton = new System.Windows.Forms.Button();
            this.assemblyTextBox = new System.Windows.Forms.TextBox();
            this.assemblyLabel = new System.Windows.Forms.Label();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.tabCache = new System.Windows.Forms.TabControl();
            this.memoryOutput = new System.Windows.Forms.TabPage();
            this.memOutputText = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cacheText = new System.Windows.Forms.TextBox();
            this.missesTextBox = new System.Windows.Forms.TextBox();
            this.hitsTextBox = new System.Windows.Forms.TextBox();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.memSlider = new System.Windows.Forms.TrackBar();
            this.executeLabel = new System.Windows.Forms.Label();
            this.startStaticButton = new System.Windows.Forms.Button();
            this.nextCycleButton = new System.Windows.Forms.Button();
            this.fetchTextBox = new System.Windows.Forms.TextBox();
            this.decodeTextBox = new System.Windows.Forms.TextBox();
            this.storeTextBox = new System.Windows.Forms.TextBox();
            this.executeTextBox = new System.Windows.Forms.TextBox();
            this.cyclesLabel = new System.Windows.Forms.Label();
            this.counterTextBox = new System.Windows.Forms.TextBox();
            this.structHTextBox = new System.Windows.Forms.TextBox();
            this.controlHTextBox = new System.Windows.Forms.TextBox();
            this.dataHTextBox = new System.Windows.Forms.TextBox();
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.wawTextBox = new System.Windows.Forms.TextBox();
            this.warTextBox = new System.Windows.Forms.TextBox();
            this.fetchStallTextbox = new System.Windows.Forms.TextBox();
            this.executeStallTextbox = new System.Windows.Forms.TextBox();
            this.decodeStallTextbox = new System.Windows.Forms.TextBox();
            this.storeStallTextbox = new System.Windows.Forms.TextBox();
            this.hazardsLabel = new System.Windows.Forms.Label();
            this.dependenciesLabel = new System.Windows.Forms.Label();
            this.stallsLabel = new System.Windows.Forms.Label();
            this.structuralHazardLabel = new System.Windows.Forms.Label();
            this.dataHazardLabel = new System.Windows.Forms.Label();
            this.controlHazardLabel = new System.Windows.Forms.Label();
            this.rawLabel = new System.Windows.Forms.Label();
            this.warLabel = new System.Windows.Forms.Label();
            this.wawLabel = new System.Windows.Forms.Label();
            this.fetchStallLabel = new System.Windows.Forms.Label();
            this.decodeStallLabel = new System.Windows.Forms.Label();
            this.executeStallLabel = new System.Windows.Forms.Label();
            this.storeStallLabel = new System.Windows.Forms.Label();
            this.registersLabel = new System.Windows.Forms.Label();
            this.r0TextBox = new System.Windows.Forms.TextBox();
            this.r1TextBox = new System.Windows.Forms.TextBox();
            this.r2TextBox = new System.Windows.Forms.TextBox();
            this.r3TextBox = new System.Windows.Forms.TextBox();
            this.r4TextBox = new System.Windows.Forms.TextBox();
            this.r5TextBox = new System.Windows.Forms.TextBox();
            this.r6TextBox = new System.Windows.Forms.TextBox();
            this.r7TextBox = new System.Windows.Forms.TextBox();
            this.r8TextBox = new System.Windows.Forms.TextBox();
            this.r9TextBox = new System.Windows.Forms.TextBox();
            this.r10TextBox = new System.Windows.Forms.TextBox();
            this.r11TextBox = new System.Windows.Forms.TextBox();
            this.f12TextBox = new System.Windows.Forms.TextBox();
            this.f13TextBox = new System.Windows.Forms.TextBox();
            this.f14TextBox = new System.Windows.Forms.TextBox();
            this.f15TextBox = new System.Windows.Forms.TextBox();
            this.r1Label = new System.Windows.Forms.Label();
            this.r2Label = new System.Windows.Forms.Label();
            this.r3Label = new System.Windows.Forms.Label();
            this.r4Label = new System.Windows.Forms.Label();
            this.r5Label = new System.Windows.Forms.Label();
            this.r6Label = new System.Windows.Forms.Label();
            this.r7Label = new System.Windows.Forms.Label();
            this.r8Label = new System.Windows.Forms.Label();
            this.r9Label = new System.Windows.Forms.Label();
            this.r10Label = new System.Windows.Forms.Label();
            this.r11Label = new System.Windows.Forms.Label();
            this.f12Label = new System.Windows.Forms.Label();
            this.f13Label = new System.Windows.Forms.Label();
            this.f14Label = new System.Windows.Forms.Label();
            this.f15Label = new System.Windows.Forms.Label();
            this.r0Label = new System.Windows.Forms.Label();
            this.issueLabel = new System.Windows.Forms.Label();
            this.writeLabel = new System.Windows.Forms.Label();
            this.commitLabel = new System.Windows.Forms.Label();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.commitTextBox = new System.Windows.Forms.TextBox();
            this.fetchLabel = new System.Windows.Forms.Label();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.dynamicIntExecuteTextBox = new System.Windows.Forms.TextBox();
            this.dynamicExecuteLabel = new System.Windows.Forms.Label();
            this.dynamicPipelineLabel = new System.Windows.Forms.Label();
            this.staticPipelineLabel = new System.Windows.Forms.Label();
            this.startDynamicButton = new System.Windows.Forms.Button();
            this.reorderBufferTextBox = new System.Windows.Forms.TextBox();
            this.memConflictTextBox = new System.Windows.Forms.TextBox();
            this.resStationTextBox = new System.Windows.Forms.TextBox();
            this.trueDependenceTextBox = new System.Windows.Forms.TextBox();
            this.delaysLabel = new System.Windows.Forms.Label();
            this.reorderBufferLabel = new System.Windows.Forms.Label();
            this.resStationLabel = new System.Windows.Forms.Label();
            this.memConflictLabel = new System.Windows.Forms.Label();
            this.trueDependenceLabel = new System.Windows.Forms.Label();
            this.memReadTextBox = new System.Windows.Forms.TextBox();
            this.memReadLabel = new System.Windows.Forms.Label();
            this.dynamicMemExecTBox = new System.Windows.Forms.TextBox();
            this.dynamicLSExecTBox = new System.Windows.Forms.TextBox();
            this.dynamicFExecTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simulationPanel = new System.Windows.Forms.Panel();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.assemblyPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.tabCache.SuspendLayout();
            this.memoryOutput.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memSlider)).BeginInit();
            this.simulationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNAWLabel
            // 
            this.MNAWLabel.AutoSize = true;
            this.MNAWLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MNAWLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MNAWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNAWLabel.Location = new System.Drawing.Point(1118, 78);
            this.MNAWLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MNAWLabel.Name = "MNAWLabel";
            this.MNAWLabel.Size = new System.Drawing.Size(1383, 71);
            this.MNAWLabel.TabIndex = 0;
            this.MNAWLabel.Text = "MNAW Instruction Set Pipeline Caching Simulation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(3836, 51);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.configToolStripMenuItem,
            this.runToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(80, 43);
            this.filesToolStripMenuItem.Text = "File";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
            this.instructionsToolStripMenuItem.Text = "Information";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assemblyPanel
            // 
            this.assemblyPanel.BackColor = System.Drawing.Color.Black;
            this.assemblyPanel.Controls.Add(this.saveAssemblyButton);
            this.assemblyPanel.Controls.Add(this.clearAssemblyButton);
            this.assemblyPanel.Controls.Add(this.loadAssemblyButton);
            this.assemblyPanel.Controls.Add(this.assemblyTextBox);
            this.assemblyPanel.Controls.Add(this.assemblyLabel);
            this.assemblyPanel.Location = new System.Drawing.Point(0, 176);
            this.assemblyPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.assemblyPanel.Name = "assemblyPanel";
            this.assemblyPanel.Size = new System.Drawing.Size(728, 1428);
            this.assemblyPanel.TabIndex = 2;
            // 
            // saveAssemblyButton
            // 
            this.saveAssemblyButton.BackColor = System.Drawing.Color.Silver;
            this.saveAssemblyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAssemblyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.saveAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.saveAssemblyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveAssemblyButton.Location = new System.Drawing.Point(548, 1269);
            this.saveAssemblyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveAssemblyButton.Name = "saveAssemblyButton";
            this.saveAssemblyButton.Size = new System.Drawing.Size(163, 89);
            this.saveAssemblyButton.TabIndex = 16;
            this.saveAssemblyButton.Text = "Save";
            this.saveAssemblyButton.UseVisualStyleBackColor = false;
            this.saveAssemblyButton.Click += new System.EventHandler(this.saveAssemblyButton_Click);
            // 
            // clearAssemblyButton
            // 
            this.clearAssemblyButton.BackColor = System.Drawing.Color.Silver;
            this.clearAssemblyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAssemblyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.clearAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.clearAssemblyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clearAssemblyButton.Location = new System.Drawing.Point(28, 1269);
            this.clearAssemblyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearAssemblyButton.Name = "clearAssemblyButton";
            this.clearAssemblyButton.Size = new System.Drawing.Size(327, 89);
            this.clearAssemblyButton.TabIndex = 15;
            this.clearAssemblyButton.Text = "Clear";
            this.clearAssemblyButton.UseVisualStyleBackColor = false;
            this.clearAssemblyButton.Click += new System.EventHandler(this.clearAssemblyButton_Click);
            // 
            // loadAssemblyButton
            // 
            this.loadAssemblyButton.BackColor = System.Drawing.Color.Silver;
            this.loadAssemblyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadAssemblyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loadAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.loadAssemblyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loadAssemblyButton.Location = new System.Drawing.Point(380, 1269);
            this.loadAssemblyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadAssemblyButton.Name = "loadAssemblyButton";
            this.loadAssemblyButton.Size = new System.Drawing.Size(163, 89);
            this.loadAssemblyButton.TabIndex = 14;
            this.loadAssemblyButton.Text = "Load";
            this.loadAssemblyButton.UseVisualStyleBackColor = false;
            this.loadAssemblyButton.Click += new System.EventHandler(this.loadAssemblyButton_Click);
            // 
            // assemblyTextBox
            // 
            this.assemblyTextBox.BackColor = System.Drawing.Color.White;
            this.assemblyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblyTextBox.ForeColor = System.Drawing.Color.Black;
            this.assemblyTextBox.Location = new System.Drawing.Point(28, 83);
            this.assemblyTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.assemblyTextBox.Multiline = true;
            this.assemblyTextBox.Name = "assemblyTextBox";
            this.assemblyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.assemblyTextBox.Size = new System.Drawing.Size(678, 1171);
            this.assemblyTextBox.TabIndex = 6;
            this.assemblyTextBox.TextChanged += new System.EventHandler(this.assemblyTextBox_TextChanged);
            // 
            // assemblyLabel
            // 
            this.assemblyLabel.AutoSize = true;
            this.assemblyLabel.BackColor = System.Drawing.Color.Black;
            this.assemblyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assemblyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblyLabel.Location = new System.Drawing.Point(40, 2);
            this.assemblyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.assemblyLabel.Name = "assemblyLabel";
            this.assemblyLabel.Size = new System.Drawing.Size(615, 71);
            this.assemblyLabel.TabIndex = 5;
            this.assemblyLabel.Text = "Assembly Instructions";
            // 
            // outputPanel
            // 
            this.outputPanel.BackColor = System.Drawing.Color.Black;
            this.outputPanel.Controls.Add(this.tabCache);
            this.outputPanel.Controls.Add(this.missesTextBox);
            this.outputPanel.Controls.Add(this.hitsTextBox);
            this.outputPanel.Controls.Add(this.hitsLabel);
            this.outputPanel.Controls.Add(this.missesLabel);
            this.outputPanel.Location = new System.Drawing.Point(2968, 178);
            this.outputPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(887, 1425);
            this.outputPanel.TabIndex = 17;
            // 
            // tabCache
            // 
            this.tabCache.Controls.Add(this.memoryOutput);
            this.tabCache.Controls.Add(this.tabPage1);
            this.tabCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCache.Location = new System.Drawing.Point(7, 7);
            this.tabCache.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabCache.Name = "tabCache";
            this.tabCache.SelectedIndex = 0;
            this.tabCache.Size = new System.Drawing.Size(861, 1330);
            this.tabCache.TabIndex = 18;
            // 
            // memoryOutput
            // 
            this.memoryOutput.Controls.Add(this.memOutputText);
            this.memoryOutput.Location = new System.Drawing.Point(10, 54);
            this.memoryOutput.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memoryOutput.Name = "memoryOutput";
            this.memoryOutput.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memoryOutput.Size = new System.Drawing.Size(841, 1266);
            this.memoryOutput.TabIndex = 1;
            this.memoryOutput.Text = " Memory Output";
            this.memoryOutput.UseVisualStyleBackColor = true;
            // 
            // memOutputText
            // 
            this.memOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memOutputText.Location = new System.Drawing.Point(0, 0);
            this.memOutputText.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memOutputText.MaxLength = 999999999;
            this.memOutputText.Multiline = true;
            this.memOutputText.Name = "memOutputText";
            this.memOutputText.ReadOnly = true;
            this.memOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.memOutputText.Size = new System.Drawing.Size(837, 1260);
            this.memOutputText.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cacheText);
            this.tabPage1.Location = new System.Drawing.Point(10, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage1.Size = new System.Drawing.Size(841, 1266);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cache";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cacheText
            // 
            this.cacheText.Location = new System.Drawing.Point(0, 0);
            this.cacheText.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cacheText.Multiline = true;
            this.cacheText.Name = "cacheText";
            this.cacheText.ReadOnly = true;
            this.cacheText.Size = new System.Drawing.Size(837, 1260);
            this.cacheText.TabIndex = 0;
            // 
            // missesTextBox
            // 
            this.missesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missesTextBox.Location = new System.Drawing.Point(511, 1347);
            this.missesTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.missesTextBox.Name = "missesTextBox";
            this.missesTextBox.ReadOnly = true;
            this.missesTextBox.Size = new System.Drawing.Size(205, 48);
            this.missesTextBox.TabIndex = 132;
            this.missesTextBox.Text = "0";
            // 
            // hitsTextBox
            // 
            this.hitsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitsTextBox.Location = new System.Drawing.Point(121, 1347);
            this.hitsTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hitsTextBox.Name = "hitsTextBox";
            this.hitsTextBox.ReadOnly = true;
            this.hitsTextBox.Size = new System.Drawing.Size(205, 48);
            this.hitsTextBox.TabIndex = 131;
            this.hitsTextBox.Text = "0";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hitsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitsLabel.Location = new System.Drawing.Point(16, 1347);
            this.hitsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(81, 42);
            this.hitsLabel.TabIndex = 129;
            this.hitsLabel.Text = "Hits";
            // 
            // missesLabel
            // 
            this.missesLabel.AutoSize = true;
            this.missesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missesLabel.Location = new System.Drawing.Point(357, 1347);
            this.missesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(131, 42);
            this.missesLabel.TabIndex = 130;
            this.missesLabel.Text = "Misses";
            // 
            // memSlider
            // 
            this.memSlider.Location = new System.Drawing.Point(0, 1597);
            this.memSlider.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memSlider.Maximum = 64;
            this.memSlider.Minimum = 1;
            this.memSlider.Name = "memSlider";
            this.memSlider.Size = new System.Drawing.Size(3836, 101);
            this.memSlider.TabIndex = 18;
            this.memSlider.Value = 1;
            this.memSlider.Scroll += new System.EventHandler(this.memSlider_Scroll);
            // 
            // executeLabel
            // 
            this.executeLabel.AutoSize = true;
            this.executeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.executeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeLabel.Location = new System.Drawing.Point(625, 861);
            this.executeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.executeLabel.Name = "executeLabel";
            this.executeLabel.Size = new System.Drawing.Size(188, 54);
            this.executeLabel.TabIndex = 6;
            this.executeLabel.Text = "Execute";
            // 
            // startStaticButton
            // 
            this.startStaticButton.BackColor = System.Drawing.Color.Silver;
            this.startStaticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startStaticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.startStaticButton.ForeColor = System.Drawing.Color.Black;
            this.startStaticButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startStaticButton.Location = new System.Drawing.Point(28, 1002);
            this.startStaticButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startStaticButton.Name = "startStaticButton";
            this.startStaticButton.Size = new System.Drawing.Size(513, 89);
            this.startStaticButton.TabIndex = 17;
            this.startStaticButton.Text = "Start Static Simulation";
            this.startStaticButton.UseVisualStyleBackColor = false;
            this.startStaticButton.Click += new System.EventHandler(this.startStaticButton_Click);
            // 
            // nextCycleButton
            // 
            this.nextCycleButton.BackColor = System.Drawing.Color.Silver;
            this.nextCycleButton.Enabled = false;
            this.nextCycleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextCycleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nextCycleButton.ForeColor = System.Drawing.Color.Black;
            this.nextCycleButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nextCycleButton.Location = new System.Drawing.Point(1750, 1243);
            this.nextCycleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextCycleButton.Name = "nextCycleButton";
            this.nextCycleButton.Size = new System.Drawing.Size(436, 152);
            this.nextCycleButton.TabIndex = 18;
            this.nextCycleButton.Text = "Next Cycle";
            this.nextCycleButton.UseVisualStyleBackColor = false;
            this.nextCycleButton.Click += new System.EventHandler(this.nextCycleButton_Click);
            // 
            // fetchTextBox
            // 
            this.fetchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchTextBox.Location = new System.Drawing.Point(28, 716);
            this.fetchTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.fetchTextBox.Name = "fetchTextBox";
            this.fetchTextBox.ReadOnly = true;
            this.fetchTextBox.Size = new System.Drawing.Size(578, 48);
            this.fetchTextBox.TabIndex = 19;
            // 
            // decodeTextBox
            // 
            this.decodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeTextBox.Location = new System.Drawing.Point(28, 792);
            this.decodeTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.decodeTextBox.Name = "decodeTextBox";
            this.decodeTextBox.ReadOnly = true;
            this.decodeTextBox.Size = new System.Drawing.Size(578, 48);
            this.decodeTextBox.TabIndex = 32;
            // 
            // storeTextBox
            // 
            this.storeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeTextBox.Location = new System.Drawing.Point(28, 935);
            this.storeTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.storeTextBox.Name = "storeTextBox";
            this.storeTextBox.ReadOnly = true;
            this.storeTextBox.Size = new System.Drawing.Size(578, 48);
            this.storeTextBox.TabIndex = 33;
            // 
            // executeTextBox
            // 
            this.executeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeTextBox.Location = new System.Drawing.Point(28, 863);
            this.executeTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.executeTextBox.Name = "executeTextBox";
            this.executeTextBox.ReadOnly = true;
            this.executeTextBox.Size = new System.Drawing.Size(578, 48);
            this.executeTextBox.TabIndex = 34;
            // 
            // cyclesLabel
            // 
            this.cyclesLabel.AutoSize = true;
            this.cyclesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cyclesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclesLabel.Location = new System.Drawing.Point(1402, 1176);
            this.cyclesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.cyclesLabel.Name = "cyclesLabel";
            this.cyclesLabel.Size = new System.Drawing.Size(311, 54);
            this.cyclesLabel.TabIndex = 36;
            this.cyclesLabel.Text = "Cycle Counter";
            // 
            // counterTextBox
            // 
            this.counterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterTextBox.Location = new System.Drawing.Point(1388, 1243);
            this.counterTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.counterTextBox.Name = "counterTextBox";
            this.counterTextBox.ReadOnly = true;
            this.counterTextBox.Size = new System.Drawing.Size(345, 143);
            this.counterTextBox.TabIndex = 37;
            this.counterTextBox.Text = "0";
            this.counterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // structHTextBox
            // 
            this.structHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structHTextBox.Location = new System.Drawing.Point(1951, 386);
            this.structHTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.structHTextBox.Name = "structHTextBox";
            this.structHTextBox.ReadOnly = true;
            this.structHTextBox.Size = new System.Drawing.Size(228, 48);
            this.structHTextBox.TabIndex = 38;
            this.structHTextBox.Text = "0";
            // 
            // controlHTextBox
            // 
            this.controlHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlHTextBox.Location = new System.Drawing.Point(1951, 502);
            this.controlHTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.controlHTextBox.Name = "controlHTextBox";
            this.controlHTextBox.ReadOnly = true;
            this.controlHTextBox.Size = new System.Drawing.Size(228, 48);
            this.controlHTextBox.TabIndex = 39;
            this.controlHTextBox.Text = "0";
            // 
            // dataHTextBox
            // 
            this.dataHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataHTextBox.Location = new System.Drawing.Point(1951, 444);
            this.dataHTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataHTextBox.Name = "dataHTextBox";
            this.dataHTextBox.ReadOnly = true;
            this.dataHTextBox.Size = new System.Drawing.Size(228, 48);
            this.dataHTextBox.TabIndex = 40;
            this.dataHTextBox.Text = "0";
            // 
            // rawTextBox
            // 
            this.rawTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawTextBox.Location = new System.Drawing.Point(1951, 640);
            this.rawTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.ReadOnly = true;
            this.rawTextBox.Size = new System.Drawing.Size(228, 48);
            this.rawTextBox.TabIndex = 41;
            this.rawTextBox.Text = "0";
            // 
            // wawTextBox
            // 
            this.wawTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wawTextBox.Location = new System.Drawing.Point(1951, 756);
            this.wawTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.wawTextBox.Name = "wawTextBox";
            this.wawTextBox.ReadOnly = true;
            this.wawTextBox.Size = new System.Drawing.Size(228, 48);
            this.wawTextBox.TabIndex = 42;
            this.wawTextBox.Text = "0";
            // 
            // warTextBox
            // 
            this.warTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warTextBox.Location = new System.Drawing.Point(1951, 698);
            this.warTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.warTextBox.Name = "warTextBox";
            this.warTextBox.ReadOnly = true;
            this.warTextBox.Size = new System.Drawing.Size(228, 48);
            this.warTextBox.TabIndex = 43;
            this.warTextBox.Text = "0";
            // 
            // fetchStallTextbox
            // 
            this.fetchStallTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchStallTextbox.Location = new System.Drawing.Point(1951, 890);
            this.fetchStallTextbox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.fetchStallTextbox.Name = "fetchStallTextbox";
            this.fetchStallTextbox.ReadOnly = true;
            this.fetchStallTextbox.Size = new System.Drawing.Size(228, 48);
            this.fetchStallTextbox.TabIndex = 44;
            this.fetchStallTextbox.Text = "0";
            // 
            // executeStallTextbox
            // 
            this.executeStallTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeStallTextbox.Location = new System.Drawing.Point(1951, 1006);
            this.executeStallTextbox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.executeStallTextbox.Name = "executeStallTextbox";
            this.executeStallTextbox.ReadOnly = true;
            this.executeStallTextbox.Size = new System.Drawing.Size(228, 48);
            this.executeStallTextbox.TabIndex = 45;
            this.executeStallTextbox.Text = "0";
            // 
            // decodeStallTextbox
            // 
            this.decodeStallTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeStallTextbox.Location = new System.Drawing.Point(1951, 948);
            this.decodeStallTextbox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.decodeStallTextbox.Name = "decodeStallTextbox";
            this.decodeStallTextbox.ReadOnly = true;
            this.decodeStallTextbox.Size = new System.Drawing.Size(228, 48);
            this.decodeStallTextbox.TabIndex = 46;
            this.decodeStallTextbox.Text = "0";
            // 
            // storeStallTextbox
            // 
            this.storeStallTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeStallTextbox.Location = new System.Drawing.Point(1951, 1064);
            this.storeStallTextbox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.storeStallTextbox.Name = "storeStallTextbox";
            this.storeStallTextbox.ReadOnly = true;
            this.storeStallTextbox.Size = new System.Drawing.Size(228, 48);
            this.storeStallTextbox.TabIndex = 47;
            this.storeStallTextbox.Text = "0";
            // 
            // hazardsLabel
            // 
            this.hazardsLabel.AutoSize = true;
            this.hazardsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hazardsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hazardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hazardsLabel.Location = new System.Drawing.Point(1981, 319);
            this.hazardsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.hazardsLabel.Name = "hazardsLabel";
            this.hazardsLabel.Size = new System.Drawing.Size(193, 54);
            this.hazardsLabel.TabIndex = 48;
            this.hazardsLabel.Text = "Hazards";
            // 
            // dependenciesLabel
            // 
            this.dependenciesLabel.AutoSize = true;
            this.dependenciesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dependenciesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dependenciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependenciesLabel.Location = new System.Drawing.Point(1857, 573);
            this.dependenciesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dependenciesLabel.Name = "dependenciesLabel";
            this.dependenciesLabel.Size = new System.Drawing.Size(313, 54);
            this.dependenciesLabel.TabIndex = 49;
            this.dependenciesLabel.Text = "Dependencies";
            // 
            // stallsLabel
            // 
            this.stallsLabel.AutoSize = true;
            this.stallsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stallsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stallsLabel.Location = new System.Drawing.Point(2039, 830);
            this.stallsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.stallsLabel.Name = "stallsLabel";
            this.stallsLabel.Size = new System.Drawing.Size(135, 54);
            this.stallsLabel.TabIndex = 50;
            this.stallsLabel.Text = "Stalls";
            // 
            // structuralHazardLabel
            // 
            this.structuralHazardLabel.AutoSize = true;
            this.structuralHazardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.structuralHazardLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.structuralHazardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structuralHazardLabel.Location = new System.Drawing.Point(1750, 386);
            this.structuralHazardLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.structuralHazardLabel.Name = "structuralHazardLabel";
            this.structuralHazardLabel.Size = new System.Drawing.Size(173, 42);
            this.structuralHazardLabel.TabIndex = 51;
            this.structuralHazardLabel.Text = "Structural";
            // 
            // dataHazardLabel
            // 
            this.dataHazardLabel.AutoSize = true;
            this.dataHazardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataHazardLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataHazardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataHazardLabel.Location = new System.Drawing.Point(1829, 444);
            this.dataHazardLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dataHazardLabel.Name = "dataHazardLabel";
            this.dataHazardLabel.Size = new System.Drawing.Size(95, 42);
            this.dataHazardLabel.TabIndex = 52;
            this.dataHazardLabel.Text = "Data";
            // 
            // controlHazardLabel
            // 
            this.controlHazardLabel.AutoSize = true;
            this.controlHazardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlHazardLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlHazardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlHazardLabel.Location = new System.Drawing.Point(1792, 502);
            this.controlHazardLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.controlHazardLabel.Name = "controlHazardLabel";
            this.controlHazardLabel.Size = new System.Drawing.Size(135, 42);
            this.controlHazardLabel.TabIndex = 53;
            this.controlHazardLabel.Text = "Control";
            // 
            // rawLabel
            // 
            this.rawLabel.AutoSize = true;
            this.rawLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawLabel.Location = new System.Drawing.Point(1822, 640);
            this.rawLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.rawLabel.Name = "rawLabel";
            this.rawLabel.Size = new System.Drawing.Size(103, 42);
            this.rawLabel.TabIndex = 54;
            this.rawLabel.Text = "RAW";
            // 
            // warLabel
            // 
            this.warLabel.AutoSize = true;
            this.warLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warLabel.Location = new System.Drawing.Point(1822, 698);
            this.warLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.warLabel.Name = "warLabel";
            this.warLabel.Size = new System.Drawing.Size(103, 42);
            this.warLabel.TabIndex = 55;
            this.warLabel.Text = "WAR";
            // 
            // wawLabel
            // 
            this.wawLabel.AutoSize = true;
            this.wawLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wawLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wawLabel.Location = new System.Drawing.Point(1815, 756);
            this.wawLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.wawLabel.Name = "wawLabel";
            this.wawLabel.Size = new System.Drawing.Size(111, 42);
            this.wawLabel.TabIndex = 56;
            this.wawLabel.Text = "WAW";
            // 
            // fetchStallLabel
            // 
            this.fetchStallLabel.AutoSize = true;
            this.fetchStallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fetchStallLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchStallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchStallLabel.Location = new System.Drawing.Point(1815, 890);
            this.fetchStallLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fetchStallLabel.Name = "fetchStallLabel";
            this.fetchStallLabel.Size = new System.Drawing.Size(109, 42);
            this.fetchStallLabel.TabIndex = 57;
            this.fetchStallLabel.Text = "Fetch";
            // 
            // decodeStallLabel
            // 
            this.decodeStallLabel.AutoSize = true;
            this.decodeStallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decodeStallLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeStallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeStallLabel.Location = new System.Drawing.Point(1780, 948);
            this.decodeStallLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.decodeStallLabel.Name = "decodeStallLabel";
            this.decodeStallLabel.Size = new System.Drawing.Size(143, 42);
            this.decodeStallLabel.TabIndex = 58;
            this.decodeStallLabel.Text = "Decode";
            // 
            // executeStallLabel
            // 
            this.executeStallLabel.AutoSize = true;
            this.executeStallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.executeStallLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeStallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeStallLabel.Location = new System.Drawing.Point(1776, 1006);
            this.executeStallLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.executeStallLabel.Name = "executeStallLabel";
            this.executeStallLabel.Size = new System.Drawing.Size(149, 42);
            this.executeStallLabel.TabIndex = 59;
            this.executeStallLabel.Text = "Execute";
            // 
            // storeStallLabel
            // 
            this.storeStallLabel.AutoSize = true;
            this.storeStallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storeStallLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeStallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeStallLabel.Location = new System.Drawing.Point(1820, 1064);
            this.storeStallLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.storeStallLabel.Name = "storeStallLabel";
            this.storeStallLabel.Size = new System.Drawing.Size(105, 42);
            this.storeStallLabel.TabIndex = 60;
            this.storeStallLabel.Text = "Store";
            // 
            // registersLabel
            // 
            this.registersLabel.AutoSize = true;
            this.registersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registersLabel.Location = new System.Drawing.Point(565, 1102);
            this.registersLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.registersLabel.Name = "registersLabel";
            this.registersLabel.Size = new System.Drawing.Size(216, 54);
            this.registersLabel.TabIndex = 61;
            this.registersLabel.Text = "Registers";
            // 
            // r0TextBox
            // 
            this.r0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r0TextBox.Location = new System.Drawing.Point(275, 1171);
            this.r0TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r0TextBox.Name = "r0TextBox";
            this.r0TextBox.ReadOnly = true;
            this.r0TextBox.Size = new System.Drawing.Size(135, 48);
            this.r0TextBox.TabIndex = 62;
            this.r0TextBox.Text = "0";
            // 
            // r1TextBox
            // 
            this.r1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1TextBox.Location = new System.Drawing.Point(275, 1229);
            this.r1TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r1TextBox.Name = "r1TextBox";
            this.r1TextBox.ReadOnly = true;
            this.r1TextBox.Size = new System.Drawing.Size(135, 48);
            this.r1TextBox.TabIndex = 63;
            this.r1TextBox.Text = "0";
            // 
            // r2TextBox
            // 
            this.r2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2TextBox.Location = new System.Drawing.Point(275, 1287);
            this.r2TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r2TextBox.Name = "r2TextBox";
            this.r2TextBox.ReadOnly = true;
            this.r2TextBox.Size = new System.Drawing.Size(135, 48);
            this.r2TextBox.TabIndex = 64;
            this.r2TextBox.Text = "0";
            // 
            // r3TextBox
            // 
            this.r3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3TextBox.Location = new System.Drawing.Point(275, 1345);
            this.r3TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r3TextBox.Name = "r3TextBox";
            this.r3TextBox.ReadOnly = true;
            this.r3TextBox.Size = new System.Drawing.Size(135, 48);
            this.r3TextBox.TabIndex = 65;
            this.r3TextBox.Text = "0";
            // 
            // r4TextBox
            // 
            this.r4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4TextBox.Location = new System.Drawing.Point(537, 1169);
            this.r4TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r4TextBox.Name = "r4TextBox";
            this.r4TextBox.ReadOnly = true;
            this.r4TextBox.Size = new System.Drawing.Size(135, 48);
            this.r4TextBox.TabIndex = 66;
            this.r4TextBox.Text = "0";
            // 
            // r5TextBox
            // 
            this.r5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r5TextBox.Location = new System.Drawing.Point(537, 1227);
            this.r5TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r5TextBox.Name = "r5TextBox";
            this.r5TextBox.ReadOnly = true;
            this.r5TextBox.Size = new System.Drawing.Size(135, 48);
            this.r5TextBox.TabIndex = 67;
            this.r5TextBox.Text = "0";
            // 
            // r6TextBox
            // 
            this.r6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r6TextBox.Location = new System.Drawing.Point(537, 1285);
            this.r6TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r6TextBox.Name = "r6TextBox";
            this.r6TextBox.ReadOnly = true;
            this.r6TextBox.Size = new System.Drawing.Size(135, 48);
            this.r6TextBox.TabIndex = 68;
            this.r6TextBox.Text = "0";
            // 
            // r7TextBox
            // 
            this.r7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r7TextBox.Location = new System.Drawing.Point(537, 1343);
            this.r7TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r7TextBox.Name = "r7TextBox";
            this.r7TextBox.ReadOnly = true;
            this.r7TextBox.Size = new System.Drawing.Size(135, 48);
            this.r7TextBox.TabIndex = 69;
            this.r7TextBox.Text = "0";
            // 
            // r8TextBox
            // 
            this.r8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r8TextBox.Location = new System.Drawing.Point(800, 1169);
            this.r8TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r8TextBox.Name = "r8TextBox";
            this.r8TextBox.ReadOnly = true;
            this.r8TextBox.Size = new System.Drawing.Size(135, 48);
            this.r8TextBox.TabIndex = 70;
            this.r8TextBox.Text = "0";
            // 
            // r9TextBox
            // 
            this.r9TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r9TextBox.Location = new System.Drawing.Point(800, 1227);
            this.r9TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r9TextBox.Name = "r9TextBox";
            this.r9TextBox.ReadOnly = true;
            this.r9TextBox.Size = new System.Drawing.Size(135, 48);
            this.r9TextBox.TabIndex = 71;
            this.r9TextBox.Text = "0";
            // 
            // r10TextBox
            // 
            this.r10TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r10TextBox.Location = new System.Drawing.Point(800, 1285);
            this.r10TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r10TextBox.Name = "r10TextBox";
            this.r10TextBox.ReadOnly = true;
            this.r10TextBox.Size = new System.Drawing.Size(135, 48);
            this.r10TextBox.TabIndex = 72;
            this.r10TextBox.Text = "0";
            // 
            // r11TextBox
            // 
            this.r11TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r11TextBox.Location = new System.Drawing.Point(800, 1343);
            this.r11TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.r11TextBox.Name = "r11TextBox";
            this.r11TextBox.ReadOnly = true;
            this.r11TextBox.Size = new System.Drawing.Size(135, 48);
            this.r11TextBox.TabIndex = 73;
            this.r11TextBox.Text = "0";
            // 
            // f12TextBox
            // 
            this.f12TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f12TextBox.Location = new System.Drawing.Point(1059, 1169);
            this.f12TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.f12TextBox.Name = "f12TextBox";
            this.f12TextBox.ReadOnly = true;
            this.f12TextBox.Size = new System.Drawing.Size(228, 48);
            this.f12TextBox.TabIndex = 74;
            this.f12TextBox.Text = "0.0";
            // 
            // f13TextBox
            // 
            this.f13TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f13TextBox.Location = new System.Drawing.Point(1059, 1227);
            this.f13TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.f13TextBox.Name = "f13TextBox";
            this.f13TextBox.ReadOnly = true;
            this.f13TextBox.Size = new System.Drawing.Size(228, 48);
            this.f13TextBox.TabIndex = 75;
            this.f13TextBox.Text = "0.0";
            // 
            // f14TextBox
            // 
            this.f14TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f14TextBox.Location = new System.Drawing.Point(1059, 1285);
            this.f14TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.f14TextBox.Name = "f14TextBox";
            this.f14TextBox.ReadOnly = true;
            this.f14TextBox.Size = new System.Drawing.Size(228, 48);
            this.f14TextBox.TabIndex = 76;
            this.f14TextBox.Text = "0.0";
            // 
            // f15TextBox
            // 
            this.f15TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f15TextBox.Location = new System.Drawing.Point(1059, 1343);
            this.f15TextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.f15TextBox.Name = "f15TextBox";
            this.f15TextBox.ReadOnly = true;
            this.f15TextBox.Size = new System.Drawing.Size(228, 48);
            this.f15TextBox.TabIndex = 77;
            this.f15TextBox.Text = "0.0";
            // 
            // r1Label
            // 
            this.r1Label.AutoSize = true;
            this.r1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1Label.Location = new System.Drawing.Point(47, 1236);
            this.r1Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r1Label.Name = "r1Label";
            this.r1Label.Size = new System.Drawing.Size(201, 42);
            this.r1Label.TabIndex = 78;
            this.r1Label.Text = "R1 (Flag Z)";
            // 
            // r2Label
            // 
            this.r2Label.AutoSize = true;
            this.r2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r2Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2Label.Location = new System.Drawing.Point(47, 1292);
            this.r2Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r2Label.Name = "r2Label";
            this.r2Label.Size = new System.Drawing.Size(205, 42);
            this.r2Label.TabIndex = 79;
            this.r2Label.Text = "R2 (Flag C)";
            // 
            // r3Label
            // 
            this.r3Label.AutoSize = true;
            this.r3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r3Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3Label.Location = new System.Drawing.Point(49, 1350);
            this.r3Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r3Label.Name = "r3Label";
            this.r3Label.Size = new System.Drawing.Size(203, 42);
            this.r3Label.TabIndex = 80;
            this.r3Label.Text = "R3 (Flag S)";
            // 
            // r4Label
            // 
            this.r4Label.AutoSize = true;
            this.r4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r4Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4Label.Location = new System.Drawing.Point(448, 1173);
            this.r4Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r4Label.Name = "r4Label";
            this.r4Label.Size = new System.Drawing.Size(65, 42);
            this.r4Label.TabIndex = 81;
            this.r4Label.Text = "R4";
            // 
            // r5Label
            // 
            this.r5Label.AutoSize = true;
            this.r5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r5Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r5Label.Location = new System.Drawing.Point(448, 1231);
            this.r5Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r5Label.Name = "r5Label";
            this.r5Label.Size = new System.Drawing.Size(65, 42);
            this.r5Label.TabIndex = 82;
            this.r5Label.Text = "R5";
            // 
            // r6Label
            // 
            this.r6Label.AutoSize = true;
            this.r6Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r6Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r6Label.Location = new System.Drawing.Point(448, 1289);
            this.r6Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r6Label.Name = "r6Label";
            this.r6Label.Size = new System.Drawing.Size(65, 42);
            this.r6Label.TabIndex = 83;
            this.r6Label.Text = "R6";
            // 
            // r7Label
            // 
            this.r7Label.AutoSize = true;
            this.r7Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r7Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r7Label.Location = new System.Drawing.Point(448, 1350);
            this.r7Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r7Label.Name = "r7Label";
            this.r7Label.Size = new System.Drawing.Size(65, 42);
            this.r7Label.TabIndex = 84;
            this.r7Label.Text = "R7";
            // 
            // r8Label
            // 
            this.r8Label.AutoSize = true;
            this.r8Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r8Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r8Label.Location = new System.Drawing.Point(712, 1173);
            this.r8Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r8Label.Name = "r8Label";
            this.r8Label.Size = new System.Drawing.Size(65, 42);
            this.r8Label.TabIndex = 85;
            this.r8Label.Text = "R8";
            // 
            // r9Label
            // 
            this.r9Label.AutoSize = true;
            this.r9Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r9Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r9Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r9Label.Location = new System.Drawing.Point(712, 1231);
            this.r9Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r9Label.Name = "r9Label";
            this.r9Label.Size = new System.Drawing.Size(65, 42);
            this.r9Label.TabIndex = 86;
            this.r9Label.Text = "R9";
            // 
            // r10Label
            // 
            this.r10Label.AutoSize = true;
            this.r10Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r10Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r10Label.Location = new System.Drawing.Point(691, 1289);
            this.r10Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r10Label.Name = "r10Label";
            this.r10Label.Size = new System.Drawing.Size(85, 42);
            this.r10Label.TabIndex = 87;
            this.r10Label.Text = "R10";
            // 
            // r11Label
            // 
            this.r11Label.AutoSize = true;
            this.r11Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r11Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r11Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r11Label.Location = new System.Drawing.Point(691, 1347);
            this.r11Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r11Label.Name = "r11Label";
            this.r11Label.Size = new System.Drawing.Size(85, 42);
            this.r11Label.TabIndex = 88;
            this.r11Label.Text = "R11";
            // 
            // f12Label
            // 
            this.f12Label.AutoSize = true;
            this.f12Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f12Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f12Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f12Label.Location = new System.Drawing.Point(954, 1176);
            this.f12Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.f12Label.Name = "f12Label";
            this.f12Label.Size = new System.Drawing.Size(81, 42);
            this.f12Label.TabIndex = 89;
            this.f12Label.Text = "F12";
            // 
            // f13Label
            // 
            this.f13Label.AutoSize = true;
            this.f13Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f13Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f13Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f13Label.Location = new System.Drawing.Point(954, 1234);
            this.f13Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.f13Label.Name = "f13Label";
            this.f13Label.Size = new System.Drawing.Size(81, 42);
            this.f13Label.TabIndex = 90;
            this.f13Label.Text = "F13";
            // 
            // f14Label
            // 
            this.f14Label.AutoSize = true;
            this.f14Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f14Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f14Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f14Label.Location = new System.Drawing.Point(954, 1292);
            this.f14Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.f14Label.Name = "f14Label";
            this.f14Label.Size = new System.Drawing.Size(81, 42);
            this.f14Label.TabIndex = 91;
            this.f14Label.Text = "F14";
            // 
            // f15Label
            // 
            this.f15Label.AutoSize = true;
            this.f15Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f15Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f15Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f15Label.Location = new System.Drawing.Point(954, 1350);
            this.f15Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.f15Label.Name = "f15Label";
            this.f15Label.Size = new System.Drawing.Size(81, 42);
            this.f15Label.TabIndex = 92;
            this.f15Label.Text = "F15";
            // 
            // r0Label
            // 
            this.r0Label.AutoSize = true;
            this.r0Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r0Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r0Label.Location = new System.Drawing.Point(105, 1178);
            this.r0Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.r0Label.Name = "r0Label";
            this.r0Label.Size = new System.Drawing.Size(149, 42);
            this.r0Label.TabIndex = 94;
            this.r0Label.Text = "R0 (PC)";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLabel.Location = new System.Drawing.Point(625, 83);
            this.issueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(133, 54);
            this.issueLabel.TabIndex = 95;
            this.issueLabel.Text = "Issue";
            // 
            // writeLabel
            // 
            this.writeLabel.AutoSize = true;
            this.writeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.writeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeLabel.Location = new System.Drawing.Point(625, 375);
            this.writeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.writeLabel.Name = "writeLabel";
            this.writeLabel.Size = new System.Drawing.Size(129, 54);
            this.writeLabel.TabIndex = 97;
            this.writeLabel.Text = "Write";
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitLabel.Location = new System.Drawing.Point(628, 446);
            this.commitLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(179, 54);
            this.commitLabel.TabIndex = 98;
            this.commitLabel.Text = "Commit";
            // 
            // issueTextBox
            // 
            this.issueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueTextBox.Location = new System.Drawing.Point(28, 85);
            this.issueTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.ReadOnly = true;
            this.issueTextBox.Size = new System.Drawing.Size(578, 48);
            this.issueTextBox.TabIndex = 99;
            // 
            // writeTextBox
            // 
            this.writeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeTextBox.Location = new System.Drawing.Point(28, 375);
            this.writeTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.ReadOnly = true;
            this.writeTextBox.Size = new System.Drawing.Size(578, 48);
            this.writeTextBox.TabIndex = 101;
            // 
            // commitTextBox
            // 
            this.commitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitTextBox.Location = new System.Drawing.Point(28, 446);
            this.commitTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.commitTextBox.Name = "commitTextBox";
            this.commitTextBox.ReadOnly = true;
            this.commitTextBox.Size = new System.Drawing.Size(578, 48);
            this.commitTextBox.TabIndex = 102;
            // 
            // fetchLabel
            // 
            this.fetchLabel.AutoSize = true;
            this.fetchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fetchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchLabel.Location = new System.Drawing.Point(625, 716);
            this.fetchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fetchLabel.Name = "fetchLabel";
            this.fetchLabel.Size = new System.Drawing.Size(137, 54);
            this.fetchLabel.TabIndex = 103;
            this.fetchLabel.Text = "Fetch";
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeLabel.Location = new System.Drawing.Point(625, 790);
            this.decodeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(180, 54);
            this.decodeLabel.TabIndex = 104;
            this.decodeLabel.Text = "Decode";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(625, 932);
            this.storeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(265, 54);
            this.storeLabel.TabIndex = 105;
            this.storeLabel.Text = "Store/Finish";
            // 
            // dynamicIntExecuteTextBox
            // 
            this.dynamicIntExecuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicIntExecuteTextBox.Location = new System.Drawing.Point(28, 156);
            this.dynamicIntExecuteTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dynamicIntExecuteTextBox.Name = "dynamicIntExecuteTextBox";
            this.dynamicIntExecuteTextBox.ReadOnly = true;
            this.dynamicIntExecuteTextBox.Size = new System.Drawing.Size(342, 48);
            this.dynamicIntExecuteTextBox.TabIndex = 107;
            // 
            // dynamicExecuteLabel
            // 
            this.dynamicExecuteLabel.AutoSize = true;
            this.dynamicExecuteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dynamicExecuteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dynamicExecuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicExecuteLabel.Location = new System.Drawing.Point(390, 154);
            this.dynamicExecuteLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dynamicExecuteLabel.Name = "dynamicExecuteLabel";
            this.dynamicExecuteLabel.Size = new System.Drawing.Size(251, 54);
            this.dynamicExecuteLabel.TabIndex = 108;
            this.dynamicExecuteLabel.Text = "Int Execute";
            // 
            // dynamicPipelineLabel
            // 
            this.dynamicPipelineLabel.AutoSize = true;
            this.dynamicPipelineLabel.BackColor = System.Drawing.Color.Black;
            this.dynamicPipelineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dynamicPipelineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dynamicPipelineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicPipelineLabel.Location = new System.Drawing.Point(28, 9);
            this.dynamicPipelineLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dynamicPipelineLabel.Name = "dynamicPipelineLabel";
            this.dynamicPipelineLabel.Size = new System.Drawing.Size(449, 65);
            this.dynamicPipelineLabel.TabIndex = 109;
            this.dynamicPipelineLabel.Text = "Dynamic Pipeline";
            // 
            // staticPipelineLabel
            // 
            this.staticPipelineLabel.AutoSize = true;
            this.staticPipelineLabel.BackColor = System.Drawing.Color.Black;
            this.staticPipelineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticPipelineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticPipelineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticPipelineLabel.Location = new System.Drawing.Point(28, 640);
            this.staticPipelineLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.staticPipelineLabel.Name = "staticPipelineLabel";
            this.staticPipelineLabel.Size = new System.Drawing.Size(374, 65);
            this.staticPipelineLabel.TabIndex = 110;
            this.staticPipelineLabel.Text = "Static Pipeline";
            // 
            // startDynamicButton
            // 
            this.startDynamicButton.BackColor = System.Drawing.Color.Silver;
            this.startDynamicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDynamicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.startDynamicButton.ForeColor = System.Drawing.Color.Black;
            this.startDynamicButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startDynamicButton.Location = new System.Drawing.Point(28, 513);
            this.startDynamicButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDynamicButton.Name = "startDynamicButton";
            this.startDynamicButton.Size = new System.Drawing.Size(513, 89);
            this.startDynamicButton.TabIndex = 111;
            this.startDynamicButton.Text = "Start Dynamic Simulation";
            this.startDynamicButton.UseVisualStyleBackColor = false;
            this.startDynamicButton.Click += new System.EventHandler(this.startDynamicButton_Click);
            // 
            // reorderBufferTextBox
            // 
            this.reorderBufferTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderBufferTextBox.Location = new System.Drawing.Point(1951, 80);
            this.reorderBufferTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.reorderBufferTextBox.Name = "reorderBufferTextBox";
            this.reorderBufferTextBox.ReadOnly = true;
            this.reorderBufferTextBox.Size = new System.Drawing.Size(228, 48);
            this.reorderBufferTextBox.TabIndex = 112;
            this.reorderBufferTextBox.Text = "0";
            // 
            // memConflictTextBox
            // 
            this.memConflictTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memConflictTextBox.Location = new System.Drawing.Point(1951, 196);
            this.memConflictTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memConflictTextBox.Name = "memConflictTextBox";
            this.memConflictTextBox.ReadOnly = true;
            this.memConflictTextBox.Size = new System.Drawing.Size(228, 48);
            this.memConflictTextBox.TabIndex = 113;
            this.memConflictTextBox.Text = "0";
            // 
            // resStationTextBox
            // 
            this.resStationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resStationTextBox.Location = new System.Drawing.Point(1951, 138);
            this.resStationTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.resStationTextBox.Name = "resStationTextBox";
            this.resStationTextBox.ReadOnly = true;
            this.resStationTextBox.Size = new System.Drawing.Size(228, 48);
            this.resStationTextBox.TabIndex = 114;
            this.resStationTextBox.Text = "0";
            // 
            // trueDependenceTextBox
            // 
            this.trueDependenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueDependenceTextBox.Location = new System.Drawing.Point(1951, 254);
            this.trueDependenceTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.trueDependenceTextBox.Name = "trueDependenceTextBox";
            this.trueDependenceTextBox.ReadOnly = true;
            this.trueDependenceTextBox.Size = new System.Drawing.Size(228, 48);
            this.trueDependenceTextBox.TabIndex = 115;
            this.trueDependenceTextBox.Text = "0";
            // 
            // delaysLabel
            // 
            this.delaysLabel.AutoSize = true;
            this.delaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delaysLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaysLabel.Location = new System.Drawing.Point(2011, 18);
            this.delaysLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.delaysLabel.Name = "delaysLabel";
            this.delaysLabel.Size = new System.Drawing.Size(163, 54);
            this.delaysLabel.TabIndex = 116;
            this.delaysLabel.Text = "Delays";
            // 
            // reorderBufferLabel
            // 
            this.reorderBufferLabel.AutoSize = true;
            this.reorderBufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderBufferLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reorderBufferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderBufferLabel.Location = new System.Drawing.Point(1664, 80);
            this.reorderBufferLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.reorderBufferLabel.Name = "reorderBufferLabel";
            this.reorderBufferLabel.Size = new System.Drawing.Size(255, 42);
            this.reorderBufferLabel.TabIndex = 117;
            this.reorderBufferLabel.Text = "Reorder Buffer";
            // 
            // resStationLabel
            // 
            this.resStationLabel.AutoSize = true;
            this.resStationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resStationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resStationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resStationLabel.Location = new System.Drawing.Point(1584, 138);
            this.resStationLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.resStationLabel.Name = "resStationLabel";
            this.resStationLabel.Size = new System.Drawing.Size(333, 42);
            this.resStationLabel.TabIndex = 118;
            this.resStationLabel.Text = "Reservation Station";
            // 
            // memConflictLabel
            // 
            this.memConflictLabel.AutoSize = true;
            this.memConflictLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memConflictLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memConflictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memConflictLabel.Location = new System.Drawing.Point(1647, 199);
            this.memConflictLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.memConflictLabel.Name = "memConflictLabel";
            this.memConflictLabel.Size = new System.Drawing.Size(279, 42);
            this.memConflictLabel.TabIndex = 119;
            this.memConflictLabel.Text = "Memory Conflict";
            // 
            // trueDependenceLabel
            // 
            this.trueDependenceLabel.AutoSize = true;
            this.trueDependenceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trueDependenceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trueDependenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueDependenceLabel.Location = new System.Drawing.Point(1612, 254);
            this.trueDependenceLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.trueDependenceLabel.Name = "trueDependenceLabel";
            this.trueDependenceLabel.Size = new System.Drawing.Size(307, 42);
            this.trueDependenceLabel.TabIndex = 120;
            this.trueDependenceLabel.Text = "True Dependence";
            // 
            // memReadTextBox
            // 
            this.memReadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memReadTextBox.Location = new System.Drawing.Point(28, 303);
            this.memReadTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.memReadTextBox.Name = "memReadTextBox";
            this.memReadTextBox.ReadOnly = true;
            this.memReadTextBox.Size = new System.Drawing.Size(578, 48);
            this.memReadTextBox.TabIndex = 121;
            // 
            // memReadLabel
            // 
            this.memReadLabel.AutoSize = true;
            this.memReadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memReadLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memReadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memReadLabel.Location = new System.Drawing.Point(625, 303);
            this.memReadLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.memReadLabel.Name = "memReadLabel";
            this.memReadLabel.Size = new System.Drawing.Size(306, 54);
            this.memReadLabel.TabIndex = 122;
            this.memReadLabel.Text = "Memory Read";
            // 
            // dynamicMemExecTBox
            // 
            this.dynamicMemExecTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicMemExecTBox.Location = new System.Drawing.Point(674, 156);
            this.dynamicMemExecTBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dynamicMemExecTBox.Name = "dynamicMemExecTBox";
            this.dynamicMemExecTBox.ReadOnly = true;
            this.dynamicMemExecTBox.Size = new System.Drawing.Size(342, 48);
            this.dynamicMemExecTBox.TabIndex = 123;
            // 
            // dynamicLSExecTBox
            // 
            this.dynamicLSExecTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicLSExecTBox.Location = new System.Drawing.Point(28, 232);
            this.dynamicLSExecTBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dynamicLSExecTBox.Name = "dynamicLSExecTBox";
            this.dynamicLSExecTBox.ReadOnly = true;
            this.dynamicLSExecTBox.Size = new System.Drawing.Size(342, 48);
            this.dynamicLSExecTBox.TabIndex = 124;
            // 
            // dynamicFExecTextBox
            // 
            this.dynamicFExecTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicFExecTextBox.Location = new System.Drawing.Point(674, 228);
            this.dynamicFExecTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dynamicFExecTextBox.Name = "dynamicFExecTextBox";
            this.dynamicFExecTextBox.ReadOnly = true;
            this.dynamicFExecTextBox.Size = new System.Drawing.Size(342, 48);
            this.dynamicFExecTextBox.TabIndex = 125;
            this.dynamicFExecTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1036, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 126;
            this.label1.Text = "Float Execute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1034, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 54);
            this.label2.TabIndex = 127;
            this.label2.Text = "Mem Execute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 54);
            this.label3.TabIndex = 128;
            this.label3.Text = "LS Execute";
            // 
            // simulationPanel
            // 
            this.simulationPanel.BackColor = System.Drawing.Color.Black;
            this.simulationPanel.Controls.Add(this.label3);
            this.simulationPanel.Controls.Add(this.label2);
            this.simulationPanel.Controls.Add(this.label1);
            this.simulationPanel.Controls.Add(this.dynamicFExecTextBox);
            this.simulationPanel.Controls.Add(this.dynamicLSExecTBox);
            this.simulationPanel.Controls.Add(this.dynamicMemExecTBox);
            this.simulationPanel.Controls.Add(this.memReadLabel);
            this.simulationPanel.Controls.Add(this.memReadTextBox);
            this.simulationPanel.Controls.Add(this.trueDependenceLabel);
            this.simulationPanel.Controls.Add(this.memConflictLabel);
            this.simulationPanel.Controls.Add(this.resStationLabel);
            this.simulationPanel.Controls.Add(this.reorderBufferLabel);
            this.simulationPanel.Controls.Add(this.delaysLabel);
            this.simulationPanel.Controls.Add(this.trueDependenceTextBox);
            this.simulationPanel.Controls.Add(this.resStationTextBox);
            this.simulationPanel.Controls.Add(this.memConflictTextBox);
            this.simulationPanel.Controls.Add(this.reorderBufferTextBox);
            this.simulationPanel.Controls.Add(this.startDynamicButton);
            this.simulationPanel.Controls.Add(this.staticPipelineLabel);
            this.simulationPanel.Controls.Add(this.dynamicPipelineLabel);
            this.simulationPanel.Controls.Add(this.dynamicExecuteLabel);
            this.simulationPanel.Controls.Add(this.dynamicIntExecuteTextBox);
            this.simulationPanel.Controls.Add(this.storeLabel);
            this.simulationPanel.Controls.Add(this.decodeLabel);
            this.simulationPanel.Controls.Add(this.fetchLabel);
            this.simulationPanel.Controls.Add(this.commitTextBox);
            this.simulationPanel.Controls.Add(this.writeTextBox);
            this.simulationPanel.Controls.Add(this.issueTextBox);
            this.simulationPanel.Controls.Add(this.commitLabel);
            this.simulationPanel.Controls.Add(this.writeLabel);
            this.simulationPanel.Controls.Add(this.issueLabel);
            this.simulationPanel.Controls.Add(this.r0Label);
            this.simulationPanel.Controls.Add(this.f15Label);
            this.simulationPanel.Controls.Add(this.f14Label);
            this.simulationPanel.Controls.Add(this.f13Label);
            this.simulationPanel.Controls.Add(this.f12Label);
            this.simulationPanel.Controls.Add(this.r11Label);
            this.simulationPanel.Controls.Add(this.r10Label);
            this.simulationPanel.Controls.Add(this.r9Label);
            this.simulationPanel.Controls.Add(this.r8Label);
            this.simulationPanel.Controls.Add(this.r7Label);
            this.simulationPanel.Controls.Add(this.r6Label);
            this.simulationPanel.Controls.Add(this.r5Label);
            this.simulationPanel.Controls.Add(this.r4Label);
            this.simulationPanel.Controls.Add(this.r3Label);
            this.simulationPanel.Controls.Add(this.r2Label);
            this.simulationPanel.Controls.Add(this.r1Label);
            this.simulationPanel.Controls.Add(this.f15TextBox);
            this.simulationPanel.Controls.Add(this.f14TextBox);
            this.simulationPanel.Controls.Add(this.f13TextBox);
            this.simulationPanel.Controls.Add(this.f12TextBox);
            this.simulationPanel.Controls.Add(this.r11TextBox);
            this.simulationPanel.Controls.Add(this.r10TextBox);
            this.simulationPanel.Controls.Add(this.r9TextBox);
            this.simulationPanel.Controls.Add(this.r8TextBox);
            this.simulationPanel.Controls.Add(this.r7TextBox);
            this.simulationPanel.Controls.Add(this.r6TextBox);
            this.simulationPanel.Controls.Add(this.r5TextBox);
            this.simulationPanel.Controls.Add(this.r4TextBox);
            this.simulationPanel.Controls.Add(this.r3TextBox);
            this.simulationPanel.Controls.Add(this.r2TextBox);
            this.simulationPanel.Controls.Add(this.r1TextBox);
            this.simulationPanel.Controls.Add(this.r0TextBox);
            this.simulationPanel.Controls.Add(this.registersLabel);
            this.simulationPanel.Controls.Add(this.storeStallLabel);
            this.simulationPanel.Controls.Add(this.executeStallLabel);
            this.simulationPanel.Controls.Add(this.decodeStallLabel);
            this.simulationPanel.Controls.Add(this.fetchStallLabel);
            this.simulationPanel.Controls.Add(this.wawLabel);
            this.simulationPanel.Controls.Add(this.warLabel);
            this.simulationPanel.Controls.Add(this.rawLabel);
            this.simulationPanel.Controls.Add(this.controlHazardLabel);
            this.simulationPanel.Controls.Add(this.dataHazardLabel);
            this.simulationPanel.Controls.Add(this.structuralHazardLabel);
            this.simulationPanel.Controls.Add(this.stallsLabel);
            this.simulationPanel.Controls.Add(this.dependenciesLabel);
            this.simulationPanel.Controls.Add(this.hazardsLabel);
            this.simulationPanel.Controls.Add(this.storeStallTextbox);
            this.simulationPanel.Controls.Add(this.decodeStallTextbox);
            this.simulationPanel.Controls.Add(this.executeStallTextbox);
            this.simulationPanel.Controls.Add(this.fetchStallTextbox);
            this.simulationPanel.Controls.Add(this.warTextBox);
            this.simulationPanel.Controls.Add(this.wawTextBox);
            this.simulationPanel.Controls.Add(this.rawTextBox);
            this.simulationPanel.Controls.Add(this.dataHTextBox);
            this.simulationPanel.Controls.Add(this.controlHTextBox);
            this.simulationPanel.Controls.Add(this.structHTextBox);
            this.simulationPanel.Controls.Add(this.counterTextBox);
            this.simulationPanel.Controls.Add(this.cyclesLabel);
            this.simulationPanel.Controls.Add(this.executeTextBox);
            this.simulationPanel.Controls.Add(this.storeTextBox);
            this.simulationPanel.Controls.Add(this.decodeTextBox);
            this.simulationPanel.Controls.Add(this.fetchTextBox);
            this.simulationPanel.Controls.Add(this.nextCycleButton);
            this.simulationPanel.Controls.Add(this.startStaticButton);
            this.simulationPanel.Controls.Add(this.executeLabel);
            this.simulationPanel.Location = new System.Drawing.Point(742, 176);
            this.simulationPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.simulationPanel.Name = "simulationPanel";
            this.simulationPanel.Size = new System.Drawing.Size(2207, 1428);
            this.simulationPanel.TabIndex = 3;
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(3836, 1698);
            this.Controls.Add(this.memSlider);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.simulationPanel);
            this.Controls.Add(this.assemblyPanel);
            this.Controls.Add(this.MNAWLabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "GUIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipeline Caching Simulation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.assemblyPanel.ResumeLayout(false);
            this.assemblyPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.tabCache.ResumeLayout(false);
            this.memoryOutput.ResumeLayout(false);
            this.memoryOutput.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memSlider)).EndInit();
            this.simulationPanel.ResumeLayout(false);
            this.simulationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MNAWLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Panel assemblyPanel;
        private System.Windows.Forms.Label assemblyLabel;
        private System.Windows.Forms.TextBox assemblyTextBox;
        private System.Windows.Forms.Button saveAssemblyButton;
        private System.Windows.Forms.Button clearAssemblyButton;
        private System.Windows.Forms.Button loadAssemblyButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TrackBar memSlider;
        private System.Windows.Forms.TabControl tabCache;
        private System.Windows.Forms.TabPage memoryOutput;
        private System.Windows.Forms.TextBox memOutputText;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox cacheText;
        private System.Windows.Forms.Label executeLabel;
        private System.Windows.Forms.Button startStaticButton;
        private System.Windows.Forms.Button nextCycleButton;
        private System.Windows.Forms.TextBox fetchTextBox;
        private System.Windows.Forms.TextBox decodeTextBox;
        private System.Windows.Forms.TextBox storeTextBox;
        private System.Windows.Forms.TextBox executeTextBox;
        private System.Windows.Forms.Label cyclesLabel;
        private System.Windows.Forms.TextBox counterTextBox;
        private System.Windows.Forms.TextBox structHTextBox;
        private System.Windows.Forms.TextBox controlHTextBox;
        private System.Windows.Forms.TextBox dataHTextBox;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.TextBox wawTextBox;
        private System.Windows.Forms.TextBox warTextBox;
        private System.Windows.Forms.TextBox fetchStallTextbox;
        private System.Windows.Forms.TextBox executeStallTextbox;
        private System.Windows.Forms.TextBox decodeStallTextbox;
        private System.Windows.Forms.TextBox storeStallTextbox;
        private System.Windows.Forms.Label hazardsLabel;
        private System.Windows.Forms.Label dependenciesLabel;
        private System.Windows.Forms.Label stallsLabel;
        private System.Windows.Forms.Label structuralHazardLabel;
        private System.Windows.Forms.Label dataHazardLabel;
        private System.Windows.Forms.Label controlHazardLabel;
        private System.Windows.Forms.Label rawLabel;
        private System.Windows.Forms.Label warLabel;
        private System.Windows.Forms.Label wawLabel;
        private System.Windows.Forms.Label fetchStallLabel;
        private System.Windows.Forms.Label decodeStallLabel;
        private System.Windows.Forms.Label executeStallLabel;
        private System.Windows.Forms.Label storeStallLabel;
        private System.Windows.Forms.Label registersLabel;
        private System.Windows.Forms.TextBox r0TextBox;
        private System.Windows.Forms.TextBox r1TextBox;
        private System.Windows.Forms.TextBox r2TextBox;
        private System.Windows.Forms.TextBox r3TextBox;
        private System.Windows.Forms.TextBox r4TextBox;
        private System.Windows.Forms.TextBox r5TextBox;
        private System.Windows.Forms.TextBox r6TextBox;
        private System.Windows.Forms.TextBox r7TextBox;
        private System.Windows.Forms.TextBox r8TextBox;
        private System.Windows.Forms.TextBox r9TextBox;
        private System.Windows.Forms.TextBox r10TextBox;
        private System.Windows.Forms.TextBox r11TextBox;
        private System.Windows.Forms.TextBox f12TextBox;
        private System.Windows.Forms.TextBox f13TextBox;
        private System.Windows.Forms.TextBox f14TextBox;
        private System.Windows.Forms.TextBox f15TextBox;
        private System.Windows.Forms.Label r1Label;
        private System.Windows.Forms.Label r2Label;
        private System.Windows.Forms.Label r3Label;
        private System.Windows.Forms.Label r4Label;
        private System.Windows.Forms.Label r5Label;
        private System.Windows.Forms.Label r6Label;
        private System.Windows.Forms.Label r7Label;
        private System.Windows.Forms.Label r8Label;
        private System.Windows.Forms.Label r9Label;
        private System.Windows.Forms.Label r10Label;
        private System.Windows.Forms.Label r11Label;
        private System.Windows.Forms.Label f12Label;
        private System.Windows.Forms.Label f13Label;
        private System.Windows.Forms.Label f14Label;
        private System.Windows.Forms.Label f15Label;
        private System.Windows.Forms.Label r0Label;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label writeLabel;
        private System.Windows.Forms.Label commitLabel;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.TextBox commitTextBox;
        private System.Windows.Forms.Label fetchLabel;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.TextBox dynamicIntExecuteTextBox;
        private System.Windows.Forms.Label dynamicExecuteLabel;
        private System.Windows.Forms.Label dynamicPipelineLabel;
        private System.Windows.Forms.Label staticPipelineLabel;
        private System.Windows.Forms.Button startDynamicButton;
        private System.Windows.Forms.TextBox reorderBufferTextBox;
        private System.Windows.Forms.TextBox memConflictTextBox;
        private System.Windows.Forms.TextBox resStationTextBox;
        private System.Windows.Forms.TextBox trueDependenceTextBox;
        private System.Windows.Forms.Label delaysLabel;
        private System.Windows.Forms.Label reorderBufferLabel;
        private System.Windows.Forms.Label resStationLabel;
        private System.Windows.Forms.Label memConflictLabel;
        private System.Windows.Forms.Label trueDependenceLabel;
        private System.Windows.Forms.TextBox memReadTextBox;
        private System.Windows.Forms.Label memReadLabel;
        private System.Windows.Forms.TextBox dynamicMemExecTBox;
        private System.Windows.Forms.TextBox dynamicLSExecTBox;
        private System.Windows.Forms.TextBox dynamicFExecTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Panel simulationPanel;
        private System.Windows.Forms.TextBox missesTextBox;
        private System.Windows.Forms.TextBox hitsTextBox;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}

