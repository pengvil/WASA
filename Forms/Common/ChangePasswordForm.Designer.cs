namespace WaterSewageManagementSystem.Forms.Common
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblTitle.Location = new System.Drawing.Point(89, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Password";
            // 
            // lblOld
            // 
            this.lblOld.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOld.Location = new System.Drawing.Point(30, 70);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(160, 20);
            this.lblOld.TabIndex = 1;
            this.lblOld.Text = "Current Password";
            this.lblOld.Click += new System.EventHandler(this.lblOld_Click);
            // 
            // txtOld
            // 
            this.txtOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOld.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOld.Location = new System.Drawing.Point(200, 66);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(170, 25);
            this.txtOld.TabIndex = 2;
            // 
            // lblNew
            // 
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNew.Location = new System.Drawing.Point(30, 120);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(160, 20);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "New Password";
            // 
            // txtNew
            // 
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNew.Location = new System.Drawing.Point(200, 118);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(170, 25);
            this.txtNew.TabIndex = 4;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.Location = new System.Drawing.Point(30, 170);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(160, 20);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = "Confirm New Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirm.Location = new System.Drawing.Point(200, 168);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(170, 25);
            this.txtConfirm.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(233, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangePasswordForm
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //private void SetRow(System.Windows.Forms.Label lbl, string text, System.Windows.Forms.TextBox txt, int y)
        //{
        //    lbl.Text = text; lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); lbl.Location = new System.Drawing.Point(30, y); lbl.Size = new System.Drawing.Size(160, 20);
        //    txt.Location = new System.Drawing.Point(200, y - 2); txt.Size = new System.Drawing.Size(170, 26); txt.Font = new System.Drawing.Font("Segoe UI", 10F); txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //}
        private System.Windows.Forms.Label lblTitle, lblOld, lblNew, lblConfirm;
        private System.Windows.Forms.TextBox txtOld, txtNew, txtConfirm;
        private System.Windows.Forms.Button btnSave, btnCancel;
    }
}
