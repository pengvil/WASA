using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WaterSewageManagementSystem;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class TrackApplicationForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public TrackApplicationForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadApplications();
            }
        }

        private void LoadApplications()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged-in customer found. Please login again.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;

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
                                 WHERE c.UserID = " + userID + @"
                                 ORDER BY a.ApplicationDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvApplications.DataSource = dt;
                dgvApplications.AutoGenerateColumns = true;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No connection application found.");
                }
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

        private void TrackApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
