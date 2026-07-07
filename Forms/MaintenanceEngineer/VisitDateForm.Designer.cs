namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class VisitDateForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitDateForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Set Expected Visit Date";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(20, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(600, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Select a task from the list, then choose the date you plan to visit.";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.Location = new System.Drawing.Point(20, 72);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(910, 360);
            this.dgvTasks.TabIndex = 2;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVisitDate.Location = new System.Drawing.Point(20, 447);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(110, 24);
            this.lblVisitDate.TabIndex = 3;
            this.lblVisitDate.Text = "Visit Date:";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(135, 444);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(210, 25);
            this.dtpVisitDate.TabIndex = 4;
            this.dtpVisitDate.Value = new System.DateTime(2026, 5, 20, 0, 0, 0, 0);
            this.dtpVisitDate.ValueChanged += new System.EventHandler(this.dtpVisitDate_ValueChanged);
            // 
            // btnSetDate
            // 
            this.btnSetDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnSetDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetDate.FlatAppearance.BorderSize = 0;
            this.btnSetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetDate.ForeColor = System.Drawing.Color.White;
            this.btnSetDate.Location = new System.Drawing.Point(360, 442);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(150, 36);
            this.btnSetDate.TabIndex = 5;
            this.btnSetDate.Text = "Set Visit Date";
            this.btnSetDate.UseVisualStyleBackColor = false;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(520, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(840, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VisitDateForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisitDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Expected Visit Date";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label          lblTitle, lblInfo, lblVisitDate;
        private System.Windows.Forms.DataGridView   dgvTasks;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Button         btnSetDate, btnRefresh, btnClose;
    }
}
