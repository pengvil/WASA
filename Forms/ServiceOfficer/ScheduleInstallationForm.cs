using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ScheduleInstallationForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ScheduleInstallationForm()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    a.ApplicationID,
                                    a.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.HoldingNumber,
                                    c.MeterNumber,
                                    c.ConnectionType,
                                    a.ApplicationDate,
                                    a.DocumentStatus,
                                    a.ApprovalStatus,
                                    a.RejectionReason,
                                    a.AssignedOfficer,
                                    a.InstallationDate
                                 FROM ConnectionApplications a
                                 JOIN Customers c ON a.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 ORDER BY a.ApplicationDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvApplications.DataSource = dt;
                dgvApplications.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string approvalStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();

            if (approvalStatus != "Approved")
            {
                MessageBox.Show("Only Approved applications can be scheduled for installation.");
                return;
            }

            DateTime installDate = dtpInstallDate.Value.Date;

            if (installDate < DateTime.Today)
            {
                MessageBox.Show("Installation date cannot be in the past.");
                return;
            }

            string installDateText = installDate.ToString("yyyy-MM-dd");

            DialogResult result = MessageBox.Show(
                "Schedule installation on " + installDate.ToString("dd MMM yyyy") + "?",
                "Confirm Installation Date",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE ConnectionApplications " +
                               "SET InstallationDate='" + installDateText + "' " +
                               "WHERE ApplicationID=" + appID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Installation scheduled for " + installDate.ToString("dd MMM yyyy") + ".");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Installation date was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling installation: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}