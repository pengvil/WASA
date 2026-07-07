using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class VisitDateForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public VisitDateForm()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
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
                                    t.TaskID,
                                    t.ComplaintID,
                                    t.EngineerID,
                                    CONVERT(varchar(20), t.VisitDate, 106) AS VisitDate,
                                    t.ProgressStatus,
                                    t.Notes,
                                    t.CompletionReport,
                                    CONVERT(varchar(20), t.UpdatedAt, 106) AS UpdatedAt,
                                    c.Category,
                                    c.Description AS ComplaintDescription,
                                    c.Priority,
                                    c.Status AS ComplaintStatus,
                                    u.FullName AS CustomerName
                                 FROM MaintenanceTasks t
                                 JOIN Complaints c ON t.ComplaintID = c.ComplaintID
                                 JOIN Customers cu ON c.CustomerID = cu.CustomerID
                                 JOIN Users u ON cu.UserID = u.UserID
                                 WHERE t.EngineerID = " + LoginForm.LoggedInUserID + @"
                                 ORDER BY t.UpdatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvTasks.DataSource = dt;
                dgvTasks.AutoGenerateColumns = true;

                dgvTasks.AllowUserToResizeColumns = true;
                dgvTasks.AllowUserToResizeRows = true;

                dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);
            DateTime visitDate = dtpVisitDate.Value;

            if (visitDate.Date < DateTime.Today)
            {
                MessageBox.Show("Visit date cannot be in the past.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Set visit date to " + visitDate.ToString("dd MMM yyyy") + "?",
                "Confirm Visit Date",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (confirmResult != DialogResult.OK)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE MaintenanceTasks SET VisitDate=@VisitDate, UpdatedAt=GETDATE() WHERE TaskID=@TaskID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VisitDate", visitDate);
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Visit date set to " + visitDate.ToString("dd MMM yyyy") + ".");
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to set visit date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting visit date: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpVisitDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
