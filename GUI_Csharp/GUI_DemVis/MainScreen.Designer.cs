namespace GUI_DemVis
{
    partial class MainScreen
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
            this.btnKMeans = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKMeans
            // 
            this.btnKMeans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKMeans.Location = new System.Drawing.Point(0, 98);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(338, 58);
            this.btnKMeans.TabIndex = 0;
            this.btnKMeans.Text = "K-Means";
            this.btnKMeans.UseVisualStyleBackColor = true;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Choose Analysis Algorithm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 156);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnKMeans);
            this.Name = "MainScreen";
            this.Text = "Choose Algorithm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKMeans;
        private System.Windows.Forms.Label lblTitle;
    }
}

