namespace RadioHire
{
    partial class FrmRadioInventory
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInvList = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(234, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbxInventory
            // 
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.Location = new System.Drawing.Point(26, 57);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(276, 173);
            this.lbxInventory.TabIndex = 5;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.SystemColors.Control;
            this.lblInventory.Location = new System.Drawing.Point(24, 16);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(85, 13);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Radio Inventory:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(108, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblInvList
            // 
            this.lblInvList.AutoSize = true;
            this.lblInvList.Location = new System.Drawing.Point(29, 42);
            this.lblInvList.Name = "lblInvList";
            this.lblInvList.Size = new System.Drawing.Size(273, 13);
            this.lblInvList.TabIndex = 9;
            this.lblInvList.Text = "Model        Description     Availability     Price      Quantity";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(30, 272);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(58, 13);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "TotalValue";
            // 
            // FrmRadioInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(330, 299);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblInvList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lbxInventory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmRadioInventory";
            this.Text = "Browse Radio Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInvList;
        private System.Windows.Forms.Label lblValue;
    }
}