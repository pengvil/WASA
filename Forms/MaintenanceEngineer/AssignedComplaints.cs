using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class AssignedComplaints : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public AssignedComplaints()
        {
            InitializeComponent();
            LoadComplaints();
        }
        private void LoadComplaints()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in engineer found. Please login again.");
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    c.ComplaintID,
                                    c.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.Category,
                                    c.Description,
                                    c.Priority,
                                    c.Status,
                                    c.AssignedEngineerID,
                                    CONVERT(varchar(20), c.DateSubmitted, 106) AS DateSubmitted
                                 FROM Complaints c
                                 JOIN Customers cu ON c.CustomerID = cu.CustomerID
                                 JOIN Users u ON cu.UserID = u.UserID
                                 WHERE c.AssignedEngineerID = " + LoginForm.LoggedInUserID + @"
                                 ORDER BY c.DateSubmitted DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvComplaints.DataSource = dt;
                dgvComplaints.AutoGenerateColumns = true;

           
                dgvComplaints.AllowUserToResizeColumns = true;
                dgvComplaints.AllowUserToResizeRows = true;

                dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned complaints: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMarkInProgress_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a complaint.");
                return;
            }

            int complaintID = Convert.ToInt32(dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value);

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE Complaints SET Status='In Progress' WHERE ComplaintID=" + complaintID;
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                string taskQuery = "UPDATE MaintenanceTasks SET ProgressStatus='InProgress', UpdatedAt=GETDATE() WHERE ComplaintID=" + complaintID;
                SqlCommand taskCmd = new SqlCommand(taskQuery, conn);
                taskCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Complaint marked as In Progress.");
                    LoadComplaints();
                }
                else
                {
                    MessageBox.Show("Complaint was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating complaint: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMarkResolved_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a complaint.");
                return;
            }

            int complaintID = Convert.ToInt32(dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value);

            DialogResult result = MessageBox.Show(
                "Mark this complaint as Resolved?",
                "Confirm Resolve",
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

                string query = "UPDATE Complaints SET Status='Resolved' WHERE ComplaintID=" + complaintID;
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                string taskQuery = "UPDATE MaintenanceTasks SET ProgressStatus='Completed', UpdatedAt=GETDATE() WHERE ComplaintID=" + complaintID;
                SqlCommand taskCmd = new SqlCommand(taskQuery, conn);
                taskCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Complaint marked as Resolved.");
                    LoadComplaints();
                }
                else
                {
                    MessageBox.Show("Complaint was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resolving complaint: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComplaints();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignedComplaints_Load(object sender, EventArgs e)
        {

        }
    }
}
