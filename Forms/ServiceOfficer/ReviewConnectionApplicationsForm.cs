using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ReviewConnectionApplicationsForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";
        public ReviewConnectionApplicationsForm()
        {
            InitializeComponent();
            LoadApplications();
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.MultiSelect = false;
            txtMeterNumber.Enabled = false;
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
                MessageBox.Show("Error loading connection applications: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int meterNumber;
            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            int customerID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["CustomerID"].Value);
            string currentStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();
            int officerID = LoginForm.LoggedInUserID;
            string documentStatus = dgvApplications.SelectedRows[0].Cells["DocumentStatus"].Value.ToString();

            if (documentStatus != "Verified")
            {
                MessageBox.Show("Please verify the documents first.");
                return;
            }

            if (txtMeterNumber.Text == "")
            {
                MessageBox.Show("Please enter a meter number before approving.");
                txtMeterNumber.Focus();
                return;
            }

            if (!int.TryParse(txtMeterNumber.Text.Trim(), out meterNumber))
            {
                MessageBox.Show("Meter number must be a valid number.");
                txtMeterNumber.Focus();
                return;
            }

            if (currentStatus == "Approved")
            {
                MessageBox.Show("This application is already approved.");
                return;
            }

            DialogResult result = MessageBox.Show("Approve this connection application?","Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Customers WHERE MeterNumber =" + meterNumber+" AND CustomerID<>"+customerID;
                SqlCommand checkcmd = new SqlCommand(checkQuery, conn);
                int count = (int)checkcmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Meter number already assigned to another customer. Please enter a different meter number.");
                    txtMeterNumber.Clear();
                    txtMeterNumber.Focus();
                    return;
                }

                string updateCustomerQuery = "UPDATE Customers SET MeterNumber=" + meterNumber + " WHERE CustomerID=" + customerID;
                SqlCommand updateCustomerCmd = new SqlCommand(updateCustomerQuery, conn);
                updateCustomerCmd.ExecuteNonQuery();

                string query = "UPDATE ConnectionApplications " + "SET ApprovalStatus='Approved', RejectionReason='', AssignedOfficer=" + officerID +" WHERE ApplicationID=" + appID;
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Application approved successfully.");
                    txtMeterNumber.Text = "";
                    txtMeterNumber.Enabled = false;
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Application was not approved.");
                    txtMeterNumber.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving application: " + ex.Message);
                txtMeterNumber.Clear();
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string currentStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();


            if (currentStatus == "Rejected")
            {
                MessageBox.Show("This application is already rejected.");
                return;
            }

            string reason = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter rejection reason:",
                "Reject Application",
                ""
            );

            if (reason == "")
            {
                MessageBox.Show("Rejection reason is required.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Reject this connection application?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            int officerID = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE ConnectionApplications " +
                               "SET ApprovalStatus='Rejected', RejectionReason='" + reason + "', AssignedOfficer=" + officerID +
                               " WHERE ApplicationID=" + appID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Application rejected successfully.");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Application was not rejected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rejecting application: " + ex.Message);
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

        private void dgvApplications_SelectionChanged(object sender, EventArgs e) 
        {
            txtMeterNumber.Enabled = true;
        }
    }
}