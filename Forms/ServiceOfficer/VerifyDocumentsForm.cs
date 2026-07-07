using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class VerifyDocumentsForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public VerifyDocumentsForm()
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

        private void btnVerify_Click(object sender, EventArgs e)
        {

            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string documentStatus = dgvApplications.SelectedRows[0].Cells["DocumentStatus"].Value.ToString();

            if (documentStatus == "Verified")
            {
                MessageBox.Show("Documents are already verified for this application.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark documents as Verified for this application?",
                "Confirm Document Verification",
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
                               "SET DocumentStatus='Verified' " +
                               "WHERE ApplicationID=" + appID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Documents verified successfully. You can now approve the connection application.");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Document status was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying documents: " + ex.Message);
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