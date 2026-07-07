using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class MaintenanceDashboardForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public MaintenanceDashboardForm()
        {
            InitializeComponent();
            SetWelcomeText();
            LoadDashboardStats();
        }

        private void SetWelcomeText()
        {
            if (!string.IsNullOrEmpty(LoginForm.LoggedInFullName))
            {
                lblWelcome.Text = "Welcome Back, " + LoginForm.LoggedInFullName;
            }
            else
            {
                lblWelcome.Text = "Welcome Back, Maintenance Engineer";
            }
        }

        private void LoadDashboardStats()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                lblAssignedNumber.Text = "0";
                lblMaintenanceNumber.Text = "0";
                lblRepairNumber.Text = "0";
                lblInspectionNumber.Text = "0";
                lblReportNumber.Text = "0";
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string assignedQuery = "SELECT COUNT(*) FROM Complaints WHERE AssignedEngineerID=" + LoginForm.LoggedInUserID + " AND Status='Assigned'";
                SqlCommand assignedCmd = new SqlCommand(assignedQuery, conn);
                lblAssignedNumber.Text = assignedCmd.ExecuteScalar().ToString();

                string maintenanceQuery = "SELECT COUNT(*) FROM MaintenanceTasks WHERE EngineerID=" + LoginForm.LoggedInUserID;
                SqlCommand maintenanceCmd = new SqlCommand(maintenanceQuery, conn);
                lblMaintenanceNumber.Text = maintenanceCmd.ExecuteScalar().ToString();

                string repairQuery = "SELECT COUNT(*) FROM MaintenanceTasks WHERE EngineerID=" + LoginForm.LoggedInUserID + " AND (ProgressStatus='InProgress' OR ProgressStatus='In Progress')";
                SqlCommand repairCmd = new SqlCommand(repairQuery, conn);
                lblRepairNumber.Text = repairCmd.ExecuteScalar().ToString();

                string inspectionQuery = "SELECT COUNT(*) FROM MaintenanceTasks WHERE EngineerID=" + LoginForm.LoggedInUserID + " AND Notes IS NOT NULL AND Notes<>''";
                SqlCommand inspectionCmd = new SqlCommand(inspectionQuery, conn);
                lblInspectionNumber.Text = inspectionCmd.ExecuteScalar().ToString();

                string reportQuery = "SELECT COUNT(*) FROM MaintenanceTasks WHERE EngineerID=" + LoginForm.LoggedInUserID + " AND ProgressStatus='Completed'";
                SqlCommand reportCmd = new SqlCommand(reportQuery, conn);
                lblReportNumber.Text = reportCmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load dashboard stats: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAssignedComplaints_Click(object sender, EventArgs e)
        {
            new AssignedComplaints().ShowDialog();
            LoadDashboardStats();
        }

        private void btnMaintenanceTasks_Click(object sender, EventArgs e)
        {
            new MaintenanceTasksForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnRepairProgress_Click(object sender, EventArgs e)
        {
            new RepairProgressForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnVisitDate_Click(object sender, EventArgs e)
        {
            new VisitDateForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnInspectionNotes_Click(object sender, EventArgs e)
        {
            new InspectionNotesForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnCompletionReport_Click(object sender, EventArgs e)
        {
            new CompletionReportForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm.LoggedInUserID = 0;
                LoginForm.LoggedInFullName = "";
                LoginForm.LoggedInEmail = "";
                LoginForm.LoggedInRole = "";
                LoginForm.LoggedInStatus = "";

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void MaintenanceDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void cardAssignedComplaints_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAssignedNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblReportNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblMaintenanceNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblRepairNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblInspectionNumber_Click(object sender, EventArgs e)
        {

        }


        private void lblBrandIcon_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardMaintenanceTasks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardRepairProgress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
