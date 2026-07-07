using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class ApproveEmployeesForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ApproveEmployeesForm()
        {
            InitializeComponent();
            LoadPending();
        }

        private void LoadPending()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT UserID, FullName, Email, Phone, Role, Address, Gender, Status, CreatedAt
                                 FROM Users
                                 WHERE Status='Pending' AND Role<>'Customer'
                                 ORDER BY CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvPending.DataSource = dt;
                dgvPending.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending employees: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an employee to approve.");
                return;
            }

            int id = Convert.ToInt32(dgvPending.SelectedRows[0].Cells["UserID"].Value);
            string name = dgvPending.SelectedRows[0].Cells["FullName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Approve " + name + "?",
                "Confirm Approval",
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

                string query = "UPDATE Users SET Status='Active' WHERE UserID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(name + " has been approved and can now log in.");
                    LoadPending();
                }
                else
                {
                    MessageBox.Show("Employee was not approved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving employee: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPending();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ApproveEmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPageIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
