using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ChangePasswordForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        private int currentUserId;

        public ChangePasswordForm()
        {
            InitializeComponent();

            currentUserId = LoginForm.LoggedInUserID;
        }

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();

            currentUserId = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPass = txtOld.Text;
            string newPass = txtNew.Text;
            string confirm = txtConfirm.Text;

            if (oldPass == "" && newPass == "" && confirm == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (oldPass == "")
            {
                MessageBox.Show("Please enter your current password.");
                txtOld.Focus();
                return;
            }

            if (newPass == "")
            {
                MessageBox.Show("Please enter your new password.");
                txtNew.Focus();
                return;
            }

            if (confirm == "")
            {
                MessageBox.Show("Please confirm your new password.");
                txtConfirm.Focus();
                return;
            }

            if (newPass.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                txtNew.Focus();
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("New passwords do not match.");
                txtConfirm.Focus();
                return;
            }

            if (currentUserId <= 0)
            {
                MessageBox.Show("User information not found. Please login again.");
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string checkQuery = @"SELECT UserID, Password
                                      FROM Users
                                      WHERE UserID = @UserID
                                      AND Password = @OldPassword";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@UserID", currentUserId);
                checkCmd.Parameters.AddWithValue("@OldPassword", oldPass);

                SqlDataAdapter adp = new SqlDataAdapter(checkCmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Current password is incorrect.");
                    txtOld.Clear();
                    txtOld.Focus();
                    return;
                }

                string updateQuery = @"UPDATE Users
                                       SET Password = @NewPassword
                                       WHERE UserID = @UserID";

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@NewPassword", newPass);
                updateCmd.Parameters.AddWithValue("@UserID", currentUserId);

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password changed successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password was not changed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password change error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void lblOld_Click(object sender, EventArgs e)
        {

        }
    }
}