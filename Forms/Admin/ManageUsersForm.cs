using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class ManageUsersForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT UserID, FullName, Email, Phone, Role, Address, Gender, Status, CreatedAt
                                 FROM Users
                                 ORDER BY CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvUsers.DataSource = dt;
                dgvUsers.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE Users SET Status='Active' WHERE UserID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("User activated.");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("User was not activated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error activating user: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            DialogResult result = MessageBox.Show(
                "Deactivate this user?",
                "Confirm Deactivate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE Users SET Status='Inactive' WHERE UserID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("User deactivated.");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("User was not deactivated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deactivating user: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
