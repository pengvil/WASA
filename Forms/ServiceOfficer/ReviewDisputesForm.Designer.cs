namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ReviewDisputesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewDisputesForm));
            this.dgvDisputes = new System.Windows.Forms.DataGridView();
            this.btnMarkReviewed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCorrectBill = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisputes)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisputes
            // 
            this.dgvDisputes.AllowUserToAddRows = false;
            this.dgvDisputes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisputes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisputes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisputes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisputes.ColumnHeadersHeight = 29;
            this.dgvDisputes.EnableHeadersVisualStyles = false;
            this.dgvDisputes.Location = new System.Drawing.Point(12, 58);
            this.dgvDisputes.Name = "dgvDisputes";
            this.dgvDisputes.ReadOnly = true;
            this.dgvDisputes.RowHeadersVisible = false;
            this.dgvDisputes.RowHeadersWidth = 51;
            this.dgvDisputes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisputes.Size = new System.Drawing.Size(1112, 516);
            this.dgvDisputes.TabIndex = 1;
            // 
            // btnMarkReviewed
            // 
            this.btnMarkReviewed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMarkReviewed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkReviewed.FlatAppearance.BorderSize = 0;
            this.btnMarkReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkReviewed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkReviewed.ForeColor = System.Drawing.Color.White;
            this.btnMarkReviewed.Location = new System.Drawing.Point(12, 585);
            this.btnMarkReviewed.Name = "btnMarkReviewed";
            this.btnMarkReviewed.Size = new System.Drawing.Size(170, 35);
            this.btnMarkReviewed.TabIndex = 2;
            this.btnMarkReviewed.Text = "Mark as Reviewed";
            this.btnMarkReviewed.UseVisualStyleBackColor = false;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1024, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCorrectBill
            // 
            this.btnCorrectBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCorrectBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrectBill.FlatAppearance.BorderSize = 0;
            this.btnCorrectBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrectBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCorrectBill.ForeColor = System.Drawing.Color.White;
            this.btnCorrectBill.Location = new System.Drawing.Point(504, 585);
            this.btnCorrectBill.Name = "btnCorrectBill";
            this.btnCorrectBill.Size = new System.Drawing.Size(170, 35);
            this.btnCorrectBill.TabIndex = 4;
            this.btnCorrectBill.Text = "Correct Bill";
            this.btnCorrectBill.UseVisualStyleBackColor = false;
            this.btnCorrectBill.Click += new System.EventHandler(this.btnCorrectBill_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1136, 52);
            this.panelHeader.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "🔎 Review Bill Disputes";
            // 
            // ReviewDisputesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1136, 627);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnCorrectBill);
            this.Controls.Add(this.dgvDisputes);
            this.Controls.Add(this.btnMarkReviewed);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReviewDisputesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Bill Disputes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisputes)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView dgvDisputes;
        private System.Windows.Forms.Button btnMarkReviewed, btnClose;
        private System.Windows.Forms.Button btnCorrectBill;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
    }
}
