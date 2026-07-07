namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class MeterReadingBillGenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeterReadingBillGenerateForm));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtBillingMonth = new System.Windows.Forms.TextBox();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.lblArrears = new System.Windows.Forms.Label();
            this.txtArrears = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(30, 67);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(175, 22);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer :";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomer.Location = new System.Drawing.Point(210, 63);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(240, 25);
            this.cmbCustomer.TabIndex = 15;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(30, 115);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(175, 22);
            this.lblMonth.TabIndex = 16;
            this.lblMonth.Text = "Billing Month :";
            // 
            // txtBillingMonth
            // 
            this.txtBillingMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillingMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBillingMonth.Location = new System.Drawing.Point(210, 111);
            this.txtBillingMonth.Name = "txtBillingMonth";
            this.txtBillingMonth.Size = new System.Drawing.Size(240, 25);
            this.txtBillingMonth.TabIndex = 17;
            // 
            // lblPrevious
            // 
            this.lblPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrevious.Location = new System.Drawing.Point(30, 163);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(175, 22);
            this.lblPrevious.TabIndex = 18;
            this.lblPrevious.Text = "Previous Reading :";
            // 
            // txtPrevious
            // 
            this.txtPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrevious.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrevious.Location = new System.Drawing.Point(210, 159);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(240, 25);
            this.txtPrevious.TabIndex = 19;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrent.Location = new System.Drawing.Point(30, 211);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(175, 22);
            this.lblCurrent.TabIndex = 20;
            this.lblCurrent.Text = "Current Reading :";
            // 
            // txtCurrent
            // 
            this.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrent.Location = new System.Drawing.Point(210, 207);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(240, 25);
            this.txtCurrent.TabIndex = 21;
            // 
            // lblArrears
            // 
            this.lblArrears.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArrears.Location = new System.Drawing.Point(30, 259);
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.Size = new System.Drawing.Size(175, 22);
            this.lblArrears.TabIndex = 22;
            this.lblArrears.Text = "Arrears :";
            // 
            // txtArrears
            // 
            this.txtArrears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArrears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArrears.Location = new System.Drawing.Point(210, 255);
            this.txtArrears.Name = "txtArrears";
            this.txtArrears.Size = new System.Drawing.Size(240, 25);
            this.txtArrears.TabIndex = 23;
            this.txtArrears.Text = "0";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(30, 310);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 40);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate Bill";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(352, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 40);
            this.btnClose.TabIndex = 25;
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
            this.panelHeader.Size = new System.Drawing.Size(500, 52);
            this.panelHeader.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "📊 Meter Reading and Bill Generation";
            // 
            // MeterReadingBillGenerateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtBillingMonth);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.lblArrears);
            this.Controls.Add(this.txtArrears);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MeterReadingBillGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Meter Reading & Generate Bill";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtBillingMonth;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label lblArrears;
        private System.Windows.Forms.TextBox txtArrears;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
    }
}