using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ServiceOfficerDashboardForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";
        public ServiceOfficerDashboardForm()
        {
            InitializeComponent();
            lbl_Welcome.Text = "Welcome, " + LoginForm.LoggedInFullName;
        }
        private void ServiceOfficerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCounts();
        }
        private void LoadCounts()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                int officerID = LoginForm.LoggedInUserID;

                string queryMeter = @"SELECT COUNT(*) 
                      FROM Bills 
                      WHERE PreviousReading IS NOT NULL 
                      AND CurrentReading IS NOT NULL 
                      AND GeneratedBy = @OfficerID";

                SqlCommand cmdMeter = new SqlCommand(queryMeter, conn);
                cmdMeter.Parameters.AddWithValue("@OfficerID", officerID);
                lblMeterCount.Text = cmdMeter.ExecuteScalar().ToString();


                string queryBill = @"SELECT COUNT(*) 
                     FROM Bills 
                     WHERE Status = 'Paid' 
                     AND GeneratedBy = @OfficerID";

                SqlCommand cmdBill = new SqlCommand(queryBill, conn);
                cmdBill.Parameters.AddWithValue("@OfficerID", officerID);
                lblPaidBillCount.Text = cmdBill.ExecuteScalar().ToString();

                string queryDispute = "SELECT COUNT(*) FROM BillDisputes WHERE Status='Pending' OR Status IS NULL";
                SqlCommand cmdDispute = new SqlCommand(queryDispute, conn);
                lblDisputeCount.Text = cmdDispute.ExecuteScalar().ToString();

                string queryConnection = "SELECT COUNT(*) FROM ConnectionApplications WHERE ApprovalStatus='Pending' OR ApprovalStatus IS NULL";
                SqlCommand cmdConnection = new SqlCommand(queryConnection, conn);
                lblConnectionCount.Text = cmdConnection.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard counts: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            new MeterReadingBillGenerateForm().ShowDialog();
            LoadCounts();

        }

        private void btnListofBill_Click(object sender, EventArgs e)
        {
            new CustomerBillListForm().ShowDialog();
            LoadCounts();

        }

        private void btnReviewDisputes_Click(object sender, EventArgs e)
        {
            new ReviewDisputesForm().ShowDialog();
            LoadCounts();

        }

        private void btnReviewConnections_Click(object sender, EventArgs e)
        {
            new ReviewConnectionApplicationsForm().ShowDialog();
            LoadCounts();

        }

        private void btnVerifyDocuments_Click(object sender, EventArgs e)
        {
            new VerifyDocumentsForm().ShowDialog();
            LoadCounts();

        }

        private void btnScheduleInstallation_Click(object sender, EventArgs e)
        {
            new ScheduleInstallationForm().ShowDialog();
            LoadCounts();
        }

        private void btnBillingReport_Click(object sender, EventArgs e)
        {
            new BillingReportForm().ShowDialog();
            LoadCounts();

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
    }
}