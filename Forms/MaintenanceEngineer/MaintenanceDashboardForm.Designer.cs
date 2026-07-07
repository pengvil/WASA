namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class MaintenanceDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceDashboardForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCompletionReport = new System.Windows.Forms.Button();
            this.btnInspectionNotes = new System.Windows.Forms.Button();
            this.btnVisitDate = new System.Windows.Forms.Button();
            this.btnRepairProgress = new System.Windows.Forms.Button();
            this.btnMaintenanceTasks = new System.Windows.Forms.Button();
            this.btnAssignedComplaints = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cardCompletionReport = new System.Windows.Forms.Panel();
            this.lblReportText = new System.Windows.Forms.Label();
            this.lblReportNumber = new System.Windows.Forms.Label();
            this.accentCompletionReport = new System.Windows.Forms.Panel();
            this.cardInspectionNotes = new System.Windows.Forms.Panel();
            this.lblInspectionText = new System.Windows.Forms.Label();
            this.lblInspectionNumber = new System.Windows.Forms.Label();
            this.accentInspectionNotes = new System.Windows.Forms.Panel();
            this.cardRepairProgress = new System.Windows.Forms.Panel();
            this.lblRepairText = new System.Windows.Forms.Label();
            this.lblRepairNumber = new System.Windows.Forms.Label();
            this.accentRepairProgress = new System.Windows.Forms.Panel();
            this.cardMaintenanceTasks = new System.Windows.Forms.Panel();
            this.lblMaintenanceText = new System.Windows.Forms.Label();
            this.lblMaintenanceNumber = new System.Windows.Forms.Label();
            this.accentMaintenanceTasks = new System.Windows.Forms.Panel();
            this.cardAssignedComplaints = new System.Windows.Forms.Panel();
            this.lblAssignedText = new System.Windows.Forms.Label();
            this.lblAssignedNumber = new System.Windows.Forms.Label();
            this.accentAssignedComplaints = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelBrand.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardCompletionReport.SuspendLayout();
            this.cardInspectionNotes.SuspendLayout();
            this.cardRepairProgress.SuspendLayout();
            this.cardMaintenanceTasks.SuspendLayout();
            this.cardAssignedComplaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnCompletionReport);
            this.panelSidebar.Controls.Add(this.btnInspectionNotes);
            this.panelSidebar.Controls.Add(this.btnVisitDate);
            this.panelSidebar.Controls.Add(this.btnRepairProgress);
            this.panelSidebar.Controls.Add(this.btnMaintenanceTasks);
            this.panelSidebar.Controls.Add(this.btnAssignedComplaints);
            this.panelSidebar.Controls.Add(this.panelLogout);
            this.panelSidebar.Controls.Add(this.panelBrand);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(255, 606);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Location = new System.Drawing.Point(0, 467);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(263, 46);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCompletionReport
            // 
            this.btnCompletionReport.BackColor = System.Drawing.Color.Transparent;
            this.btnCompletionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletionReport.FlatAppearance.BorderSize = 0;
            this.btnCompletionReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnCompletionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletionReport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCompletionReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompletionReport.Location = new System.Drawing.Point(0, 415);
            this.btnCompletionReport.Name = "btnCompletionReport";
            this.btnCompletionReport.Size = new System.Drawing.Size(260, 46);
            this.btnCompletionReport.TabIndex = 5;
            this.btnCompletionReport.Text = "Completion Report";
            this.btnCompletionReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompletionReport.UseVisualStyleBackColor = false;
            this.btnCompletionReport.Click += new System.EventHandler(this.btnCompletionReport_Click);
            // 
            // btnInspectionNotes
            // 
            this.btnInspectionNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnInspectionNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInspectionNotes.FlatAppearance.BorderSize = 0;
            this.btnInspectionNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnInspectionNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectionNotes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnInspectionNotes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInspectionNotes.Location = new System.Drawing.Point(0, 348);
            this.btnInspectionNotes.Name = "btnInspectionNotes";
            this.btnInspectionNotes.Size = new System.Drawing.Size(260, 61);
            this.btnInspectionNotes.TabIndex = 4;
            this.btnInspectionNotes.Text = "Inspection Notes";
            this.btnInspectionNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspectionNotes.UseVisualStyleBackColor = false;
            this.btnInspectionNotes.Click += new System.EventHandler(this.btnInspectionNotes_Click);
            // 
            // btnVisitDate
            // 
            this.btnVisitDate.BackColor = System.Drawing.Color.Transparent;
            this.btnVisitDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitDate.FlatAppearance.BorderSize = 0;
            this.btnVisitDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnVisitDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnVisitDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVisitDate.Location = new System.Drawing.Point(0, 296);
            this.btnVisitDate.Name = "btnVisitDate";
            this.btnVisitDate.Size = new System.Drawing.Size(260, 46);
            this.btnVisitDate.TabIndex = 3;
            this.btnVisitDate.Text = "Set Visit Date";
            this.btnVisitDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitDate.UseVisualStyleBackColor = false;
            this.btnVisitDate.Click += new System.EventHandler(this.btnVisitDate_Click);
            // 
            // btnRepairProgress
            // 
            this.btnRepairProgress.BackColor = System.Drawing.Color.Transparent;
            this.btnRepairProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepairProgress.FlatAppearance.BorderSize = 0;
            this.btnRepairProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnRepairProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepairProgress.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRepairProgress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRepairProgress.Location = new System.Drawing.Point(0, 244);
            this.btnRepairProgress.Name = "btnRepairProgress";
            this.btnRepairProgress.Size = new System.Drawing.Size(264, 46);
            this.btnRepairProgress.TabIndex = 2;
            this.btnRepairProgress.Text = "Update Repair Progress";
            this.btnRepairProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepairProgress.UseVisualStyleBackColor = false;
            this.btnRepairProgress.Click += new System.EventHandler(this.btnRepairProgress_Click);
            // 
            // btnMaintenanceTasks
            // 
            this.btnMaintenanceTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintenanceTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenanceTasks.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnMaintenanceTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceTasks.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMaintenanceTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenanceTasks.Location = new System.Drawing.Point(0, 192);
            this.btnMaintenanceTasks.Name = "btnMaintenanceTasks";
            this.btnMaintenanceTasks.Size = new System.Drawing.Size(260, 46);
            this.btnMaintenanceTasks.TabIndex = 1;
            this.btnMaintenanceTasks.Text = "Maintenance Tasks";
            this.btnMaintenanceTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenanceTasks.UseVisualStyleBackColor = false;
            this.btnMaintenanceTasks.Click += new System.EventHandler(this.btnMaintenanceTasks_Click);
            // 
            // btnAssignedComplaints
            // 
            this.btnAssignedComplaints.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignedComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignedComplaints.FlatAppearance.BorderSize = 0;
            this.btnAssignedComplaints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(84)))));
            this.btnAssignedComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignedComplaints.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAssignedComplaints.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAssignedComplaints.Location = new System.Drawing.Point(0, 143);
            this.btnAssignedComplaints.Name = "btnAssignedComplaints";
            this.btnAssignedComplaints.Size = new System.Drawing.Size(260, 46);
            this.btnAssignedComplaints.TabIndex = 0;
            this.btnAssignedComplaints.Text = "Assigned Complaints";
            this.btnAssignedComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignedComplaints.UseVisualStyleBackColor = false;
            this.btnAssignedComplaints.Click += new System.EventHandler(this.btnAssignedComplaints_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogout.Location = new System.Drawing.Point(0, 534);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(255, 72);
            this.panelLogout.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(255, 72);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "⏻ Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panelBrand.Controls.Add(this.lblBrandTitle);
            this.panelBrand.Controls.Add(this.lblBrandSubtitle);
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrand.Location = new System.Drawing.Point(0, 0);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(255, 143);
            this.panelBrand.TabIndex = 0;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(28, 43);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(177, 25);
            this.lblBrandTitle.TabIndex = 1;
            this.lblBrandTitle.Text = "Water and Sewage";
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.AutoSize = true;
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandSubtitle.Location = new System.Drawing.Point(28, 79);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(191, 25);
            this.lblBrandSubtitle.TabIndex = 2;
            this.lblBrandSubtitle.Text = "Management System";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(255, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(731, 143);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Maintenance Engineer Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(31, 94);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(264, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Back, Maintenance Engineer";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.panelContent.Controls.Add(this.cardCompletionReport);
            this.panelContent.Controls.Add(this.cardInspectionNotes);
            this.panelContent.Controls.Add(this.cardRepairProgress);
            this.panelContent.Controls.Add(this.cardMaintenanceTasks);
            this.panelContent.Controls.Add(this.cardAssignedComplaints);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(255, 143);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(731, 463);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // cardCompletionReport
            // 
            this.cardCompletionReport.BackColor = System.Drawing.Color.White;
            this.cardCompletionReport.Controls.Add(this.lblReportText);
            this.cardCompletionReport.Controls.Add(this.lblReportNumber);
            this.cardCompletionReport.Controls.Add(this.accentCompletionReport);
            this.cardCompletionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardCompletionReport.Location = new System.Drawing.Point(447, 174);
            this.cardCompletionReport.Name = "cardCompletionReport";
            this.cardCompletionReport.Size = new System.Drawing.Size(209, 129);
            this.cardCompletionReport.TabIndex = 0;
            this.cardCompletionReport.Click += new System.EventHandler(this.btnCompletionReport_Click);
            // 
            // lblReportText
            // 
            this.lblReportText.AutoSize = true;
            this.lblReportText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblReportText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblReportText.Location = new System.Drawing.Point(40, 78);
            this.lblReportText.Name = "lblReportText";
            this.lblReportText.Size = new System.Drawing.Size(137, 19);
            this.lblReportText.TabIndex = 2;
            this.lblReportText.Text = "Completion Report";
            // 
            // lblReportNumber
            // 
            this.lblReportNumber.AutoSize = true;
            this.lblReportNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblReportNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.lblReportNumber.Location = new System.Drawing.Point(38, 25);
            this.lblReportNumber.Name = "lblReportNumber";
            this.lblReportNumber.Size = new System.Drawing.Size(33, 37);
            this.lblReportNumber.TabIndex = 1;
            this.lblReportNumber.Text = "0";
            this.lblReportNumber.Click += new System.EventHandler(this.lblReportNumber_Click);
            // 
            // accentCompletionReport
            // 
            this.accentCompletionReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.accentCompletionReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentCompletionReport.Location = new System.Drawing.Point(0, 0);
            this.accentCompletionReport.Name = "accentCompletionReport";
            this.accentCompletionReport.Size = new System.Drawing.Size(13, 129);
            this.accentCompletionReport.TabIndex = 0;
            // 
            // cardInspectionNotes
            // 
            this.cardInspectionNotes.BackColor = System.Drawing.Color.White;
            this.cardInspectionNotes.Controls.Add(this.lblInspectionText);
            this.cardInspectionNotes.Controls.Add(this.lblInspectionNumber);
            this.cardInspectionNotes.Controls.Add(this.accentInspectionNotes);
            this.cardInspectionNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardInspectionNotes.Location = new System.Drawing.Point(130, 324);
            this.cardInspectionNotes.Name = "cardInspectionNotes";
            this.cardInspectionNotes.Size = new System.Drawing.Size(209, 129);
            this.cardInspectionNotes.TabIndex = 0;
            this.cardInspectionNotes.Click += new System.EventHandler(this.btnInspectionNotes_Click);
            // 
            // lblInspectionText
            // 
            this.lblInspectionText.AutoSize = true;
            this.lblInspectionText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblInspectionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInspectionText.Location = new System.Drawing.Point(40, 78);
            this.lblInspectionText.Name = "lblInspectionText";
            this.lblInspectionText.Size = new System.Drawing.Size(120, 19);
            this.lblInspectionText.TabIndex = 2;
            this.lblInspectionText.Text = "Inspection Notes";
            // 
            // lblInspectionNumber
            // 
            this.lblInspectionNumber.AutoSize = true;
            this.lblInspectionNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInspectionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.lblInspectionNumber.Location = new System.Drawing.Point(38, 25);
            this.lblInspectionNumber.Name = "lblInspectionNumber";
            this.lblInspectionNumber.Size = new System.Drawing.Size(33, 37);
            this.lblInspectionNumber.TabIndex = 1;
            this.lblInspectionNumber.Text = "0";
            this.lblInspectionNumber.Click += new System.EventHandler(this.lblInspectionNumber_Click);
            // 
            // accentInspectionNotes
            // 
            this.accentInspectionNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.accentInspectionNotes.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentInspectionNotes.Location = new System.Drawing.Point(0, 0);
            this.accentInspectionNotes.Name = "accentInspectionNotes";
            this.accentInspectionNotes.Size = new System.Drawing.Size(13, 129);
            this.accentInspectionNotes.TabIndex = 0;
            // 
            // cardRepairProgress
            // 
            this.cardRepairProgress.BackColor = System.Drawing.Color.White;
            this.cardRepairProgress.Controls.Add(this.lblRepairText);
            this.cardRepairProgress.Controls.Add(this.lblRepairNumber);
            this.cardRepairProgress.Controls.Add(this.accentRepairProgress);
            this.cardRepairProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardRepairProgress.Location = new System.Drawing.Point(130, 174);
            this.cardRepairProgress.Name = "cardRepairProgress";
            this.cardRepairProgress.Size = new System.Drawing.Size(209, 129);
            this.cardRepairProgress.TabIndex = 0;
            this.cardRepairProgress.Click += new System.EventHandler(this.btnRepairProgress_Click);
            this.cardRepairProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.cardRepairProgress_Paint);
            // 
            // lblRepairText
            // 
            this.lblRepairText.AutoSize = true;
            this.lblRepairText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRepairText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRepairText.Location = new System.Drawing.Point(40, 78);
            this.lblRepairText.Name = "lblRepairText";
            this.lblRepairText.Size = new System.Drawing.Size(116, 19);
            this.lblRepairText.TabIndex = 2;
            this.lblRepairText.Text = "Repair Progress";
            // 
            // lblRepairNumber
            // 
            this.lblRepairNumber.AutoSize = true;
            this.lblRepairNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRepairNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.lblRepairNumber.Location = new System.Drawing.Point(38, 25);
            this.lblRepairNumber.Name = "lblRepairNumber";
            this.lblRepairNumber.Size = new System.Drawing.Size(33, 37);
            this.lblRepairNumber.TabIndex = 1;
            this.lblRepairNumber.Text = "0";
            this.lblRepairNumber.Click += new System.EventHandler(this.lblRepairNumber_Click);
            // 
            // accentRepairProgress
            // 
            this.accentRepairProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.accentRepairProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentRepairProgress.Location = new System.Drawing.Point(0, 0);
            this.accentRepairProgress.Name = "accentRepairProgress";
            this.accentRepairProgress.Size = new System.Drawing.Size(13, 129);
            this.accentRepairProgress.TabIndex = 0;
            // 
            // cardMaintenanceTasks
            // 
            this.cardMaintenanceTasks.BackColor = System.Drawing.Color.White;
            this.cardMaintenanceTasks.Controls.Add(this.lblMaintenanceText);
            this.cardMaintenanceTasks.Controls.Add(this.lblMaintenanceNumber);
            this.cardMaintenanceTasks.Controls.Add(this.accentMaintenanceTasks);
            this.cardMaintenanceTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardMaintenanceTasks.Location = new System.Drawing.Point(447, 18);
            this.cardMaintenanceTasks.Name = "cardMaintenanceTasks";
            this.cardMaintenanceTasks.Size = new System.Drawing.Size(209, 129);
            this.cardMaintenanceTasks.TabIndex = 0;
            this.cardMaintenanceTasks.Click += new System.EventHandler(this.btnMaintenanceTasks_Click);
            this.cardMaintenanceTasks.Paint += new System.Windows.Forms.PaintEventHandler(this.cardMaintenanceTasks_Paint);
            // 
            // lblMaintenanceText
            // 
            this.lblMaintenanceText.AutoSize = true;
            this.lblMaintenanceText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMaintenanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMaintenanceText.Location = new System.Drawing.Point(40, 78);
            this.lblMaintenanceText.Name = "lblMaintenanceText";
            this.lblMaintenanceText.Size = new System.Drawing.Size(133, 19);
            this.lblMaintenanceText.TabIndex = 2;
            this.lblMaintenanceText.Text = "Maintenance Tasks";
            // 
            // lblMaintenanceNumber
            // 
            this.lblMaintenanceNumber.AutoSize = true;
            this.lblMaintenanceNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblMaintenanceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.lblMaintenanceNumber.Location = new System.Drawing.Point(38, 25);
            this.lblMaintenanceNumber.Name = "lblMaintenanceNumber";
            this.lblMaintenanceNumber.Size = new System.Drawing.Size(33, 37);
            this.lblMaintenanceNumber.TabIndex = 1;
            this.lblMaintenanceNumber.Text = "0";
            this.lblMaintenanceNumber.Click += new System.EventHandler(this.lblMaintenanceNumber_Click);
            // 
            // accentMaintenanceTasks
            // 
            this.accentMaintenanceTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(30)))));
            this.accentMaintenanceTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentMaintenanceTasks.Location = new System.Drawing.Point(0, 0);
            this.accentMaintenanceTasks.Name = "accentMaintenanceTasks";
            this.accentMaintenanceTasks.Size = new System.Drawing.Size(13, 129);
            this.accentMaintenanceTasks.TabIndex = 0;
            // 
            // cardAssignedComplaints
            // 
            this.cardAssignedComplaints.BackColor = System.Drawing.Color.White;
            this.cardAssignedComplaints.Controls.Add(this.lblAssignedText);
            this.cardAssignedComplaints.Controls.Add(this.lblAssignedNumber);
            this.cardAssignedComplaints.Controls.Add(this.accentAssignedComplaints);
            this.cardAssignedComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardAssignedComplaints.Location = new System.Drawing.Point(130, 18);
            this.cardAssignedComplaints.Name = "cardAssignedComplaints";
            this.cardAssignedComplaints.Size = new System.Drawing.Size(209, 129);
            this.cardAssignedComplaints.TabIndex = 0;
            this.cardAssignedComplaints.Click += new System.EventHandler(this.btnAssignedComplaints_Click);
            this.cardAssignedComplaints.Paint += new System.Windows.Forms.PaintEventHandler(this.cardAssignedComplaints_Paint);
            // 
            // lblAssignedText
            // 
            this.lblAssignedText.AutoSize = true;
            this.lblAssignedText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAssignedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAssignedText.Location = new System.Drawing.Point(40, 78);
            this.lblAssignedText.Name = "lblAssignedText";
            this.lblAssignedText.Size = new System.Drawing.Size(148, 19);
            this.lblAssignedText.TabIndex = 2;
            this.lblAssignedText.Text = "Assigned Complaints";
            // 
            // lblAssignedNumber
            // 
            this.lblAssignedNumber.AutoSize = true;
            this.lblAssignedNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAssignedNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.lblAssignedNumber.Location = new System.Drawing.Point(38, 25);
            this.lblAssignedNumber.Name = "lblAssignedNumber";
            this.lblAssignedNumber.Size = new System.Drawing.Size(33, 37);
            this.lblAssignedNumber.TabIndex = 1;
            this.lblAssignedNumber.Text = "0";
            this.lblAssignedNumber.Click += new System.EventHandler(this.lblAssignedNumber_Click);
            // 
            // accentAssignedComplaints
            // 
            this.accentAssignedComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(210)))));
            this.accentAssignedComplaints.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentAssignedComplaints.Location = new System.Drawing.Point(0, 0);
            this.accentAssignedComplaints.Name = "accentAssignedComplaints";
            this.accentAssignedComplaints.Size = new System.Drawing.Size(13, 129);
            this.accentAssignedComplaints.TabIndex = 0;
            // 
            // MaintenanceDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(986, 606);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaintenanceDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Engineer Dashboard";
            this.Load += new System.EventHandler(this.MaintenanceDashboardForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardCompletionReport.ResumeLayout(false);
            this.cardCompletionReport.PerformLayout();
            this.cardInspectionNotes.ResumeLayout(false);
            this.cardInspectionNotes.PerformLayout();
            this.cardRepairProgress.ResumeLayout(false);
            this.cardRepairProgress.PerformLayout();
            this.cardMaintenanceTasks.ResumeLayout(false);
            this.cardMaintenanceTasks.PerformLayout();
            this.cardAssignedComplaints.ResumeLayout(false);
            this.cardAssignedComplaints.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Button btnAssignedComplaints;
        private System.Windows.Forms.Button btnMaintenanceTasks;
        private System.Windows.Forms.Button btnRepairProgress;
        private System.Windows.Forms.Button btnVisitDate;
        private System.Windows.Forms.Button btnInspectionNotes;
        private System.Windows.Forms.Button btnCompletionReport;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel cardAssignedComplaints;
        private System.Windows.Forms.Panel accentAssignedComplaints;
        private System.Windows.Forms.Label lblAssignedNumber;
        private System.Windows.Forms.Label lblAssignedText;
        private System.Windows.Forms.Panel cardMaintenanceTasks;
        private System.Windows.Forms.Panel accentMaintenanceTasks;
        private System.Windows.Forms.Label lblMaintenanceNumber;
        private System.Windows.Forms.Label lblMaintenanceText;
        private System.Windows.Forms.Panel cardRepairProgress;
        private System.Windows.Forms.Panel accentRepairProgress;
        private System.Windows.Forms.Label lblRepairNumber;
        private System.Windows.Forms.Label lblRepairText;
        private System.Windows.Forms.Panel cardInspectionNotes;
        private System.Windows.Forms.Panel accentInspectionNotes;
        private System.Windows.Forms.Label lblInspectionNumber;
        private System.Windows.Forms.Label lblInspectionText;
        private System.Windows.Forms.Panel cardCompletionReport;
        private System.Windows.Forms.Panel accentCompletionReport;
        private System.Windows.Forms.Label lblReportNumber;
        private System.Windows.Forms.Label lblReportText;
    }
}
