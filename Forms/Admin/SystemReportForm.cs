using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class SystemReportForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public SystemReportForm()
        {
            InitializeComponent();
            LoadReportTypes();
            LoadReports();
        }

        private void LoadReportTypes()
        {
            if (cmbType.Items.Count == 0)
            {
                cmbType.Items.Add("User");
                cmbType.Items.Add("Billing");
                cmbType.Items.Add("Complaint");
                cmbType.Items.Add("Connection");
                cmbType.Items.Add("Maintenance");
                cmbType.Items.Add("Notice");
            }
        }

        private void LoadReports()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    r.ReportID,
                                    r.CreatedBy,
                                    u.FullName AS CreatedByName,
                                    r.ReportType,
                                    r.CreatedDate,
                                    r.Description
                                 FROM Reports r
                                 JOIN Users u ON r.CreatedBy = u.UserID
                                 ORDER BY r.CreatedDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvReports.DataSource = dt;
                dgvReports.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            string type = cmbType.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();

            if (type == null || type == "")
            {
                MessageBox.Show("Select a report type.");
                return;
            }

            if (description == "")
            {
                MessageBox.Show("Add a description.");
                txtDescription.Focus();
                return;
            }

            int createdBy = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"INSERT INTO Reports
                                 (CreatedBy, ReportType, CreatedDate, Description)
                                 VALUES
                                 (@CreatedBy, @ReportType, GETDATE(), @Description)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                cmd.Parameters.AddWithValue("@ReportType", type);
                cmd.Parameters.AddWithValue("@Description", description);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Report logged.");
                    txtDescription.Clear();
                    LoadReports();
                }
                else
                {
                    MessageBox.Show("Failed to log report.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
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

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            btnGenerate_Click(sender, e);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
