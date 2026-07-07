using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ProfileForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        private int currentUserId;

        public ProfileForm()
        {
            InitializeComponent();

            currentUserId = LoginForm.LoggedInUserID;
        }

        public ProfileForm(int userId)
        {
            InitializeComponent();

            currentUserId = userId;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (currentUserId <= 0)
            {
                MessageBox.Show("User information not found. Please login again.");
                this.Close();
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT FullName, Email, Phone, Address, Role, Status
                                 FROM Users
                                 WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", currentUserId);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["FullName"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();

                    lblRole.Text = "Role: " + dt.Rows[0]["Role"].ToString();
                    lblStatus.Text = "Status: " + dt.Rows[0]["Status"].ToString();

                    txtEmail.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Profile not found.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Name cannot be empty.");
                txtName.Focus();
                return;
            }

            if (phone == "")
            {
                MessageBox.Show("Phone cannot be empty.");
                txtPhone.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"UPDATE Users
                                 SET FullName = @FullName,
                                     Phone = @Phone,
                                     Address = @Address
                                 WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@UserID", currentUserId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                }
                else
                {
                    MessageBox.Show("Could not update profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(currentUserId);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete your profile?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string roleQuery = "SELECT Role FROM Users WHERE UserID = @UserID";
                SqlCommand roleCmd = new SqlCommand(roleQuery, conn);
                roleCmd.Parameters.AddWithValue("@UserID", currentUserId);

                object roleResult = roleCmd.ExecuteScalar();

                if (roleResult == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                string role = roleResult.ToString();

                if (role == "Customer")
                {
                    string deleteCustomerQuery = "DELETE FROM Customers WHERE UserID = @UserID";
                    SqlCommand customerCmd = new SqlCommand(deleteCustomerQuery, conn);
                    customerCmd.Parameters.AddWithValue("@UserID", currentUserId);
                    customerCmd.ExecuteNonQuery();
                }

                string deleteUserQuery = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand userCmd = new SqlCommand(deleteUserQuery, conn);
                userCmd.Parameters.AddWithValue("@UserID", currentUserId);

                int rows = userCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Profile deleted successfully. You will be logged out.");

                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Could not delete profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting profile: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}