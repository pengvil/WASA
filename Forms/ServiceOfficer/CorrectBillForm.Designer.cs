namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class CorrectBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectBillForm));
            this.lblBillIDLbl = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.lblNewAmt = new System.Windows.Forms.Label();
            this.txtNewAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillIDLbl
            // 
            this.lblBillIDLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBillIDLbl.Location = new System.Drawing.Point(45, 80);
            this.lblBillIDLbl.Name = "lblBillIDLbl";
            this.lblBillIDLbl.Size = new System.Drawing.Size(120, 22);
            this.lblBillIDLbl.TabIndex = 10;
            this.lblBillIDLbl.Text = "Bill ID :";
            // 
            // txtBillID
            // 
            this.txtBillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBillID.Location = new System.Drawing.Point(189, 78);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(200, 25);
            this.txtBillID.TabIndex = 11;
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillInfo.ForeColor = System.Drawing.Color.Red;
            this.lblBillInfo.Location = new System.Drawing.Point(0, 118);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(520, 22);
            this.lblBillInfo.TabIndex = 13;
            // 
            // lblNewAmt
            // 
            this.lblNewAmt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewAmt.Location = new System.Drawing.Point(45, 155);
            this.lblNewAmt.Name = "lblNewAmt";
            this.lblNewAmt.Size = new System.Drawing.Size(140, 22);
            this.lblNewAmt.TabIndex = 14;
            this.lblNewAmt.Text = "New Amount :";
            // 
            // txtNewAmount
            // 
            this.txtNewAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewAmount.Enabled = false;
            this.txtNewAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewAmount.Location = new System.Drawing.Point(189, 153);
            this.txtNewAmount.Name = "txtNewAmount";
            this.txtNewAmount.Size = new System.Drawing.Size(200, 25);
            this.txtNewAmount.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Correction";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(408, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(520, 52);
            this.panelHeader.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct Bill Amount";
            // 
            // CorrectBillForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(520, 280);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblBillIDLbl);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.lblBillInfo);
            this.Controls.Add(this.lblNewAmt);
            this.Controls.Add(this.txtNewAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CorrectBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correct Bill";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBillIDLbl;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.Label lblNewAmt;
        private System.Windows.Forms.TextBox txtNewAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
    }
}