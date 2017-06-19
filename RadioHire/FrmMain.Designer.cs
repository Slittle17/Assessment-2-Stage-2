namespace RadioHire
{
    partial class frmMain
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
            this.btnBrowseInv = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseInv
            // 
            this.btnBrowseInv.Location = new System.Drawing.Point(52, 106);
            this.btnBrowseInv.Name = "btnBrowseInv";
            this.btnBrowseInv.Size = new System.Drawing.Size(148, 56);
            this.btnBrowseInv.TabIndex = 0;
            this.btnBrowseInv.Text = "Browse Radio Inventory";
            this.btnBrowseInv.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(52, 183);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(148, 56);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(225, 252);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 24);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.Location = new System.Drawing.Point(53, 25);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(146, 69);
            this.lstBrand.Sorted = true;
            this.lstBrand.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(52, 11);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(74, 13);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Radio Brands:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(322, 288);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lstBrand);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnBrowseInv);
            this.Name = "frmMain";
            this.Text = "Radio Acquisition Portal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseInv;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Label lblBrand;
    }
}

