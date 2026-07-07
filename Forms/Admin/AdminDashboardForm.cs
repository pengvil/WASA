using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public AdminDashboardForm()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(LoginForm.LoggedInFullName))
            {
                lblWelcome.Text = "Welcome, " + LoginForm.LoggedInFullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Admin";
            }

            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string queryUsers = "SELECT COUNT(*) FROM Users";
                SqlCommand cmdUsers = new SqlCommand(queryUsers, conn);
                lblCard1Num.Text = cmdUsers.ExecuteScalar().ToString();

                string queryComplaints = "SELECT COUNT(*) FROM Complaints";
                SqlCommand cmdComplaints = new SqlCommand(queryComplaints, conn);
                lblCard2Num.Text = cmdComplaints.ExecuteScalar().ToString();

                string queryPendingEmployees = "SELECT COUNT(*) FROM Users WHERE Status='Pending' AND Role<>'Customer'";
                SqlCommand cmdPendingEmployees = new SqlCommand(queryPendingEmployees, conn);
                lblCard3Num.Text = cmdPendingEmployees.ExecuteScalar().ToString();

                string queryNotices = "SELECT COUNT(*) FROM Notices";
                SqlCommand cmdNotices = new SqlCommand(queryNotices, conn);
                lblCard4Num.Text = cmdNotices.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsersForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnApproveEmployees_Click(object sender, EventArgs e)
        {
            new ApproveEmployeesForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnAssignComplaints_Click(object sender, EventArgs e)
        {
            new AssignComplaintsForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            new NoticeManagementForm().ShowDialog();
            LoadDashboardStats();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new SystemReportForm().ShowDialog();
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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogoArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogoName_Click(object sender, EventArgs e)
        {

        }

        private void lblLogoSub_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCard1Num_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click_2(object sender, EventArgs e)
        {

        }
    }
}
