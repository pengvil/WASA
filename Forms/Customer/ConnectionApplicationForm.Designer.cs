namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class ConnectionApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionApplicationForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorlblHold = new System.Windows.Forms.Label();
            this.errorlblConn = new System.Windows.Forms.Label();
            this.lblHolding = new System.Windows.Forms.Label();
            this.txtHoldingNumber = new System.Windows.Forms.TextBox();
            this.cmbConType = new System.Windows.Forms.ComboBox();
            this.lblConType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 23);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "➕ New Connection Application";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(22, 52);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(345, 37);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Submitting this application will request a new water/sewage connection.\nA Service" +
    " Officer will review your application and contact you.";
            // 
            // lblStep1
            // 
            this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblStep1.Location = new System.Drawing.Point(22, 101);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(345, 23);
            this.lblStep1.TabIndex = 10;
            this.lblStep1.Text = "Step 1: Submit this application form";
            // 
            // lblStep2
            // 
            this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblStep2.Location = new System.Drawing.Point(22, 135);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(345, 34);
            this.lblStep2.TabIndex = 11;
            this.lblStep2.Text = "Step 2: Service Officer will verify your documents";
            // 
            // lblStep3
            // 
            this.lblStep3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblStep3.Location = new System.Drawing.Point(22, 169);
            this.lblStep3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(345, 23);
            this.lblStep3.TabIndex = 12;
            this.lblStep3.Text = "Step 3: Application will be approved or rejected";
            // 
            // lblStep4
            // 
            this.lblStep4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.lblStep4.Location = new System.Drawing.Point(22, 203);
            this.lblStep4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(345, 23);
            this.lblStep4.TabIndex = 13;
            this.lblStep4.Text = "Step 4: Installation will be scheduled if approved";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(384, 192);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 34);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Submit Application";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(654, 192);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorlblHold
            // 
            this.errorlblHold.AutoSize = true;
            this.errorlblHold.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblHold.ForeColor = System.Drawing.Color.Red;
            this.errorlblHold.Location = new System.Drawing.Point(518, 91);
            this.errorlblHold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlblHold.Name = "errorlblHold";
            this.errorlblHold.Size = new System.Drawing.Size(74, 15);
            this.errorlblHold.TabIndex = 32;
            this.errorlblHold.Text = "errorlblHold";
            // 
            // errorlblConn
            // 
            this.errorlblConn.AutoSize = true;
            this.errorlblConn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblConn.ForeColor = System.Drawing.Color.Red;
            this.errorlblConn.Location = new System.Drawing.Point(518, 157);
            this.errorlblConn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlblConn.Name = "errorlblConn";
            this.errorlblConn.Size = new System.Drawing.Size(77, 15);
            this.errorlblConn.TabIndex = 31;
            this.errorlblConn.Text = "errorlblConn";
            // 
            // lblHolding
            // 
            this.lblHolding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHolding.Location = new System.Drawing.Point(384, 67);
            this.lblHolding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHolding.Name = "lblHolding";
            this.lblHolding.Size = new System.Drawing.Size(133, 20);
            this.lblHolding.TabIndex = 29;
            this.lblHolding.Text = "NID Number *";
            // 
            // txtHoldingNumber
            // 
            this.txtHoldingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoldingNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoldingNumber.Location = new System.Drawing.Point(521, 64);
            this.txtHoldingNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoldingNumber.Name = "txtHoldingNumber";
            this.txtHoldingNumber.Size = new System.Drawing.Size(196, 25);
            this.txtHoldingNumber.TabIndex = 30;
            // 
            // cmbConType
            // 
            this.cmbConType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbConType.Items.AddRange(new object[] {
            "Commercial",
            "Residential",
            "Industrial"});
            this.cmbConType.Location = new System.Drawing.Point(521, 129);
            this.cmbConType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConType.Name = "cmbConType";
            this.cmbConType.Size = new System.Drawing.Size(196, 25);
            this.cmbConType.TabIndex = 28;
            // 
            // lblConType
            // 
            this.lblConType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConType.Location = new System.Drawing.Point(384, 129);
            this.lblConType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConType.Name = "lblConType";
            this.lblConType.Size = new System.Drawing.Size(139, 23);
            this.lblConType.TabIndex = 27;
            this.lblConType.Text = "Connection Type *";
            // 
            // ConnectionApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(758, 262);
            this.Controls.Add(this.errorlblHold);
            this.Controls.Add(this.errorlblConn);
            this.Controls.Add(this.lblHolding);
            this.Controls.Add(this.txtHoldingNumber);
            this.Controls.Add(this.cmbConType);
            this.Controls.Add(this.lblConType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep4);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConnectionApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply for New Connection";
            this.Load += new System.EventHandler(this.ConnectionApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label errorlblHold;
        private System.Windows.Forms.Label errorlblConn;
        private System.Windows.Forms.Label lblHolding;
        private System.Windows.Forms.TextBox txtHoldingNumber;
        private System.Windows.Forms.ComboBox cmbConType;
        private System.Windows.Forms.Label lblConType;
    }
}