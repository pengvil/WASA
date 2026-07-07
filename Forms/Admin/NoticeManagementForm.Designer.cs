namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class NoticeManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeManagementForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblNewNotice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFooterBorder = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnPublish = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblNTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(619, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(830, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(7)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblPageIcon);
            this.panel1.Controls.Add(this.lblNewNotice);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 82);
            this.panel1.TabIndex = 14;
            // 
            // lblPageIcon
            // 
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageIcon.ForeColor = System.Drawing.Color.White;
            this.lblPageIcon.Location = new System.Drawing.Point(14, 16);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.Size = new System.Drawing.Size(59, 52);
            this.lblPageIcon.TabIndex = 3;
            this.lblPageIcon.Text = "📢";
            // 
            // lblNewNotice
            // 
            this.lblNewNotice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNewNotice.Location = new System.Drawing.Point(81, 46);
            this.lblNewNotice.Name = "lblNewNotice";
            this.lblNewNotice.Size = new System.Drawing.Size(435, 22);
            this.lblNewNotice.TabIndex = 2;
            this.lblNewNotice.Text = "Publish new notices and manage existing ones";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(79, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Notice Management";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelFooterBorder
            // 
            this.panelFooterBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelFooterBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterBorder.Location = new System.Drawing.Point(0, 572);
            this.panelFooterBorder.Name = "panelFooterBorder";
            this.panelFooterBorder.Size = new System.Drawing.Size(982, 1);
            this.panelFooterBorder.TabIndex = 15;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.btnDelete);
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.btnPublish);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 515);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(982, 57);
            this.panelFooter.TabIndex = 16;
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(33)))), ((int)(((byte)(168)))));
            this.btnPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(28)))), ((int)(((byte)(135)))));
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.Location = new System.Drawing.Point(21, 6);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(181, 46);
            this.btnPublish.TabIndex = 40;
            this.btnPublish.Text = "Publish Notice";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelForm);
            this.panelContent.Controls.Add(this.dgvNotices);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 82);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(16);
            this.panelContent.Size = new System.Drawing.Size(982, 433);
            this.panelContent.TabIndex = 17;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.lblNTitle);
            this.panelForm.Controls.Add(this.txtTitle);
            this.panelForm.Controls.Add(this.lblDesc);
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.lblArea);
            this.panelForm.Controls.Add(this.txtArea);
            this.panelForm.Controls.Add(this.lblType);
            this.panelForm.Controls.Add(this.cmbType);
            this.panelForm.Location = new System.Drawing.Point(19, 6);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(927, 207);
            this.panelForm.TabIndex = 42;
            // 
            // lblNTitle
            // 
            this.lblNTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNTitle.Location = new System.Drawing.Point(182, 35);
            this.lblNTitle.Name = "lblNTitle";
            this.lblNTitle.Size = new System.Drawing.Size(155, 20);
            this.lblNTitle.TabIndex = 40;
            this.lblNTitle.Text = "Title *";
            this.lblNTitle.Click += new System.EventHandler(this.lblNTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(342, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(400, 25);
            this.txtTitle.TabIndex = 41;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDesc.Location = new System.Drawing.Point(182, 70);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 20);
            this.lblDesc.TabIndex = 42;
            this.lblDesc.Text = "Description *";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(342, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 55);
            this.txtDescription.TabIndex = 43;
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblArea.Location = new System.Drawing.Point(182, 135);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(155, 20);
            this.lblArea.TabIndex = 44;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(342, 132);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(200, 25);
            this.txtArea.TabIndex = 45;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblType.Location = new System.Drawing.Point(182, 165);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(155, 20);
            this.lblType.TabIndex = 46;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.Items.AddRange(new object[] {
            "General",
            "Maintenance",
            "Emergency"});
            this.cmbType.Location = new System.Drawing.Point(342, 163);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(180, 25);
            this.cmbType.TabIndex = 47;
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotices.ColumnHeadersHeight = 29;
            this.dgvNotices.EnableHeadersVisualStyles = false;
            this.dgvNotices.Location = new System.Drawing.Point(21, 219);
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowHeadersWidth = 51;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(918, 195);
            this.dgvNotices.TabIndex = 41;
            // 
            // NoticeManagementForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelFooterBorder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NoticeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice Management";
            this.Load += new System.EventHandler(this.NoticeManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnDelete, btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblNewNotice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFooterBorder;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblNTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
    }
}
