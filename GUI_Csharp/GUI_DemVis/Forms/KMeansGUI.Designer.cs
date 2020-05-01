namespace GUI_DemVis
{
    partial class KMeansGUI
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
            this.lblTitleKMeans = new System.Windows.Forms.Label();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.txtPythonDir = new System.Windows.Forms.TextBox();
            this.lblPythonDir = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.nudMaxIterations = new System.Windows.Forms.NumericUpDown();
            this.nudNameColumn = new System.Windows.Forms.NumericUpDown();
            this.nudIDColumn = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDataColumns = new System.Windows.Forms.TextBox();
            this.nudNumClusters = new System.Windows.Forms.NumericUpDown();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblMaxIterations = new System.Windows.Forms.Label();
            this.lblNumClusters = new System.Windows.Forms.Label();
            this.lblDataColumns = new System.Windows.Forms.Label();
            this.lblNameColumn = new System.Windows.Forms.Label();
            this.lblIDCol = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.lbxClusters = new System.Windows.Forms.ListBox();
            this.lstNames = new System.Windows.Forms.ListView();
            this.grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNameColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleKMeans
            // 
            this.lblTitleKMeans.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleKMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleKMeans.Location = new System.Drawing.Point(0, 0);
            this.lblTitleKMeans.Name = "lblTitleKMeans";
            this.lblTitleKMeans.Size = new System.Drawing.Size(1127, 26);
            this.lblTitleKMeans.TabIndex = 0;
            this.lblTitleKMeans.Text = "Cluster Data";
            this.lblTitleKMeans.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile.Location = new System.Drawing.Point(74, 27);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(69, 17);
            this.lblInputFile.TabIndex = 1;
            this.lblInputFile.Text = "Input File:";
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.txtPythonDir);
            this.grpParameters.Controls.Add(this.lblPythonDir);
            this.grpParameters.Controls.Add(this.lblHint);
            this.grpParameters.Controls.Add(this.nudMaxIterations);
            this.grpParameters.Controls.Add(this.nudNameColumn);
            this.grpParameters.Controls.Add(this.nudIDColumn);
            this.grpParameters.Controls.Add(this.btnSubmit);
            this.grpParameters.Controls.Add(this.txtDataColumns);
            this.grpParameters.Controls.Add(this.nudNumClusters);
            this.grpParameters.Controls.Add(this.txtOutputFile);
            this.grpParameters.Controls.Add(this.btnBrowseInput);
            this.grpParameters.Controls.Add(this.txtInputFile);
            this.grpParameters.Controls.Add(this.lblMaxIterations);
            this.grpParameters.Controls.Add(this.lblNumClusters);
            this.grpParameters.Controls.Add(this.lblDataColumns);
            this.grpParameters.Controls.Add(this.lblNameColumn);
            this.grpParameters.Controls.Add(this.lblIDCol);
            this.grpParameters.Controls.Add(this.lblOutputFile);
            this.grpParameters.Controls.Add(this.lblInputFile);
            this.grpParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpParameters.Location = new System.Drawing.Point(0, 26);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(431, 536);
            this.grpParameters.TabIndex = 2;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters";
            // 
            // txtPythonDir
            // 
            this.txtPythonDir.Location = new System.Drawing.Point(149, 415);
            this.txtPythonDir.Name = "txtPythonDir";
            this.txtPythonDir.Size = new System.Drawing.Size(235, 20);
            this.txtPythonDir.TabIndex = 20;
            this.txtPythonDir.Text = "D:\\Program Files\\Python38\\Python.exe";
            // 
            // lblPythonDir
            // 
            this.lblPythonDir.AutoSize = true;
            this.lblPythonDir.Location = new System.Drawing.Point(12, 418);
            this.lblPythonDir.Name = "lblPythonDir";
            this.lblPythonDir.Size = new System.Drawing.Size(105, 13);
            this.lblPythonDir.TabIndex = 19;
            this.lblPythonDir.Text = "Python Exe Location";
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(12, 224);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(131, 155);
            this.lblHint.TabIndex = 18;
            this.lblHint.Text = "(use semi-colon to separate column names)";
            // 
            // nudMaxIterations
            // 
            this.nudMaxIterations.Location = new System.Drawing.Point(149, 160);
            this.nudMaxIterations.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMaxIterations.Name = "nudMaxIterations";
            this.nudMaxIterations.Size = new System.Drawing.Size(235, 20);
            this.nudMaxIterations.TabIndex = 17;
            this.nudMaxIterations.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudNameColumn
            // 
            this.nudNameColumn.Location = new System.Drawing.Point(149, 106);
            this.nudNameColumn.Name = "nudNameColumn";
            this.nudNameColumn.Size = new System.Drawing.Size(235, 20);
            this.nudNameColumn.TabIndex = 16;
            this.nudNameColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudIDColumn
            // 
            this.nudIDColumn.Location = new System.Drawing.Point(149, 80);
            this.nudIDColumn.Name = "nudIDColumn";
            this.nudIDColumn.Size = new System.Drawing.Size(235, 20);
            this.nudIDColumn.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(3, 461);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(425, 72);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDataColumns
            // 
            this.txtDataColumns.Location = new System.Drawing.Point(149, 197);
            this.txtDataColumns.Multiline = true;
            this.txtDataColumns.Name = "txtDataColumns";
            this.txtDataColumns.Size = new System.Drawing.Size(235, 182);
            this.txtDataColumns.TabIndex = 13;
            this.txtDataColumns.Text = "iso_a3;name;gdp_cap_est;life_exp;inequality;HPI";
            // 
            // nudNumClusters
            // 
            this.nudNumClusters.Location = new System.Drawing.Point(149, 133);
            this.nudNumClusters.Name = "nudNumClusters";
            this.nudNumClusters.Size = new System.Drawing.Size(235, 20);
            this.nudNumClusters.TabIndex = 12;
            this.nudNumClusters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(149, 52);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(235, 20);
            this.txtOutputFile.TabIndex = 9;
            this.txtOutputFile.Text = "WorldClustered.json";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInput.Location = new System.Drawing.Point(391, 27);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(34, 19);
            this.btnBrowseInput.TabIndex = 8;
            this.btnBrowseInput.Text = "find";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(149, 26);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(235, 20);
            this.txtInputFile.TabIndex = 7;
            this.txtInputFile.Text = "World.csv";
            // 
            // lblMaxIterations
            // 
            this.lblMaxIterations.AutoSize = true;
            this.lblMaxIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxIterations.Location = new System.Drawing.Point(44, 160);
            this.lblMaxIterations.Name = "lblMaxIterations";
            this.lblMaxIterations.Size = new System.Drawing.Size(99, 17);
            this.lblMaxIterations.TabIndex = 6;
            this.lblMaxIterations.Text = "Max Iterations:";
            // 
            // lblNumClusters
            // 
            this.lblNumClusters.AutoSize = true;
            this.lblNumClusters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClusters.Location = new System.Drawing.Point(10, 133);
            this.lblNumClusters.Name = "lblNumClusters";
            this.lblNumClusters.Size = new System.Drawing.Size(133, 17);
            this.lblNumClusters.TabIndex = 3;
            this.lblNumClusters.Text = "Number of Clusters:";
            // 
            // lblDataColumns
            // 
            this.lblDataColumns.AutoSize = true;
            this.lblDataColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataColumns.Location = new System.Drawing.Point(43, 198);
            this.lblDataColumns.Name = "lblDataColumns";
            this.lblDataColumns.Size = new System.Drawing.Size(100, 17);
            this.lblDataColumns.TabIndex = 5;
            this.lblDataColumns.Text = "Data Columns:";
            // 
            // lblNameColumn
            // 
            this.lblNameColumn.AutoSize = true;
            this.lblNameColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameColumn.Location = new System.Drawing.Point(43, 106);
            this.lblNameColumn.Name = "lblNameColumn";
            this.lblNameColumn.Size = new System.Drawing.Size(100, 17);
            this.lblNameColumn.TabIndex = 4;
            this.lblNameColumn.Text = "Name Column:";
            // 
            // lblIDCol
            // 
            this.lblIDCol.AutoSize = true;
            this.lblIDCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCol.Location = new System.Drawing.Point(67, 80);
            this.lblIDCol.Name = "lblIDCol";
            this.lblIDCol.Size = new System.Drawing.Size(76, 17);
            this.lblIDCol.TabIndex = 3;
            this.lblIDCol.Text = "ID Column:";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFile.Location = new System.Drawing.Point(62, 53);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(81, 17);
            this.lblOutputFile.TabIndex = 2;
            this.lblOutputFile.Text = "Output File:";
            // 
            // lbxClusters
            // 
            this.lbxClusters.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxClusters.FormattingEnabled = true;
            this.lbxClusters.Location = new System.Drawing.Point(431, 26);
            this.lbxClusters.Name = "lbxClusters";
            this.lbxClusters.Size = new System.Drawing.Size(168, 536);
            this.lbxClusters.TabIndex = 3;
            this.lbxClusters.SelectedIndexChanged += new System.EventHandler(this.lbxClusters_SelectedIndexChanged);
            // 
            // lstNames
            // 
            this.lstNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNames.HideSelection = false;
            this.lstNames.Location = new System.Drawing.Point(599, 26);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(528, 536);
            this.lstNames.TabIndex = 4;
            this.lstNames.UseCompatibleStateImageBehavior = false;
            // 
            // KMeansGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 562);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.lbxClusters);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.lblTitleKMeans);
            this.Name = "KMeansGUI";
            this.Text = "KMeansGUI";
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNameColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumClusters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleKMeans;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDataColumns;
        private System.Windows.Forms.NumericUpDown nudNumClusters;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblMaxIterations;
        private System.Windows.Forms.Label lblNumClusters;
        private System.Windows.Forms.Label lblDataColumns;
        private System.Windows.Forms.Label lblNameColumn;
        private System.Windows.Forms.Label lblIDCol;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.NumericUpDown nudMaxIterations;
        private System.Windows.Forms.NumericUpDown nudNameColumn;
        private System.Windows.Forms.NumericUpDown nudIDColumn;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ListBox lbxClusters;
        private System.Windows.Forms.ListView lstNames;
        private System.Windows.Forms.TextBox txtPythonDir;
        private System.Windows.Forms.Label lblPythonDir;
    }
}