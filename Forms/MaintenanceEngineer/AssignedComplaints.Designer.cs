namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class AssignedComplaints
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignedComplaints));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.btnMarkInProgress = new System.Windows.Forms.Button();
            this.btnMarkResolved = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Assigned Complaints";
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplaints.EnableHeadersVisualStyles = false;
            this.dgvComplaints.Location = new System.Drawing.Point(20, 51);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(910, 393);
            this.dgvComplaints.TabIndex = 7;
            this.dgvComplaints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaints_CellContentClick);
            // 
            // btnMarkInProgress
            // 
            this.btnMarkInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMarkInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkInProgress.FlatAppearance.BorderSize = 0;
            this.btnMarkInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkInProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkInProgress.ForeColor = System.Drawing.Color.White;
            this.btnMarkInProgress.Location = new System.Drawing.Point(20, 455);
            this.btnMarkInProgress.Name = "btnMarkInProgress";
            this.btnMarkInProgress.Size = new System.Drawing.Size(160, 35);
            this.btnMarkInProgress.TabIndex = 8;
            this.btnMarkInProgress.Text = "Mark In Progress";
            this.btnMarkInProgress.UseVisualStyleBackColor = false;
            this.btnMarkInProgress.Click += new System.EventHandler(this.btnMarkInProgress_Click);
            // 
            // btnMarkResolved
            // 
            this.btnMarkResolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMarkResolved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkResolved.FlatAppearance.BorderSize = 0;
            this.btnMarkResolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkResolved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkResolved.ForeColor = System.Drawing.Color.White;
            this.btnMarkResolved.Location = new System.Drawing.Point(190, 455);
            this.btnMarkResolved.Name = "btnMarkResolved";
            this.btnMarkResolved.Size = new System.Drawing.Size(150, 35);
            this.btnMarkResolved.TabIndex = 9;
            this.btnMarkResolved.Text = "Mark Resolved";
            this.btnMarkResolved.UseVisualStyleBackColor = false;
            this.btnMarkResolved.Click += new System.EventHandler(this.btnMarkResolved_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(350, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(840, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AssignedComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvComplaints);
            this.Controls.Add(this.btnMarkInProgress);
            this.Controls.Add(this.btnMarkResolved);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignedComplaints";
            this.Text = "Assigned Complaints";
            this.Load += new System.EventHandler(this.AssignedComplaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.Button btnMarkInProgress;
        private System.Windows.Forms.Button btnMarkResolved;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}