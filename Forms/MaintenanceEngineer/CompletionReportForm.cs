using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class CompletionReportForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public CompletionReportForm()
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

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                return;
            }

            string existingReport = "";

            if (dgvTasks.SelectedRows[0].Cells["CompletionReport"].Value != null)
            {
                existingReport = dgvTasks.SelectedRows[0].Cells["CompletionReport"].Value.ToString();
            }

            txtReport.Text = existingReport;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task to submit a completion report for.");
                return;
            }

            if (txtReport.Text.Trim() == "")
            {
                MessageBox.Show("Please write the completion report before submitting.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);
            int complaintID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["ComplaintID"].Value);
            string report = txtReport.Text.Trim().Replace("'", "''");
            string engineerName = LoginForm.LoggedInFullName;

            DialogResult result = MessageBox.Show(
                "Submit this completion report? This will mark the task as Completed.",
                "Confirm Completion Report",
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

                string updateTaskQuery = "UPDATE MaintenanceTasks SET CompletionReport='" + report +
                                         "', ProgressStatus='Completed', UpdatedAt=GETDATE() WHERE TaskID=" + taskID;
                SqlCommand updateTaskCmd = new SqlCommand(updateTaskQuery, conn);
                int taskRows = updateTaskCmd.ExecuteNonQuery();

                string updateComplaintQuery = "UPDATE Complaints SET Status='Resolved' WHERE ComplaintID=" + complaintID;
                SqlCommand updateComplaintCmd = new SqlCommand(updateComplaintQuery, conn);
                updateComplaintCmd.ExecuteNonQuery();

                string reportDescription = "Completion report submitted for Task ID " + taskID + " by " + engineerName;
                reportDescription = reportDescription.Replace("'", "''");

                string insertReportQuery = "INSERT INTO Reports (CreatedBy, ReportType, CreatedDate, Description) " +
                                           "VALUES (" + LoginForm.LoggedInUserID + ", 'Maintenance', GETDATE(), '" + reportDescription + "')";
                SqlCommand insertReportCmd = new SqlCommand(insertReportQuery, conn);
                insertReportCmd.ExecuteNonQuery();

                if (taskRows > 0)
                {
                    MessageBox.Show("Completion report submitted. Task is now marked as Completed.");
                    txtReport.Clear();
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to submit report.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting completion report: " + ex.Message);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE MaintenanceTasks SET CompletionReport='', UpdatedAt=GETDATE() WHERE TaskID=" + taskID;

                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Completion report removed successfully.");
                    txtReport.Clear();
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to remove completion report.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing completion report: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
