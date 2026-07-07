using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class InspectionNotesForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public InspectionNotesForm()
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

            string existingNotes = "";

            if (dgvTasks.SelectedRows[0].Cells["Notes"].Value != null)
            {
                existingNotes = dgvTasks.SelectedRows[0].Cells["Notes"].Value.ToString();
            }

            txtNotes.Text = existingNotes;
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            if (txtNotes.Text.Trim() == "")
            {
                MessageBox.Show("Please enter inspection notes before saving.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);
            string notes = txtNotes.Text.Trim().Replace("'", "''");

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE MaintenanceTasks SET Notes='" + notes +
                               "', UpdatedAt=GETDATE() WHERE TaskID=" + taskID;

                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Inspection notes saved successfully.");
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to save notes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving notes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

                string query = "UPDATE MaintenanceTasks SET Notes='', UpdatedAt=GETDATE() WHERE TaskID=" + taskID;

                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Inspection note removed successfully.");
                    txtNotes.Clear();
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to remove note.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing note: " + ex.Message);
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

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
