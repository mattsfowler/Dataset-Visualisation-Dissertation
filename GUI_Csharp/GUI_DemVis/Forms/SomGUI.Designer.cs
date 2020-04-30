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
            this.lblTitleSOM = new System.Windows.Forms.Label();
            this.grpParamsSOM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(3, 446);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(361, 52);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpParamsSOM
            // 
            this.grpParamsSOM.Controls.Add(this.btnSubmit);
            this.grpParamsSOM.Location = new System.Drawing.Point(12, 63);
            this.grpParamsSOM.Name = "grpParamsSOM";
            this.grpParamsSOM.Size = new System.Drawing.Size(367, 501);
            this.grpParamsSOM.TabIndex = 1;
            this.grpParamsSOM.TabStop = false;
            this.grpParamsSOM.Text = "Parameters";
            // 
            // lblTitleSOM
            // 
            this.lblTitleSOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleSOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSOM.Location = new System.Drawing.Point(0, 0);
            this.lblTitleSOM.Name = "lblTitleSOM";
            this.lblTitleSOM.Size = new System.Drawing.Size(1016, 25);
            this.lblTitleSOM.TabIndex = 2;
            this.lblTitleSOM.Text = "Self Organising Map";
            this.lblTitleSOM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SomGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 576);
            this.Controls.Add(this.lblTitleSOM);
            this.Controls.Add(this.grpParamsSOM);
            this.Name = "SomGUI";
            this.Text = "SomGUI";
            this.grpParamsSOM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpParamsSOM;
        private System.Windows.Forms.Label lblTitleSOM;
    }
}