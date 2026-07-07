namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ServiceOfficerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceOfficerDashboardForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMeterReading = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnReviewDisputes = new System.Windows.Forms.Button();
            this.btnReviewConnections = new System.Windows.Forms.Button();
            this.btnVerifyDocuments = new System.Windows.Forms.Button();
            this.btnScheduleInstallation = new System.Windows.Forms.Button();
            this.btnBillingReport = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblOverview = new System.Windows.Forms.Label();
            this.cardMeter = new System.Windows.Forms.Panel();
            this.lblMeterCount = new System.Windows.Forms.Label();
            this.lblMeterText = new System.Windows.Forms.Label();
            this.cardBill = new System.Windows.Forms.Panel();
            this.lblPaidBillCount = new System.Windows.Forms.Label();
            this.lblPaidBillText = new System.Windows.Forms.Label();
            this.cardDispute = new System.Windows.Forms.Panel();
            this.lblDisputeCount = new System.Windows.Forms.Label();
            this.lblDisputeText = new System.Windows.Forms.Label();
            this.cardConnection = new System.Windows.Forms.Panel();
            this.lblConnectionCount = new System.Windows.Forms.Label();
            this.lblConnectionText = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.cardMeter.SuspendLayout();
            this.cardBill.SuspendLayout();
            this.cardDispute.SuspendLayout();
            this.cardConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lbl_Welcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(911, 52);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(554, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Water and Sewage Management System - Service Officer";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Welcome.Location = new System.Drawing.Point(559, 18);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(349, 19);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Welcome, Service Officer";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnLogout.Location = new System.Drawing.Point(15, 421);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 31);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panelSidebar.Controls.Add(this.btnMeterReading);
            this.panelSidebar.Controls.Add(this.btnGenerateBill);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnReviewDisputes);
            this.panelSidebar.Controls.Add(this.btnReviewConnections);
            this.panelSidebar.Controls.Add(this.btnVerifyDocuments);
            this.panelSidebar.Controls.Add(this.btnScheduleInstallation);
            this.panelSidebar.Controls.Add(this.btnBillingReport);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 52);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(227, 470);
            this.panelSidebar.TabIndex = 5;
            // 
            // btnMeterReading
            // 
            this.btnMeterReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnMeterReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeterReading.FlatAppearance.BorderSize = 0;
            this.btnMeterReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeterReading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMeterReading.ForeColor = System.Drawing.Color.White;
            this.btnMeterReading.Location = new System.Drawing.Point(6, 2);
            this.btnMeterReading.Name = "btnMeterReading";
            this.btnMeterReading.Size = new System.Drawing.Size(224, 50);
            this.btnMeterReading.TabIndex = 1;
            this.btnMeterReading.Text = "📊 Meter Read and Bill Generate";
            this.btnMeterReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeterReading.UseVisualStyleBackColor = false;
            this.btnMeterReading.Click += new System.EventHandler(this.btnMeterReading_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(6, 55);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(212, 40);
            this.btnGenerateBill.TabIndex = 2;
            this.btnGenerateBill.Text = "💵 Customer Bill List";
            this.btnGenerateBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnListofBill_Click);
            // 
            // btnReviewDisputes
            // 
            this.btnReviewDisputes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnReviewDisputes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewDisputes.FlatAppearance.BorderSize = 0;
            this.btnReviewDisputes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewDisputes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReviewDisputes.ForeColor = System.Drawing.Color.White;
            this.btnReviewDisputes.Location = new System.Drawing.Point(6, 103);
            this.btnReviewDisputes.Name = "btnReviewDisputes";
            this.btnReviewDisputes.Size = new System.Drawing.Size(212, 40);
            this.btnReviewDisputes.TabIndex = 3;
            this.btnReviewDisputes.Text = "🔍 Review Disputes";
            this.btnReviewDisputes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewDisputes.UseVisualStyleBackColor = false;
            this.btnReviewDisputes.Click += new System.EventHandler(this.btnReviewDisputes_Click);
            // 
            // btnReviewConnections
            // 
            this.btnReviewConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnReviewConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewConnections.FlatAppearance.BorderSize = 0;
            this.btnReviewConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewConnections.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReviewConnections.ForeColor = System.Drawing.Color.White;
            this.btnReviewConnections.Location = new System.Drawing.Point(6, 204);
            this.btnReviewConnections.Name = "btnReviewConnections";
            this.btnReviewConnections.Size = new System.Drawing.Size(212, 40);
            this.btnReviewConnections.TabIndex = 5;
            this.btnReviewConnections.Text = "📋 Review Applications";
            this.btnReviewConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewConnections.UseVisualStyleBackColor = false;
            this.btnReviewConnections.Click += new System.EventHandler(this.btnReviewConnections_Click);
            // 
            // btnVerifyDocuments
            // 
            this.btnVerifyDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnVerifyDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyDocuments.FlatAppearance.BorderSize = 0;
            this.btnVerifyDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyDocuments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVerifyDocuments.ForeColor = System.Drawing.Color.White;
            this.btnVerifyDocuments.Location = new System.Drawing.Point(6, 151);
            this.btnVerifyDocuments.Name = "btnVerifyDocuments";
            this.btnVerifyDocuments.Size = new System.Drawing.Size(212, 40);
            this.btnVerifyDocuments.TabIndex = 6;
            this.btnVerifyDocuments.Text = "✅ Verify Documents";
            this.btnVerifyDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifyDocuments.UseVisualStyleBackColor = false;
            this.btnVerifyDocuments.Click += new System.EventHandler(this.btnVerifyDocuments_Click);
            // 
            // btnScheduleInstallation
            // 
            this.btnScheduleInstallation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnScheduleInstallation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleInstallation.FlatAppearance.BorderSize = 0;
            this.btnScheduleInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleInstallation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnScheduleInstallation.ForeColor = System.Drawing.Color.White;
            this.btnScheduleInstallation.Location = new System.Drawing.Point(6, 258);
            this.btnScheduleInstallation.Name = "btnScheduleInstallation";
            this.btnScheduleInstallation.Size = new System.Drawing.Size(212, 40);
            this.btnScheduleInstallation.TabIndex = 7;
            this.btnScheduleInstallation.Text = "🗓️ Schedule Meter Installation";
            this.btnScheduleInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleInstallation.UseVisualStyleBackColor = false;
            this.btnScheduleInstallation.Click += new System.EventHandler(this.btnScheduleInstallation_Click);
            // 
            // btnBillingReport
            // 
            this.btnBillingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnBillingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillingReport.FlatAppearance.BorderSize = 0;
            this.btnBillingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBillingReport.ForeColor = System.Drawing.Color.White;
            this.btnBillingReport.Location = new System.Drawing.Point(6, 314);
            this.btnBillingReport.Name = "btnBillingReport";
            this.btnBillingReport.Size = new System.Drawing.Size(212, 40);
            this.btnBillingReport.TabIndex = 8;
            this.btnBillingReport.Text = "📄 Log Billing Report";
            this.btnBillingReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillingReport.UseVisualStyleBackColor = false;
            this.btnBillingReport.Click += new System.EventHandler(this.btnBillingReport_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(6, 365);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(212, 40);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "👤 My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelMain.Controls.Add(this.lblOverview);
            this.panelMain.Controls.Add(this.cardMeter);
            this.panelMain.Controls.Add(this.cardBill);
            this.panelMain.Controls.Add(this.cardDispute);
            this.panelMain.Controls.Add(this.cardConnection);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(227, 52);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(684, 470);
            this.panelMain.TabIndex = 7;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.lblOverview.Location = new System.Drawing.Point(9, 13);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(351, 37);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Service Officer Dashboard";
            // 
            // cardMeter
            // 
            this.cardMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.cardMeter.Controls.Add(this.lblMeterCount);
            this.cardMeter.Controls.Add(this.lblMeterText);
            this.cardMeter.Location = new System.Drawing.Point(107, 90);
            this.cardMeter.Name = "cardMeter";
            this.cardMeter.Size = new System.Drawing.Size(186, 91);
            this.cardMeter.TabIndex = 1;
            // 
            // lblMeterCount
            // 
            this.lblMeterCount.AutoSize = true;
            this.lblMeterCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMeterCount.ForeColor = System.Drawing.Color.White;
            this.lblMeterCount.Location = new System.Drawing.Point(69, 3);
            this.lblMeterCount.Name = "lblMeterCount";
            this.lblMeterCount.Size = new System.Drawing.Size(38, 45);
            this.lblMeterCount.TabIndex = 0;
            this.lblMeterCount.Text = "0";
            // 
            // lblMeterText
            // 
            this.lblMeterText.AutoSize = true;
            this.lblMeterText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMeterText.ForeColor = System.Drawing.Color.White;
            this.lblMeterText.Location = new System.Drawing.Point(33, 60);
            this.lblMeterText.Name = "lblMeterText";
            this.lblMeterText.Size = new System.Drawing.Size(105, 19);
            this.lblMeterText.TabIndex = 1;
            this.lblMeterText.Text = "Meter Readings";
            // 
            // cardBill
            // 
            this.cardBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.cardBill.Controls.Add(this.lblPaidBillCount);
            this.cardBill.Controls.Add(this.lblPaidBillText);
            this.cardBill.Location = new System.Drawing.Point(107, 296);
            this.cardBill.Name = "cardBill";
            this.cardBill.Size = new System.Drawing.Size(186, 91);
            this.cardBill.TabIndex = 2;
            // 
            // lblPaidBillCount
            // 
            this.lblPaidBillCount.AutoSize = true;
            this.lblPaidBillCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPaidBillCount.ForeColor = System.Drawing.Color.White;
            this.lblPaidBillCount.Location = new System.Drawing.Point(72, 3);
            this.lblPaidBillCount.Name = "lblPaidBillCount";
            this.lblPaidBillCount.Size = new System.Drawing.Size(38, 45);
            this.lblPaidBillCount.TabIndex = 0;
            this.lblPaidBillCount.Text = "0";
            // 
            // lblPaidBillText
            // 
            this.lblPaidBillText.AutoSize = true;
            this.lblPaidBillText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaidBillText.ForeColor = System.Drawing.Color.White;
            this.lblPaidBillText.Location = new System.Drawing.Point(60, 60);
            this.lblPaidBillText.Name = "lblPaidBillText";
            this.lblPaidBillText.Size = new System.Drawing.Size(62, 19);
            this.lblPaidBillText.TabIndex = 1;
            this.lblPaidBillText.Text = "Paid Bills";
            // 
            // cardDispute
            // 
            this.cardDispute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.cardDispute.Controls.Add(this.lblDisputeCount);
            this.cardDispute.Controls.Add(this.lblDisputeText);
            this.cardDispute.Location = new System.Drawing.Point(402, 93);
            this.cardDispute.Name = "cardDispute";
            this.cardDispute.Size = new System.Drawing.Size(186, 91);
            this.cardDispute.TabIndex = 3;
            // 
            // lblDisputeCount
            // 
            this.lblDisputeCount.AutoSize = true;
            this.lblDisputeCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDisputeCount.ForeColor = System.Drawing.Color.White;
            this.lblDisputeCount.Location = new System.Drawing.Point(68, 3);
            this.lblDisputeCount.Name = "lblDisputeCount";
            this.lblDisputeCount.Size = new System.Drawing.Size(38, 45);
            this.lblDisputeCount.TabIndex = 0;
            this.lblDisputeCount.Text = "0";
            // 
            // lblDisputeText
            // 
            this.lblDisputeText.AutoSize = true;
            this.lblDisputeText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDisputeText.ForeColor = System.Drawing.Color.White;
            this.lblDisputeText.Location = new System.Drawing.Point(34, 60);
            this.lblDisputeText.Name = "lblDisputeText";
            this.lblDisputeText.Size = new System.Drawing.Size(115, 19);
            this.lblDisputeText.TabIndex = 1;
            this.lblDisputeText.Text = "Pending Disputes";
            // 
            // cardConnection
            // 
            this.cardConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.cardConnection.Controls.Add(this.lblConnectionCount);
            this.cardConnection.Controls.Add(this.lblConnectionText);
            this.cardConnection.Location = new System.Drawing.Point(402, 296);
            this.cardConnection.Name = "cardConnection";
            this.cardConnection.Size = new System.Drawing.Size(186, 91);
            this.cardConnection.TabIndex = 4;
            // 
            // lblConnectionCount
            // 
            this.lblConnectionCount.AutoSize = true;
            this.lblConnectionCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblConnectionCount.ForeColor = System.Drawing.Color.White;
            this.lblConnectionCount.Location = new System.Drawing.Point(68, 15);
            this.lblConnectionCount.Name = "lblConnectionCount";
            this.lblConnectionCount.Size = new System.Drawing.Size(38, 45);
            this.lblConnectionCount.TabIndex = 0;
            this.lblConnectionCount.Text = "0";
            // 
            // lblConnectionText
            // 
            this.lblConnectionText.AutoSize = true;
            this.lblConnectionText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConnectionText.ForeColor = System.Drawing.Color.White;
            this.lblConnectionText.Location = new System.Drawing.Point(26, 60);
            this.lblConnectionText.Name = "lblConnectionText";
            this.lblConnectionText.Size = new System.Drawing.Size(138, 19);
            this.lblConnectionText.TabIndex = 1;
            this.lblConnectionText.Text = "Connection Requests";
            // 
            // ServiceOfficerDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceOfficerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Officer Dashboard";
            this.Load += new System.EventHandler(this.ServiceOfficerDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.cardMeter.ResumeLayout(false);
            this.cardMeter.PerformLayout();
            this.cardBill.ResumeLayout(false);
            this.cardBill.PerformLayout();
            this.cardDispute.ResumeLayout(false);
            this.cardDispute.PerformLayout();
            this.cardConnection.ResumeLayout(false);
            this.cardConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnMeterReading;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnReviewDisputes;
        private System.Windows.Forms.Button btnReviewConnections;
        private System.Windows.Forms.Button btnVerifyDocuments;
        private System.Windows.Forms.Button btnScheduleInstallation;
        private System.Windows.Forms.Button btnBillingReport;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Panel cardMeter;
        private System.Windows.Forms.Label lblMeterCount;
        private System.Windows.Forms.Label lblMeterText;
        private System.Windows.Forms.Panel cardBill;
        private System.Windows.Forms.Label lblPaidBillCount;
        private System.Windows.Forms.Label lblPaidBillText;
        private System.Windows.Forms.Panel cardDispute;
        private System.Windows.Forms.Label lblDisputeCount;
        private System.Windows.Forms.Label lblDisputeText;
        private System.Windows.Forms.Panel cardConnection;
        private System.Windows.Forms.Label lblConnectionCount;
        private System.Windows.Forms.Label lblConnectionText;
    }
}