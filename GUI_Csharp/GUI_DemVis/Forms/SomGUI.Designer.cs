namespace GUI_DemVis.Forms
{
    partial class SomGUI
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpParamsSOM = new System.Windows.Forms.GroupBox();
            this.lstColumns = new System.Windows.Forms.ListView();
            this.txtNewColName = new System.Windows.Forms.TextBox();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.lblDataCols = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.nudLearnRate = new System.Windows.Forms.NumericUpDown();
            this.lblLearnRate = new System.Windows.Forms.Label();
            this.nudIterLim = new System.Windows.Forms.NumericUpDown();
            this.lblIterLim = new System.Windows.Forms.Label();
            this.nudMapHeight = new System.Windows.Forms.NumericUpDown();
            this.lblMapHeight = new System.Windows.Forms.Label();
            this.nudMapWidth = new System.Windows.Forms.NumericUpDown();
            this.lblMapWidth = new System.Windows.Forms.Label();
            this.nudIDColumn = new System.Windows.Forms.NumericUpDown();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblIDCol = new System.Windows.Forms.Label();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setInputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setOutputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPythonExeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScriptDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grpParamsSOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDColumn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(3, 509);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(450, 52);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpParamsSOM
            // 
            this.grpParamsSOM.Controls.Add(this.lstColumns);
            this.grpParamsSOM.Controls.Add(this.txtNewColName);
            this.grpParamsSOM.Controls.Add(this.btnAddCol);
            this.grpParamsSOM.Controls.Add(this.lblDataCols);
            this.grpParamsSOM.Controls.Add(this.nudRadius);
            this.grpParamsSOM.Controls.Add(this.lblRadius);
            this.grpParamsSOM.Controls.Add(this.nudLearnRate);
            this.grpParamsSOM.Controls.Add(this.lblLearnRate);
            this.grpParamsSOM.Controls.Add(this.nudIterLim);
            this.grpParamsSOM.Controls.Add(this.lblIterLim);
            this.grpParamsSOM.Controls.Add(this.nudMapHeight);
            this.grpParamsSOM.Controls.Add(this.lblMapHeight);
            this.grpParamsSOM.Controls.Add(this.nudMapWidth);
            this.grpParamsSOM.Controls.Add(this.lblMapWidth);
            this.grpParamsSOM.Controls.Add(this.nudIDColumn);
            this.grpParamsSOM.Controls.Add(this.txtOutputFile);
            this.grpParamsSOM.Controls.Add(this.txtInputFile);
            this.grpParamsSOM.Controls.Add(this.lblIDCol);
            this.grpParamsSOM.Controls.Add(this.lblInputFile);
            this.grpParamsSOM.Controls.Add(this.lblOutputFile);
            this.grpParamsSOM.Controls.Add(this.btnSubmit);
            this.grpParamsSOM.Location = new System.Drawing.Point(12, 27);
            this.grpParamsSOM.Name = "grpParamsSOM";
            this.grpParamsSOM.Size = new System.Drawing.Size(456, 564);
            this.grpParamsSOM.TabIndex = 1;
            this.grpParamsSOM.TabStop = false;
            this.grpParamsSOM.Text = "Create Map Matrix";
            // 
            // lstColumns
            // 
            this.lstColumns.HideSelection = false;
            this.lstColumns.Location = new System.Drawing.Point(69, 327);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(306, 176);
            this.lstColumns.TabIndex = 23;
            this.lstColumns.UseCompatibleStateImageBehavior = false;
            this.lstColumns.DoubleClick += new System.EventHandler(this.lstColumns_DoubleClick);
            // 
            // txtNewColName
            // 
            this.txtNewColName.Location = new System.Drawing.Point(69, 300);
            this.txtNewColName.Name = "txtNewColName";
            this.txtNewColName.Size = new System.Drawing.Size(216, 20);
            this.txtNewColName.TabIndex = 22;
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(291, 298);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(84, 23);
            this.btnAddCol.TabIndex = 21;
            this.btnAddCol.Text = "Add";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // lblDataCols
            // 
            this.lblDataCols.AutoSize = true;
            this.lblDataCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCols.Location = new System.Drawing.Point(136, 276);
            this.lblDataCols.Name = "lblDataCols";
            this.lblDataCols.Size = new System.Drawing.Size(176, 17);
            this.lblDataCols.TabIndex = 20;
            this.lblDataCols.Text = "ID Column + Data Columns";
            // 
            // nudRadius
            // 
            this.nudRadius.DecimalPlaces = 1;
            this.nudRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRadius.Location = new System.Drawing.Point(144, 230);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 18;
            this.nudRadius.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(6, 230);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(102, 17);
            this.lblRadius.TabIndex = 17;
            this.lblRadius.Text = "Learning Rate:";
            // 
            // nudLearnRate
            // 
            this.nudLearnRate.DecimalPlaces = 2;
            this.nudLearnRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudLearnRate.Location = new System.Drawing.Point(144, 199);
            this.nudLearnRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLearnRate.Name = "nudLearnRate";
            this.nudLearnRate.Size = new System.Drawing.Size(120, 20);
            this.nudLearnRate.TabIndex = 16;
            this.nudLearnRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // lblLearnRate
            // 
            this.lblLearnRate.AutoSize = true;
            this.lblLearnRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnRate.Location = new System.Drawing.Point(6, 199);
            this.lblLearnRate.Name = "lblLearnRate";
            this.lblLearnRate.Size = new System.Drawing.Size(102, 17);
            this.lblLearnRate.TabIndex = 15;
            this.lblLearnRate.Text = "Learning Rate:";
            // 
            // nudIterLim
            // 
            this.nudIterLim.Location = new System.Drawing.Point(144, 170);
            this.nudIterLim.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIterLim.Name = "nudIterLim";
            this.nudIterLim.Size = new System.Drawing.Size(120, 20);
            this.nudIterLim.TabIndex = 14;
            this.nudIterLim.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblIterLim
            // 
            this.lblIterLim.AutoSize = true;
            this.lblIterLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterLim.Location = new System.Drawing.Point(6, 170);
            this.lblIterLim.Name = "lblIterLim";
            this.lblIterLim.Size = new System.Drawing.Size(99, 17);
            this.lblIterLim.TabIndex = 13;
            this.lblIterLim.Text = "Max Iterations:";
            // 
            // nudMapHeight
            // 
            this.nudMapHeight.Location = new System.Drawing.Point(144, 140);
            this.nudMapHeight.Name = "nudMapHeight";
            this.nudMapHeight.Size = new System.Drawing.Size(120, 20);
            this.nudMapHeight.TabIndex = 12;
            this.nudMapHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblMapHeight
            // 
            this.lblMapHeight.AutoSize = true;
            this.lblMapHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapHeight.Location = new System.Drawing.Point(6, 140);
            this.lblMapHeight.Name = "lblMapHeight";
            this.lblMapHeight.Size = new System.Drawing.Size(84, 17);
            this.lblMapHeight.TabIndex = 11;
            this.lblMapHeight.Text = "Map Height:";
            // 
            // nudMapWidth
            // 
            this.nudMapWidth.Location = new System.Drawing.Point(144, 109);
            this.nudMapWidth.Name = "nudMapWidth";
            this.nudMapWidth.Size = new System.Drawing.Size(120, 20);
            this.nudMapWidth.TabIndex = 10;
            this.nudMapWidth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblMapWidth
            // 
            this.lblMapWidth.AutoSize = true;
            this.lblMapWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapWidth.Location = new System.Drawing.Point(6, 109);
            this.lblMapWidth.Name = "lblMapWidth";
            this.lblMapWidth.Size = new System.Drawing.Size(79, 17);
            this.lblMapWidth.TabIndex = 9;
            this.lblMapWidth.Text = "Map Width:";
            // 
            // nudIDColumn
            // 
            this.nudIDColumn.Location = new System.Drawing.Point(144, 80);
            this.nudIDColumn.Name = "nudIDColumn";
            this.nudIDColumn.Size = new System.Drawing.Size(120, 20);
            this.nudIDColumn.TabIndex = 8;
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(144, 50);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(306, 20);
            this.txtOutputFile.TabIndex = 7;
            this.txtOutputFile.Text = "WorldSOM.csv";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(144, 22);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(306, 20);
            this.txtInputFile.TabIndex = 6;
            this.txtInputFile.Text = "World.csv";
            // 
            // lblIDCol
            // 
            this.lblIDCol.AutoSize = true;
            this.lblIDCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCol.Location = new System.Drawing.Point(6, 80);
            this.lblIDCol.Name = "lblIDCol";
            this.lblIDCol.Size = new System.Drawing.Size(76, 17);
            this.lblIDCol.TabIndex = 5;
            this.lblIDCol.Text = "ID Column:";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile.Location = new System.Drawing.Point(6, 23);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(69, 17);
            this.lblInputFile.TabIndex = 3;
            this.lblInputFile.Text = "Input File:";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFile.Location = new System.Drawing.Point(6, 51);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(81, 17);
            this.lblOutputFile.TabIndex = 4;
            this.lblOutputFile.Text = "Output File:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.setInputDirectoryToolStripMenuItem,
            this.setOutputDirectoryToolStripMenuItem,
            this.setPythonExeToolStripMenuItem,
            this.setScriptDirectoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // setInputDirectoryToolStripMenuItem
            // 
            this.setInputDirectoryToolStripMenuItem.Name = "setInputDirectoryToolStripMenuItem";
            this.setInputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.setInputDirectoryToolStripMenuItem.Text = "Set Input Directory";
            this.setInputDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setInputDirectoryToolStripMenuItem_Click);
            // 
            // setOutputDirectoryToolStripMenuItem
            // 
            this.setOutputDirectoryToolStripMenuItem.Name = "setOutputDirectoryToolStripMenuItem";
            this.setOutputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.setOutputDirectoryToolStripMenuItem.Text = "Set Output Directory";
            this.setOutputDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setOutputDirectoryToolStripMenuItem_Click);
            // 
            // setPythonExeToolStripMenuItem
            // 
            this.setPythonExeToolStripMenuItem.Name = "setPythonExeToolStripMenuItem";
            this.setPythonExeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.setPythonExeToolStripMenuItem.Text = "Set Python Exe";
            this.setPythonExeToolStripMenuItem.Click += new System.EventHandler(this.setPythonExeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.showHelpToolStripMenuItem.Text = "Show Help";
            // 
            // setScriptDirectoryToolStripMenuItem
            // 
            this.setScriptDirectoryToolStripMenuItem.Name = "setScriptDirectoryToolStripMenuItem";
            this.setScriptDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.setScriptDirectoryToolStripMenuItem.Text = "Set Script Directory";
            this.setScriptDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setScriptDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // SomGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 596);
            this.Controls.Add(this.grpParamsSOM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomGUI";
            this.Text = "SomGUI";
            this.grpParamsSOM.ResumeLayout(false);
            this.grpParamsSOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDColumn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpParamsSOM;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblIDCol;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setInputDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setOutputDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPythonExeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudMapHeight;
        private System.Windows.Forms.Label lblMapHeight;
        private System.Windows.Forms.NumericUpDown nudMapWidth;
        private System.Windows.Forms.Label lblMapWidth;
        private System.Windows.Forms.NumericUpDown nudIDColumn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudIterLim;
        private System.Windows.Forms.Label lblIterLim;
        private System.Windows.Forms.NumericUpDown nudLearnRate;
        private System.Windows.Forms.Label lblLearnRate;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblDataCols;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.TextBox txtNewColName;
        private System.Windows.Forms.ListView lstColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setScriptDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}