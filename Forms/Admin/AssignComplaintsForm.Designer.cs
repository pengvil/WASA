namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class AssignComplaintsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignComplaintsForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEngineer = new System.Windows.Forms.Label();
            this.cmbEngineer = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.panelFooterBorder = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelFooterBorder.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(83, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assign Complaints";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblEngineer
            // 
            this.lblEngineer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEngineer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblEngineer.Location = new System.Drawing.Point(3, 19);
            this.lblEngineer.Name = "lblEngineer";
            this.lblEngineer.Size = new System.Drawing.Size(160, 24);
            this.lblEngineer.TabIndex = 2;
            this.lblEngineer.Text = "Assign to Engineer:";
            // 
            // cmbEngineer
            // 
            this.cmbEngineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngineer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEngineer.Location = new System.Drawing.Point(169, 14);
            this.cmbEngineer.Name = "cmbEngineer";
            this.cmbEngineer.Size = new System.Drawing.Size(250, 25);
            this.cmbEngineer.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(65)))), ((int)(((byte)(12)))));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(435, 14);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(120, 31);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(140)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(713, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 31);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(870, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(20)))), ((int)(((byte)(7)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblPageIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(982, 83);
            this.panelHeader.TabIndex = 7;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitle.Location = new System.Drawing.Point(85, 51);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 22);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Select a complaint, pick an engineer, then assign";
            // 
            // lblPageIcon
            // 
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPageIcon.Location = new System.Drawing.Point(37, 15);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.Size = new System.Drawing.Size(57, 52);
            this.lblPageIcon.TabIndex = 3;
            this.lblPageIcon.Text = "⚑";
            // 
            // panelFooterBorder
            // 
            this.panelFooterBorder.BackColor = System.Drawing.Color.White;
            this.panelFooterBorder.Controls.Add(this.btnClose);
            this.panelFooterBorder.Controls.Add(this.btnRefresh);
            this.panelFooterBorder.Controls.Add(this.btnAssign);
            this.panelFooterBorder.Controls.Add(this.lblEngineer);
            this.panelFooterBorder.Controls.Add(this.cmbEngineer);
            this.panelFooterBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterBorder.Location = new System.Drawing.Point(0, 513);
            this.panelFooterBorder.Name = "panelFooterBorder";
            this.panelFooterBorder.Size = new System.Drawing.Size(982, 60);
            this.panelFooterBorder.TabIndex = 8;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvComplaints);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(16);
            this.panelContent.Size = new System.Drawing.Size(982, 513);
            this.panelContent.TabIndex = 9;
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvComplaints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplaints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComplaints.ColumnHeadersHeight = 36;
            this.dgvComplaints.EnableHeadersVisualStyles = false;
            this.dgvComplaints.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvComplaints.Location = new System.Drawing.Point(7, 136);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.RowHeadersWidth = 51;
            this.dgvComplaints.RowTemplate.Height = 32;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(964, 329);
            this.dgvComplaints.TabIndex = 2;
            // 
            // AssignComplaintsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooterBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AssignComplaintsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Complaints";
            this.panelHeader.ResumeLayout(false);
            this.panelFooterBorder.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTitle, lblEngineer;
        private System.Windows.Forms.ComboBox cmbEngineer;
        private System.Windows.Forms.Button btnAssign, btnRefresh, btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFooterBorder;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvComplaints;
    }
}
