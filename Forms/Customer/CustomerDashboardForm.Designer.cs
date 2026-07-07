namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class CustomerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            this.lblApplicationCount = new System.Windows.Forms.Label();
            this.lblApplicationText = new System.Windows.Forms.Label();
            this.cardApplication = new System.Windows.Forms.Panel();
            this.lblComplaintCount = new System.Windows.Forms.Label();
            this.lblComplaintText = new System.Windows.Forms.Label();
            this.cardComplaint = new System.Windows.Forms.Panel();
            this.lblHistoryCount = new System.Windows.Forms.Label();
            this.lblHistoryText = new System.Windows.Forms.Label();
            this.cardHistory = new System.Windows.Forms.Panel();
            this.lblBillCount = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.cardBill = new System.Windows.Forms.Panel();
            this.lblBillText = new System.Windows.Forms.Label();
            this.lblRecentRecords = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnCurrentBill = new System.Windows.Forms.Button();
            this.btnBillHistory = new System.Windows.Forms.Button();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.btnTrackComplaint = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnTrackApp = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.cardApplication.SuspendLayout();
            this.cardComplaint.SuspendLayout();
            this.cardHistory.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.cardBill.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApplicationCount
            // 
            this.lblApplicationCount.AutoSize = true;
            this.lblApplicationCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblApplicationCount.ForeColor = System.Drawing.Color.White;
            this.lblApplicationCount.Location = new System.Drawing.Point(28, 16);
            this.lblApplicationCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationCount.Name = "lblApplicationCount";
            this.lblApplicationCount.Size = new System.Drawing.Size(23, 25);
            this.lblApplicationCount.TabIndex = 0;
            this.lblApplicationCount.Text = "0";
            // 
            // lblApplicationText
            // 
            this.lblApplicationText.AutoSize = true;
            this.lblApplicationText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApplicationText.ForeColor = System.Drawing.Color.White;
            this.lblApplicationText.Location = new System.Drawing.Point(13, 49);
            this.lblApplicationText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationText.Name = "lblApplicationText";
            this.lblApplicationText.Size = new System.Drawing.Size(121, 19);
            this.lblApplicationText.TabIndex = 1;
            this.lblApplicationText.Text = "Connection Status";
            // 
            // cardApplication
            // 
            this.cardApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.cardApplication.Controls.Add(this.lblApplicationCount);
            this.cardApplication.Controls.Add(this.lblApplicationText);
            this.cardApplication.Location = new System.Drawing.Point(523, 79);
            this.cardApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardApplication.Name = "cardApplication";
            this.cardApplication.Size = new System.Drawing.Size(140, 74);
            this.cardApplication.TabIndex = 4;
            // 
            // lblComplaintCount
            // 
            this.lblComplaintCount.AutoSize = true;
            this.lblComplaintCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblComplaintCount.ForeColor = System.Drawing.Color.White;
            this.lblComplaintCount.Location = new System.Drawing.Point(57, 16);
            this.lblComplaintCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplaintCount.Name = "lblComplaintCount";
            this.lblComplaintCount.Size = new System.Drawing.Size(23, 25);
            this.lblComplaintCount.TabIndex = 0;
            this.lblComplaintCount.Text = "0";
            // 
            // lblComplaintText
            // 
            this.lblComplaintText.AutoSize = true;
            this.lblComplaintText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblComplaintText.ForeColor = System.Drawing.Color.White;
            this.lblComplaintText.Location = new System.Drawing.Point(14, 49);
            this.lblComplaintText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplaintText.Name = "lblComplaintText";
            this.lblComplaintText.Size = new System.Drawing.Size(116, 19);
            this.lblComplaintText.TabIndex = 1;
            this.lblComplaintText.Text = "Open Complaints";
            // 
            // cardComplaint
            // 
            this.cardComplaint.BackColor = System.Drawing.Color.SteelBlue;
            this.cardComplaint.Controls.Add(this.lblComplaintCount);
            this.cardComplaint.Controls.Add(this.lblComplaintText);
            this.cardComplaint.Location = new System.Drawing.Point(358, 79);
            this.cardComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardComplaint.Name = "cardComplaint";
            this.cardComplaint.Size = new System.Drawing.Size(140, 74);
            this.cardComplaint.TabIndex = 3;
            // 
            // lblHistoryCount
            // 
            this.lblHistoryCount.AutoSize = true;
            this.lblHistoryCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHistoryCount.ForeColor = System.Drawing.Color.White;
            this.lblHistoryCount.Location = new System.Drawing.Point(52, 16);
            this.lblHistoryCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoryCount.Name = "lblHistoryCount";
            this.lblHistoryCount.Size = new System.Drawing.Size(23, 25);
            this.lblHistoryCount.TabIndex = 0;
            this.lblHistoryCount.Text = "0";
            // 
            // lblHistoryText
            // 
            this.lblHistoryText.AutoSize = true;
            this.lblHistoryText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHistoryText.ForeColor = System.Drawing.Color.White;
            this.lblHistoryText.Location = new System.Drawing.Point(33, 49);
            this.lblHistoryText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoryText.Name = "lblHistoryText";
            this.lblHistoryText.Size = new System.Drawing.Size(74, 19);
            this.lblHistoryText.TabIndex = 1;
            this.lblHistoryText.Text = "Bill History";
            // 
            // cardHistory
            // 
            this.cardHistory.BackColor = System.Drawing.Color.SteelBlue;
            this.cardHistory.Controls.Add(this.lblHistoryCount);
            this.cardHistory.Controls.Add(this.lblHistoryText);
            this.cardHistory.Location = new System.Drawing.Point(194, 79);
            this.cardHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardHistory.Name = "cardHistory";
            this.cardHistory.Size = new System.Drawing.Size(140, 74);
            this.cardHistory.TabIndex = 2;
            // 
            // lblBillCount
            // 
            this.lblBillCount.AutoSize = true;
            this.lblBillCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBillCount.ForeColor = System.Drawing.Color.White;
            this.lblBillCount.Location = new System.Drawing.Point(34, 16);
            this.lblBillCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillCount.Name = "lblBillCount";
            this.lblBillCount.Size = new System.Drawing.Size(23, 25);
            this.lblBillCount.TabIndex = 0;
            this.lblBillCount.Text = "0";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMain.Controls.Add(this.btnRefresh);
            this.panelMain.Controls.Add(this.dgvNotices);
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Controls.Add(this.lblOverview);
            this.panelMain.Controls.Add(this.cardBill);
            this.panelMain.Controls.Add(this.cardHistory);
            this.panelMain.Controls.Add(this.cardComplaint);
            this.panelMain.Controls.Add(this.cardApplication);
            this.panelMain.Controls.Add(this.lblRecentRecords);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(154, 42);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(698, 484);
            this.panelMain.TabIndex = 5;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(321, 456);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 26);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "⟲";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AllowUserToDeleteRows = false;
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvNotices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvNotices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotices.ColumnHeadersHeight = 36;
            this.dgvNotices.EnableHeadersVisualStyles = false;
            this.dgvNotices.GridColor = System.Drawing.Color.White;
            this.dgvNotices.Location = new System.Drawing.Point(29, 191);
            this.dgvNotices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowHeadersWidth = 51;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(652, 260);
            this.dgvNotices.TabIndex = 6;
            this.dgvNotices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotices_CellContentClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(452, 3);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 50);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Customer";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.lblOverview.Location = new System.Drawing.Point(18, 15);
            this.lblOverview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(288, 37);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Customer Dashboard";
            // 
            // cardBill
            // 
            this.cardBill.BackColor = System.Drawing.Color.SteelBlue;
            this.cardBill.Controls.Add(this.lblBillCount);
            this.cardBill.Controls.Add(this.lblBillText);
            this.cardBill.Location = new System.Drawing.Point(29, 79);
            this.cardBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardBill.Name = "cardBill";
            this.cardBill.Size = new System.Drawing.Size(140, 74);
            this.cardBill.TabIndex = 1;
            this.cardBill.Paint += new System.Windows.Forms.PaintEventHandler(this.cardBill_Paint);
            // 
            // lblBillText
            // 
            this.lblBillText.AutoSize = true;
            this.lblBillText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBillText.ForeColor = System.Drawing.Color.White;
            this.lblBillText.Location = new System.Drawing.Point(35, 49);
            this.lblBillText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillText.Name = "lblBillText";
            this.lblBillText.Size = new System.Drawing.Size(77, 19);
            this.lblBillText.TabIndex = 1;
            this.lblBillText.Text = "Current Bill";
            // 
            // lblRecentRecords
            // 
            this.lblRecentRecords.AutoSize = true;
            this.lblRecentRecords.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRecentRecords.Location = new System.Drawing.Point(26, 164);
            this.lblRecentRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentRecords.Name = "lblRecentRecords";
            this.lblRecentRecords.Size = new System.Drawing.Size(114, 25);
            this.lblRecentRecords.TabIndex = 5;
            this.lblRecentRecords.Text = "View Notice";
            this.lblRecentRecords.Click += new System.EventHandler(this.lblRecentRecords_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(154, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(698, 42);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Water and Sewage Management System - Customer";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(2, 479);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "⏻ Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panelSidebar.Controls.Add(this.btnCurrentBill);
            this.panelSidebar.Controls.Add(this.btnBillHistory);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnComplaint);
            this.panelSidebar.Controls.Add(this.btnTrackComplaint);
            this.panelSidebar.Controls.Add(this.btnConnection);
            this.panelSidebar.Controls.Add(this.btnTrackApp);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(154, 526);
            this.panelSidebar.TabIndex = 4;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnCurrentBill
            // 
            this.btnCurrentBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnCurrentBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentBill.FlatAppearance.BorderSize = 0;
            this.btnCurrentBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnCurrentBill.Location = new System.Drawing.Point(0, 29);
            this.btnCurrentBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurrentBill.Name = "btnCurrentBill";
            this.btnCurrentBill.Size = new System.Drawing.Size(159, 32);
            this.btnCurrentBill.TabIndex = 0;
            this.btnCurrentBill.Text = "🧾 Current Bill";
            this.btnCurrentBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentBill.UseVisualStyleBackColor = false;
            this.btnCurrentBill.Click += new System.EventHandler(this.btnCurrentBill_Click);
            // 
            // btnBillHistory
            // 
            this.btnBillHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnBillHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillHistory.FlatAppearance.BorderSize = 0;
            this.btnBillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBillHistory.ForeColor = System.Drawing.Color.White;
            this.btnBillHistory.Location = new System.Drawing.Point(0, 75);
            this.btnBillHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBillHistory.Name = "btnBillHistory";
            this.btnBillHistory.Size = new System.Drawing.Size(159, 32);
            this.btnBillHistory.TabIndex = 1;
            this.btnBillHistory.Text = "📄 Bill History";
            this.btnBillHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillHistory.UseVisualStyleBackColor = false;
            this.btnBillHistory.Click += new System.EventHandler(this.btnBillHistory_Click);
            // 
            // btnComplaint
            // 
            this.btnComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplaint.FlatAppearance.BorderSize = 0;
            this.btnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnComplaint.ForeColor = System.Drawing.Color.White;
            this.btnComplaint.Location = new System.Drawing.Point(0, 121);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(159, 32);
            this.btnComplaint.TabIndex = 3;
            this.btnComplaint.Text = "📝 Submit Complaint";
            this.btnComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaint.UseVisualStyleBackColor = false;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // btnTrackComplaint
            // 
            this.btnTrackComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnTrackComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackComplaint.FlatAppearance.BorderSize = 0;
            this.btnTrackComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackComplaint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTrackComplaint.ForeColor = System.Drawing.Color.White;
            this.btnTrackComplaint.Location = new System.Drawing.Point(0, 167);
            this.btnTrackComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrackComplaint.Name = "btnTrackComplaint";
            this.btnTrackComplaint.Size = new System.Drawing.Size(159, 32);
            this.btnTrackComplaint.TabIndex = 4;
            this.btnTrackComplaint.Text = "🔎 Track Complaint";
            this.btnTrackComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackComplaint.UseVisualStyleBackColor = false;
            this.btnTrackComplaint.Click += new System.EventHandler(this.btnTrackComplaint_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.Location = new System.Drawing.Point(0, 212);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(159, 32);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "➕ New Connection";
            this.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnTrackApp
            // 
            this.btnTrackApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnTrackApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackApp.FlatAppearance.BorderSize = 0;
            this.btnTrackApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackApp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTrackApp.ForeColor = System.Drawing.Color.White;
            this.btnTrackApp.Location = new System.Drawing.Point(0, 258);
            this.btnTrackApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrackApp.Name = "btnTrackApp";
            this.btnTrackApp.Size = new System.Drawing.Size(159, 32);
            this.btnTrackApp.TabIndex = 6;
            this.btnTrackApp.Text = "📍 Track Application";
            this.btnTrackApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackApp.UseVisualStyleBackColor = false;
            this.btnTrackApp.Click += new System.EventHandler(this.btnTrackApp_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 302);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(159, 32);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "👤 My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(852, 526);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.cardApplication.ResumeLayout(false);
            this.cardApplication.PerformLayout();
            this.cardComplaint.ResumeLayout(false);
            this.cardComplaint.PerformLayout();
            this.cardHistory.ResumeLayout(false);
            this.cardHistory.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.cardBill.ResumeLayout(false);
            this.cardBill.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationCount;
        private System.Windows.Forms.Label lblApplicationText;
        private System.Windows.Forms.Panel cardApplication;
        private System.Windows.Forms.Label lblComplaintCount;
        private System.Windows.Forms.Label lblComplaintText;
        private System.Windows.Forms.Panel cardComplaint;
        private System.Windows.Forms.Label lblHistoryCount;
        private System.Windows.Forms.Label lblHistoryText;
        private System.Windows.Forms.Panel cardHistory;
        private System.Windows.Forms.Label lblBillCount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Panel cardBill;
        private System.Windows.Forms.Label lblBillText;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnCurrentBill;
        private System.Windows.Forms.Button btnBillHistory;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.Button btnTrackComplaint;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnTrackApp;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblRecentRecords;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.Button btnRefresh;
    }
}